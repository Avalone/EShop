﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EShop.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string JoinIp { get; set; }
        public string Address { get; set; }
        //public int? CityId { get; set; }
        //public string Refference { get; set; }

        //[ForeignKey("CityId")]
        //public virtual City City { get; set; }
        //public virtual ICollection<ProductComments> ProductCommentses { get; set; }
        //public virtual ICollection<Orders> Orderses { get; set; }
        //public virtual ICollection<OrderStatus> OrderStatuses { get; set; }

        ////public virtual ICollection<UserLoginHistory> UserLoginHistories { get; set; }
        //// public virtual ICollection<ProductLikes> ProductLikeses { get; set; }
    }
}