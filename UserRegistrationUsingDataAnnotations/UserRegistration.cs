using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationUsingDataAnnotations
{
    public class UserRegistration
    {
        [Required(ErrorMessage = "First Name is required. It shouldn't be empty ")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "Name should have minimum of 3 charaters and maximum 100 characters")]
        [RegularExpression("^[A-Z][a-z]{2,}$", ErrorMessage = "Name is invalid ")]
        [DataType(DataType.Text)]
        public string FirstName1 { get; set; }



        [Required(ErrorMessage = "Last Name is required. It shouldn't be empty ")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name should have minimum of 3 charaters and maximum 100 characters")]
        [RegularExpression("^[A-Z][a-z]{3,}$", ErrorMessage = "Last Name is invalid ")]
        [DataType(DataType.Text)]
        public string LastName1 { get; set; }
    }

}


