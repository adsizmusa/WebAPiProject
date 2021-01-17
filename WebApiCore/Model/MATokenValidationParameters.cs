using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace WebApiCore.Model
{
    public class MATokenValidationParameters
    {
        public static TokenValidationParameters GetTokenValidationParameters()
        {
            return HBTokenParameters.GetTokenValidationParameters();
        }
    }
    public class HBTokenParameters
        {
            /// <summary>
            /// https://github.com/dwyl/learn-json-web-tokens
            /// var hmac = new HMACSHA256(); var Secret = Convert.ToBase64String(hmac.Key);
            /// </summary>
            private const string Secret = "obVRSXzyCfwBjzqkmRFKqhKIF4M8Cxdp11vW6GKM6XCDbv/65XgWSWWFif8Q53BWvbfluL1ldENo05oOCOEL/w==";

            private const string Issuer = "MAAuthManager";
            private const string Audience = "MAUsers";

            internal static string GetSecret()
            {
                return Secret;
            }

            internal static string GetAudience()
            {
                return Audience;
            }

            internal static string GetIssuer()
            {
                return Issuer;
            }

            internal static TokenValidationParameters GetTokenValidationParameters()
            {
                return new TokenValidationParameters
                {
                    ValidateAudience = true,
                    ValidAudience = Audience,

                    ValidateIssuer = true,
                    ValidIssuer = Issuer,

                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Convert.FromBase64String(Secret)),

                    RequireExpirationTime = true,
                    // Make sure the token is still valid
                    ValidateLifetime = true,

                    // Set ClockSkew if tolerance of the expire is needed (might be needed if client and server are in different time zones)
                    // ClockSkew = TimeSpan.Zero
                };
            }
        }

        public class HBAuthManager
        {
            /// <summary>
            /// Generates a serialized JWT
            /// </summary>
            /// <param name="username">The username that will be put in the token</param>
            public static string GenerateToken(string username, int companyID)
            {
                var symterticKey = Convert.FromBase64String(HBTokenParameters.GetSecret());
                var tokenHandler = new JwtSecurityTokenHandler();

                var now = DateTime.UtcNow;
                var tokenDescriptor = new SecurityTokenDescriptor
                {
                    Subject = new System.Security.Claims.ClaimsIdentity(new[]
                    {
                    new Claim(ClaimTypes.Name, username),
                    new Claim(ClaimTypes.UserData, Convert.ToString(companyID))
                }),

                    Audience = HBTokenParameters.GetAudience(),

                    Issuer = HBTokenParameters.GetIssuer(),

                    Expires = now.AddDays(30),

                    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(symterticKey), SecurityAlgorithms.HmacSha256Signature)
                };

                var stoken = tokenHandler.CreateToken(tokenDescriptor);
                var token = tokenHandler.WriteToken(stoken);

                return token;
            }

            /// <summary>
            /// Validate the token and return the claims principle or else return null
            /// </summary>
            public static ClaimsPrincipal GetPrincipal(string token)
            {
                try
                {
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var jwtToken = tokenHandler.ReadToken(token) as JwtSecurityToken;

                    if (jwtToken == null) return null;

                    var symmetricKey = Convert.FromBase64String(HBTokenParameters.GetSecret());

                    var validationParameters = new TokenValidationParameters()
                    {
                        RequireExpirationTime = true,
                        ValidateIssuer = true,
                        ValidIssuer = HBTokenParameters.GetIssuer(),
                        ValidateAudience = true,
                        ValidAudience = HBTokenParameters.GetAudience(),
                        IssuerSigningKey = new SymmetricSecurityKey(symmetricKey)
                    };

                    var principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken securityToken);

                    return principal;
                }
                catch (Exception)
                {
                    return null;
                }
            }
        }
    }

