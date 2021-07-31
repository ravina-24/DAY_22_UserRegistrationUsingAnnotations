using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace UserRegistrationUsingDataAnnotations
{
    public class AnnotationTest 
    {
        public static void Display()
        {
            Console.Write("Enter First Name : ");
            string FirstName = Console.ReadLine();

            Console.Write("Enter Last Name  : ");
            string LastName = Console.ReadLine();

            Console.Write("Enter Email address : ");
            string EmailId = Console.ReadLine();



            Console.WriteLine("User Registartion Validations");

            Console.WriteLine("<---------------------------------->");

            UserRegistration userRegistration = new UserRegistration();

            userRegistration.FirstName1 = FirstName;
            userRegistration.LastName1 = LastName;
            userRegistration.EmailId1 = EmailId;
           
            ValidationContext context = new System.ComponentModel.DataAnnotations.ValidationContext(userRegistration, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(userRegistration, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult TotalResult in results)
                {
                    Console.WriteLine("Member Name : {0}", TotalResult.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Msg : {0}", TotalResult.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine("FirstName: " + userRegistration.FirstName1 + "\n "
                                 +"LastName : " +userRegistration.LastName1  + "\n"  
                                 +"EmailId  : "  +userRegistration.EmailId1);
            }
            
            Console.ReadKey();
        }
    }

}
