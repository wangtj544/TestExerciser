using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Threading;
using System.Windows.Forms;
using TestExerciser.User;

namespace TestExerciser.Logic
{
    class ManageDB
    {
        public static string userFullName = null;
        public static string userEmailAddress = null;
        public static string updateDBStatus =null;
       
        OleDbConnection mycon = null;
        OleDbDataReader myReader = null;
        
        //string strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + @"..\..\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";
        public static string strcon = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\TestExerciser.accdb;Jet OLEDB:Database Password=admin@123";

        public bool checkUserNameDuplicate(string userName)
        {
            bool falg = false;
            string selectFullName = "select ID from 用户信息 where userName=" + "'" + userName + "'";
            try
            {
                mycon = new OleDbConnection(strcon);
                mycon.Open();
                OleDbCommand mycom = new OleDbCommand(selectFullName, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool queryUserFullName(string userName,string passwd)
        {
            bool falg = false;
            string selectFullName = "select fullName from 用户信息 where userName=" + "'" + userName + "'" + "AND" + "[passWord]=" + "'" + passwd + "'";
            try
            {               
                mycon = new OleDbConnection(strcon);
                mycon.Open();
                OleDbCommand mycom = new OleDbCommand(selectFullName, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                    while (myReader.Read())
                    {
                        userFullName = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public bool queryEmailAddress(string userName, string passwd)
        {
            bool falg = false;
            string mySQL = "select email from 用户信息 where userName=" + "'" + userName + "'" + "AND" + "[passWord]=" + "'" + passwd + "'";
            try
            {
                mycon = new OleDbConnection(strcon);
                mycon.Open();
                OleDbCommand mycom = new OleDbCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                    while (myReader.Read())
                    {
                        userEmailAddress = Convert.ToString(myReader[0]);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }

        public void UpdateDB(string sql)
        {
            mycon = new OleDbConnection(strcon);
            mycon.Open();
            OleDbCommand mycomm = new OleDbCommand(sql, mycon);
            mycomm.Connection = mycon;
            mycomm.CommandText = sql;
            if (mycomm.ExecuteNonQuery() > 0)
            {
                updateDBStatus = "数据更新成功！";
            }
            else
            {
                updateDBStatus = "数据更新失败！";
            }
            mycomm.Dispose();
            mycon.Close();
            mycon.Dispose();
        }

        public void UpdateDB(string column, Control txtChangeTo)
        {
            UpdateDB("update 用户信息 set " + column + "='" + txtChangeTo.Text + "'" + " where userName='" + UserLogin.pubUserName + "'");
        }

        public void UpdateDB(string column, string changeTo)
        {
            UpdateDB("update 方法封装 set " + column + "='" );
        }

        public bool checkUserName(string userName)
        {
            bool falg = false;
            string mySQL = "select ID from 用户信息 where userName=" + "'" + userName +"'";
            try
            {
                mycon = new OleDbConnection(strcon);
                mycon.Open();
                OleDbCommand mycom = new OleDbCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();
            }
            return falg;
        }

        public bool userMailToResetPassword(string userName, string userEmail)
        {
            bool falg = false;
            string mySQL = "select ID from 用户信息 where userName=" + "'" + userName + "'" + "AND" + "[email]=" + "'" + userEmail + "'";
            try
            {
                mycon = new OleDbConnection(strcon);
                mycon.Open();
                OleDbCommand mycom = new OleDbCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    falg = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myReader.Close();
                mycon.Close();

            }
            return falg;
        }
    }
}
