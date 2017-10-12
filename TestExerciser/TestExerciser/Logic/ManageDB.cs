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


        /// <summary>
        /// 获取数据表中的特定值
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="valueA"></param>
        /// <param name="rowB"></param>
        /// <param name="valueB"></param>
        /// <returns></returns>
        public string getDataFromCell(string row,string table,string rowA,string valueA,string rowB,string valueB)
        {
            string mycell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'" + "AND" + "" + rowB + "=" + "'" + valueB + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        mycell = Convert.ToString(myReader[0]);
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
            return mycell;
        }

        /// <summary>
        /// 获取数据表中的特定值
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="valueA"></param>
        /// <returns></returns>
        public string getDataFromCell(string row, string table, string rowA, string valueA)
        {
            string mycell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        mycell = Convert.ToString(myReader[0]);
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
            return mycell;
        }


        public string[] getDataFromCells(string row, string table)
        {
            string [] myCells = null;
            List<string> myCellsList = new List<string>(); 
            string myCell = "";
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        myCell = Convert.ToString(myReader[0]);
                        myCellsList.Add(myCell);
                        myCells = myCellsList.ToArray();
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
            return myCells;
        }

        public string[] getDataFromCells(string row, string table, string rowA, string valueA)
        {
            string[] myCells = null;
            List<string> myCellsList = new List<string>();
            string myCell = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + valueA + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        myCell = Convert.ToString(myReader[0]);
                        myCellsList.Add(myCell);
                        myCells = myCellsList.ToArray();
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
            return myCells;
        }

        public bool checkCoverReviewTo()
        {
            bool falg = false;
            string selectFullName = "select email from 用户管理 where coverReviewTo='True'";
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
            string mySQL = "select email from 用户管理 where reviewFrom='True'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
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
            string mySQL = "select fullName from 用户管理 where userName=" + "'" + userName + "'" + "AND" + "[passWord]=" + "'" + passwd + "'";
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

        public bool checkAutoReviewTo()
        {
            bool falg = false;
            string selectFullName = "select email from 用户管理 where autoReviewTo='True'";
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


        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="sql"></param>
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

        /// <summary>
        /// 更新1个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="txtChangeTo"></param>
        public void UpdateDB(string table, string row, Control txtChangeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + txtChangeTo.Text + "'" + " where userName='" + UserLogin.pubUserName + "'");
        }

        /// <summary>
        /// 更新1个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="changeTo"></param>
        public void UpdateDB(string table, string row, string changeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + changeTo + "'");
        }

        /// <summary>
        /// 更新2个数据
        /// </summary>
        /// <param name="table"></param>
        /// <param name="row"></param>
        /// <param name="changeTo"></param>
        /// <param name="otherRow"></param>
        /// <param name="otherChangeTo"></param>
        public void UpdateDB(string table, string row, string changeTo,string otherRow,string otherChangeTo)
        {
            UpdateDB("update " + table + " set " + row + "='" + changeTo + "'" + " where " + otherRow + "='" + otherChangeTo + "'");
        }

        /// <summary>
        /// 用户判断值是否存在
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public bool checkItem(string row, string table, string dataItem)
        {
            bool falg = false;
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (dataItem == Convert.ToString(myReader[0]))
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

        /// <summary>
        /// 用以判断值是否存在
        /// </summary>
        /// <param name="row"></param>
        /// <param name="table"></param>
        /// <param name="rowA"></param>
        /// <param name="dataItem"></param>
        /// <returns></returns>
        public string checkItems(string row, string table, string rowA, string dataItem)
        {
            string item = "";
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + dataItem + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        item = Convert.ToString(myReader[0]);
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
            return item;
        }

        public bool checkItem(string row, string table, string rowA, string dataItem)
        {
            bool flag = false;
            string mySQL = "select " + row + " from " + table + " where " + rowA + "=" + "'" + dataItem + "'";
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    flag = true;
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
            return flag;
        }

        public bool checkItem(string row, string table, string valueA, string rowB, string valueB)
        {
            bool falg = false;
            string mySQL = "select " + row + " from " + table + " where " + rowB + "=" + "'" + valueB + "'";

            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(mySQL, mycon);
                myReader = mycom.ExecuteReader();
                if (myReader.HasRows == true)
                {
                    while (myReader.Read())
                    {
                        if (valueA == Convert.ToString(myReader[0]))
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
                if (myReader != null)
                {
                    myReader.Close();
                    mycon.Close();
                }
            }
            return falg;
        }

        public bool selectItems(ComboBox comBox, string table)
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
                    listItem = new ListItem(row["email"].ToString(), row["fullName"].ToString() + "(" + row["email"].ToString() + ")");
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

        public int countNum(string row, string table)
        {
            int count = 0;
            string mySQL = "select " + row + " from " + table;
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(mySQL, mycon);
                DataTable mydt = new DataTable();
                myda.Fill(mydt);
                foreach (DataRow r in mydt.Rows)
                {
                    count = count + 1;
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
            return count;
        }



        /// <summary>
        /// 检查用户名称是否存在
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
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

        public bool clearList(ComboBox comBox,string table)
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
            try
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
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet getDataSet(string sql)
        {
            DataSet myDataSet = new DataSet();
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlDataAdapter myda = new SqlDataAdapter(sql, mycon);
                myda.Fill(myDataSet);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "异常消息提示：", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                mycon.Close();
            }
            return myDataSet;
        }

        public SqlDataReader getDataReader(string sql)
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(sql, mycon);
                myReader = mycom.ExecuteReader();
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
            return myReader;
        }


        public void saveXML(string sql)
        {
            try
            {
                mycon = new SqlConnection(strcon);
                mycon.Open();
                SqlCommand mycom = new SqlCommand(sql, mycon);
                myReader = mycom.ExecuteReader();
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
        }
    }
}
