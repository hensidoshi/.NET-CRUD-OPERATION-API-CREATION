﻿using System.ComponentModel.DataAnnotations;
namespace CoffeeShop_APICreation.Models
{
    public class UserModel
    {
        public int? UserID { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string MobileNo { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
    }
    //public class UserRegisterModel
    //{
    //    public int? UserID { get; set; }

    //    [Required(ErrorMessage = "Username is required.")]
    //    public string UserName { get; set; }

    //    [Required(ErrorMessage = "Password is required.")]
    //    public string Password { get; set; }

    //    [Required(ErrorMessage = "Email is required.")]
    //    [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$")]
    //    public string Email { get; set; }

    //    [Required(ErrorMessage = "Mobile Number is required.")]
    //    [MinLength(10)]
    //    [MaxLength(10)]
    //    public string MobileNo { get; set; }

    //    [Required(ErrorMessage = "Address is required.")]
    //    public string Address { get; set; }
    //}
    //public class UserLoginModel
    //{
    //    [Required(ErrorMessage = "Username is required.")]
    //    public string UserName { get; set; }

    //    [Required(ErrorMessage = "Password is required.")]
    //    public string Password { get; set; }
    //}
}
