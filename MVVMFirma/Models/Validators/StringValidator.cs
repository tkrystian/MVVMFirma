using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MVVMFirma.Models.Validators
{
    public class StringValidator : Validator
    {
        private static string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        private static string timeRegex = @"^([01]\d|2[0-3]):([0-5]\d)$";
        public static string SprawdzCzyZaczynaSieZDuzejLitery(string wartosc)
         {
            try
            {
                if (!char.IsUpper(wartosc, 0))
                {
                    return "Rozpocznij duza litera";
                }
            }
            catch (Exception e) { }
            return null;
         }

        public static string SprawdzPoprawnoscEmail(string wartosc)
        {
            try
            {
                if (!Regex.IsMatch(wartosc, emailRegex))
                {
                    return "Wprowadz poprawny email";
                }
            }
            catch (Exception e) 
            {
                //return e.Message;
            }
            return null;
        }
        
        
    }
}
