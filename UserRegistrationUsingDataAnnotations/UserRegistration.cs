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
        [DataType(DataType.Text)]
        public string FirstName1 { get; set; }



        [Required(ErrorMessage = "Last Name is required. It shouldn't be empty ")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Last Name should have minimum of 3 charaters and maximum 100 characters")]
        [DataType(DataType.Text)]
        public string LastName1 { get; set; }

        [Required(ErrorMessage = "Email is required. It shouldn't be empty ")]
        [DataType(DataType.EmailAddress)]
        public string EmailId1 { get; set; }


        [Required(ErrorMessage = "Phone Number is required. It shouldn't be empty ")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber1 { get; set; }


        [Required(ErrorMessage = "Password is required. It shouldn't be empty ")]
        [StringLength(15, MinimumLength = 8, ErrorMessage = "Password should have minimum of 8 charaters ")]
        [DataType(DataType.Text)]
        public string Password1 { get; set; }
    }

}


