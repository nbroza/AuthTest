using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.CognitoIdentity;
using Amazon.CognitoIdentityProvider;
using Amazon.CognitoIdentityProvider.Model;
using Amazon.Extensions.CognitoAuthentication;
using Amazon.Runtime;


namespace BigBoyPrototype.Controls
{
    class CognitoHelper
    {
        RegionEndpoint REGION = RegionEndpoint.USEast1;
        private string CLIENT_ID = "INSERT ID";
        private string USERPOOL_ID = "INSERT USERPOOL";
        private string IDENTITYPOOL_ID = null;
        private string CUSTOMDOMAIN = null;

        internal async Task<CognitoUser> ValidateUser(string username, string password)
        {
            AmazonCognitoIdentityProviderClient providerClient = new AmazonCognitoIdentityProviderClient(new AnonymousAWSCredentials(), REGION);
            CognitoUserPool userPool = new CognitoUserPool(USERPOOL_ID, CLIENT_ID, providerClient);
            CognitoUser user = new CognitoUser(username, CLIENT_ID, userPool, providerClient);

            InitiateSrpAuthRequest authRequest = new InitiateSrpAuthRequest() { Password = password };

            AuthFlowResponse authResponse = await user.StartWithSrpAuthAsync(authRequest).ConfigureAwait(true);

            while (authResponse.AuthenticationResult == null)
            {
                if (authResponse.ChallengeName == ChallengeNameType.NEW_PASSWORD_REQUIRED)
                {
                    authResponse = await user.RespondToNewPasswordRequiredAsync(new RespondToNewPasswordRequiredRequest()
                    {
                        NewPassword = password,
                        SessionID = authResponse.SessionID
                    }).ConfigureAwait(true);
                }
            }

            if (authResponse.AuthenticationResult != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }

        internal async Task<bool> SignUpUser(string username, string password, string email, string birthdate)
        {
            AmazonCognitoIdentityProviderClient provider = new AmazonCognitoIdentityProviderClient(new AnonymousAWSCredentials(), REGION);

            SignUpRequest signUpRequest = new SignUpRequest()
            {
                ClientId = CLIENT_ID,
                Username = username,
                Password = password
            };

            AttributeType emailAttribute = new AttributeType()
            {
                Name = "email",
                Value = email
            };
            signUpRequest.UserAttributes.Add(emailAttribute);

            AttributeType ageAttribute = new AttributeType()
            {
                Name = "birthdate",
                Value = birthdate
            };
            signUpRequest.UserAttributes.Add(ageAttribute);

            SignUpResponse result = await provider.SignUpAsync(signUpRequest);

            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        internal async Task<bool> VerifyAccessCode(string username, string code)
        {
            AmazonCognitoIdentityProviderClient provider = new AmazonCognitoIdentityProviderClient(new AnonymousAWSCredentials(), REGION);
            ConfirmSignUpRequest confirmSignUpRequest = new ConfirmSignUpRequest()
            {
                Username = username,
                ConfirmationCode = code,
                ClientId = CLIENT_ID
            };

            ConfirmSignUpResponse result = provider.ConfirmSignUp(confirmSignUpRequest);

            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
