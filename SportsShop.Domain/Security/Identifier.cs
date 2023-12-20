using System;
using System.Security.Claims;

namespace SportsShop.Domain.Security
{
    /// <summary>
    /// select id users
    /// </summary>
  public  static class Identifier
    {
        public static int GetUserId(this ClaimsPrincipal claims)
        {
            var userId = claims.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            return Convert.ToInt32(userId);
        }
       
    }
}
