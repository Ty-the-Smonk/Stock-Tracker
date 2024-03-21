using MySqlX.XDevAPI.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Tracker
{
    internal class Password_Regex
    {
        public static bool IsValid(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*\d).{7,}$");
        }
    }
}
