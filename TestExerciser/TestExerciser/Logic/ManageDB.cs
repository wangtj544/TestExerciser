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
        public static List<ListItem> items = new List<ListItem>();

        public static  ListItem listItem;



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

        public bool checkReviewTo()
        {
            bool falg = false;
            string selectFullName = "select email from 用户管理 where reviewTo='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(selectFullName, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {                   
                    while (myReader.Read())
                    {
                        if (userEmailAddress == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }
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

        public bool checkReviewFrom()
        {
            bool falg = false;
            string selectFullName = "select email from 用户管理 where reviewFrom='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(selectFullName, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (userEmailAddress == Convert.ToString(myReader[0]))
                        {
                            falg = true;
                            break;
                        }                                               
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

        public void UpdateDB(string table, string column, Control txtChangeTo)
        {
            UpdateDB("update " + table + " set " + column + "='" + txtChangeTo.Text + "'" + " where userName='" + UserLogin.pubUserName + "'");
        }

        public void UpdateDB(string table, string column, string changeTo,string otherColumn,string otherChangeTo)
        {
            UpdateDB("update " + table + " set " + column + "='" + changeTo + "'" + " where " + otherColumn + "='" + otherChangeTo + "'");
        }

        public void UpdateDB(string table, string column, string changeTo)
        {
            UpdateDB("update " + table + " set " + column + "='" + changeTo + "'");
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

        public bool selectItems(ComboBox comBox)
        {
            bool falg = false;
            string mySQL = "select * from 用户管理";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    listItem = new ListItem(row["email"].ToString(),row["fullName"].ToString()+"("+row["email"].ToString() +")");
                    comBox.Items.Add(listItem);
                }
                comBox.DisplayMember = "Text";
                comBox.ValueMember = "Value";
                listItem = (ListItem)comBox.SelectedItem;
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

        public bool clearList(ComboBox comBox)
        {
            bool falg = false;
            string mySQL = "select * from 用户管理";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow row in mydt.Rows)
                {
                    comBox.Items.Clear();
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

        public void InsertInto(string sql)
        {
            mycon = new SqlConnection(strcon);
            mycon.Open();
            SqlCommand mycomm = new SqlCommand(sql, mycon);
            mycomm.Connection = mycon;
            mycomm.CommandText = sql;
            if (mycomm.ExecuteNonQuery() > 0)
            {
                updateDBStatus = "数据添加成功！";
            }
            else
            {
                updateDBStatus = "数据添加失败！";
            }
            mycomm.Dispose();
            mycon.Close();
            mycon.Dispose();
        }


    }
}
