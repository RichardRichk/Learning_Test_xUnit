using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MailCode
{
    public class Mail
    {
        public static bool ValidationMail(string mail)
        {
            if (string.IsNullOrEmpty(mail))
            {
                return false;
            }

            // Usando uma expressão regular simples para validação de email
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]{2,}$";
            return Regex.IsMatch(mail, pattern);

        }
    }
}
