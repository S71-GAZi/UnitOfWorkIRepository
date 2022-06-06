using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UnitOfWorkRepositoryMVC.Models
{
    public class UserModel
    {
        public int UserModelID { get; set; }
        [Required,StringLength(50)]
        public string UserName { get; set; }
        [Required,StringLength(50)]
        public string UserPassword { get; set; }
    }
}