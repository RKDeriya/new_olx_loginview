using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace authentication.Models
{
    public class LoginModel
    {
        public int userId { get; set; }
       public string firstname{ get; set; }
       public string lastname{ get; set; }

        [Required(ErrorMessage = "required")]
        //[DataType(DataType.EmailAddress)]
        //[RegularExpression(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+.[a-zA-Z]{2,}$", ErrorMessage = "Invalid email format.")]
        [Display(Name = "UserEmail")]
        public string userEmail { get; set; }


        [Required(ErrorMessage = "required")]
        public string userPassword { get; set; }


        [Required(ErrorMessage = "required")]
        public string MobileNo { get; set; }
        public string Gender { get; set; }
        public DateTime Dob { get; set; }
        public string Roles { get; set; }
    }

    public class LoginUser
    {
        public int LoginUserId { get; set; }
        public string LoginOtp { get; set; }

        public DateTime ExpirationLoginTime { get; set; }
        public int userIdByLoginUser { get; set; }
    }

}