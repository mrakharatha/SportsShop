using System.ComponentModel.DataAnnotations;
using SportsShop.Domain.Models.Permissions;

namespace SportsShop.Domain.Models.User
{
  public  class UserRole
    {
        [Key]
        public int UserRoleId { get; set; }
        public int UserId { get; set; }
        public int RoleId { get; set; }


        #region Relations

  //      public  User User { get; set; }
        public  Role Role { get; set; }

        #endregion
    }
}
