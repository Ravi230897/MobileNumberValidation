using System;
using System.Text.RegularExpressions;

namespace MobileNumberValidation
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string mobileNumber = "9876543210";

            bool isValid = IsValidIndianMobileNumber(mobileNumber);

            if (isValid)
            {
                Console.WriteLine("Valid Indian mobile number.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Indian mobile number.");
                Console.ReadLine();
            }
            Console.ReadLine();
        }

        public static bool IsValidIndianMobileNumber(string mobileNumber)
        {
            // Indian mobile number pattern
            string pattern = @"^(?:(?:\+|0{0,2})91(\s*[-]\s*)?|[0]?)?[6789]\d{9}$";

            // Create a regular expression object
            Regex regex = new Regex(pattern);

            // Match the mobile number against the pattern
            Match match = regex.Match(mobileNumber);

            // Return true if the mobile number is valid, otherwise false
            return match.Success;


        }

    }

}


// C# program to validate the Mobile
// Number using Regular Expressions
//using System;
//using System.Text.RegularExpressions;

//namespace MobileNumberValidation
//{
//    public class Program
//    {
//        // Main Method
//        static void Main(string[] args)
//        {
//            // Input strings to Match
//            // valid mobile number
//            string str = "347873923408";
//            if (isValid(str))
//            {
//                Console.WriteLine("Valid Number");
//                Console.ReadLine();
//            }
//            else
//            {
//                Console.WriteLine("Invalid Number");
//            }
//            Console.ReadLine();
//        }

//        // method containing the regex
//        public static bool isValid(string str)
//        {
//            string strRegex = @"^(0|91)?[6-9][0-9]{9}$";
//            Regex re = new Regex(strRegex);
//            if (re.IsMatch(str))
//                return (true);
//            else
//                return (false);

//        }

//    }
//}
////This code is contributed by Rahul Chauhan
