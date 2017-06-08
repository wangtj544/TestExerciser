using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace TestExerciser.User
{
    class LoginInfo
    {

        public bool isMailAddress(string emailAddress)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(emailAddress, @"^[A-Z0-9._%+-]+@(?:[A-Z0-9-]+\.)+[A-Z]{2,6}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        public bool isPasswdSecurity(string txtPasswd)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtPasswd, @"\A(?=[\x20-\x7E]*?[A-Z])(?=[\x20-\x7E]*?[a-z])(?=[\x20-\x7E]*?[0-9])[\x20-\x7E]{6,20}\z", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        public bool isChineseChar(string txtFullName)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtFullName, @"^[\u4e00-\u9fa5]{1,10}", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }

        public bool isUserNameFair(string txtUserName)
        {
            bool foundMatch = false;
            try
            {
                foundMatch = Regex.IsMatch(txtUserName, @"^(?![0-9]*$)[a-zA-Z0-9]{6,20}$", RegexOptions.IgnoreCase | RegexOptions.Singleline);
            }
            catch (ArgumentException exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return foundMatch;
        }
    }
}
