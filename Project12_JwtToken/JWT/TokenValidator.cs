using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Project12_JwtToken.JWT
{
	public class TokenValidator
	{
		public ClaimsPrincipal ValidateJwtToken(string token)
		{
			var tokenHandler = new JwtSecurityTokenHandler();
			var key = Encoding.UTF8.GetBytes("20MiniProjectToken+-*/1234tokenJWT");
			try
			{
				var principal = tokenHandler.ValidateToken(token, new TokenValidationParameters
				{
					ValidateIssuerSigningKey = true,
					IssuerSigningKey = new SymmetricSecurityKey(key),
					ValidateIssuer = true,
					ValidIssuer = "localhost",
					ValidateAudience = true,
					ValidAudience = "localhost",
					ValidateLifetime = true,
					ClockSkew = TimeSpan.Zero,
				}, out SecurityToken validatedToken);

				return principal;
			}
			catch (Exception)
			{
				return null;
			}
		}
	}
}
