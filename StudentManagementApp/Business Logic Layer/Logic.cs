using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementApp.Business_Logic_Layer
{
    internal class Logic
    {
        public bool ValidateEmail(string email)
        {
            var valid = true;

            try
            {
                var test = new MailAddress(email);
            }
            catch
            {
                valid = false;
            }
            return valid;
        }
    }
}
