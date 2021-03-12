using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class User : IdentityUser
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public int UserRoleID { get; set; }
    }

    public class Role
    {
        [Key]
        public int RoleID { get; set; }
        public string RoleName { get; set; }
    }

    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string ItemPrice { get; set; }
    }

    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int OrderItemID { get; set; }
        public DateTime OrderTime { get; set; }
        public int OrderUserID { get; set; }
    }

    public class PaymentMode
    {
        [Key]
        public int PayModeID { get; set; }
        public int PaymentType { get; set; }
    }
}
