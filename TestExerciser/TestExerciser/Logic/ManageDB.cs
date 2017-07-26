using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;
using TestExerciser.User;
using TestExerciser.Tools;
using CCWin;

namespace TestExerciser.Logic
{
    class ManageDB
    {
        public static string userFullName = null;
        public static string userEmailAddress = null;
        public static string updateDBStatus =null;
       
        SqlConnection mycon = null;
        SqlDataReader myReader = null;
      
        public static string strcon = Properties.Settings.Default.ConnectionString;
        string[] fullName = null;
        string[] email = null;

        public static List<ListItem> autoList = new List<ListItem>();
        public static List<ListItem> coverList = new List<ListItem>();



        public bool checkUserNameDuplicate(string userName)
        {
            bool falg = false;
            string selectFullName = "select ID from 用户管理 where userName=" + "'" + userName + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(selectFullName, mycon);
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
            string selectFullName = "select fullName from 用户管理 where userName=" + "'" + userName + "'" + "AND" + "[passWord]=" + "'" + passwd + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(selectFullName, mycon);
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
            string mySQL = "select email from 用户管理 where userName=" + "'" + userName + "'" + "AND" + "[passWord]=" + "'" + passwd + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
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
            mycon = new SqlConnection(strcon);
            mycon.Open();
            SqlCommand mycomm = new SqlCommand(sql, mycon);
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
            UpdateDB("update 用户管理 set " + column + "='" + txtChangeTo.Text + "'" + " where userName='" + UserLogin.pubUserName + "'");
        }

        public void UpdateDB(string column, string changeTo)
        {
            UpdateDB("update 方法封装 set " + column + "='" );
        }

        public bool checkUserName(string userName)
        {
            bool falg = false;
            string mySQL = "select ID from 用户管理 where userName=" + "'" + userName +"'";
   
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
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
                if (myReader != null)
                {
                    myReader.Close();
                    mycon.Close();
                }                
            }
            return falg;
        }

        public bool userMailToResetPassword(string userName, string userEmail)
        {
            bool falg = false;
            string mySQL = "select ID from 用户管理 where userName=" + "'" + userName + "'" + "AND" + "[email]=" + "'" + userEmail + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
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
        
        public bool showTeamMembers()
        {
            bool falg = false;
            string mySQL = "select fullName from 用户管理";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
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

        public void selectAutoFullName()
        {
            selectItems(autoList, fullName);
        }

        public void selectCoverFullName()
        {
            selectItems(coverList, fullName);
        }

        public void clearFullNameList()
        {
            clearList(autoList,coverList);
        }


        public void selectAuto()
        {
            selectItems(autoList,email);
        }

        public void selectCover()
        {
            selectItems(coverList,email);
        }

        public bool selectItems(List<ListItem>list,Array itemList)
        {
            bool falg = false;
            string mySQL = "select fullName [email] from 用户管理";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    list.Add(new ListItem(row["fullName"].ToString(),row["email"].ToString()));
                    itemList = list.ToArray();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return falg;
        }


        public bool clearList(List<ListItem> list1, List<ListItem> list2)
        {
            bool falg = false;
            string mySQL = "select fullName from 用户管理";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    list1.Remove(new ListItem(row["fullName"].ToString(),row["email"].ToString()));
                    list2.Remove(new ListItem(row["fullName"].ToString(), row["email"].ToString()));
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return falg;
        }
    }
}
