﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationUsingDataAnnotations
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "Users {0} is required. ")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should have minimum of 3 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string FirstName1 { get; set; }

        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name should have minimum of 3 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string LastName1 { get; set; }

     
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string EmailId1 { get; set; }


        [DataType(DataType.PhoneNumber)]
        [Phone]
        public string PhoneNumber1 { get; set; }

        [StringLength(15, MinimumLength = 8, ErrorMessage = "Password should have minimum of 8  charaters ")]
        [DataType(DataType.Password)]
        public string Password1 { get; set; }
    }

}


