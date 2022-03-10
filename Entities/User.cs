﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WahalafreeAPI.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        [Required(AllowEmptyStrings =false, ErrorMessage ="First Name is Required")]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Surname  is Required")]
        public string SurName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Email  is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Password  is Required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = " Comfirm-Password  is Required")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Password must Match")]
        public string ConfirmPassword { get; set; }
       
        public DateTime CreatedOn { get; set; }

    }
}
