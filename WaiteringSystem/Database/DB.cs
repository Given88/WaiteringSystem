using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WaiteringSystem.Database
{
    public class DB
    {
        string strConn = @"Settings.Default. EmployeeDatabaseConnectionStringb";
        SqlConnection cnMain;
        DataSet dsMain;
        SqlDataAdapter daMain;

        public DB()
        {
            try
            {
                cnMain = new SqlConnection(strConn);
                cnMain.Open();
                dsMain = new DataSet();
                cnMain.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillDataSet(string aSQLstring, string aTable)
        {
            try
            {
                daMain = new SqlDataAdapter(aSQLstring, cnMain);
                cnMain.Open();
                dsMain.Clear();
                daMain.Fill(dsMain, aTable);
                cnMain.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+ "  "+ex.StackTrace);
            }
        }
        public bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success = false;
            try
            {
                cnMain.Open();
                daMain.Update(dsMain, table);
                cnMain.Close();
                daMain = new SqlDataAdapter(sqlLocal, cnMain);
                daMain.Fill(dsMain, table);
                success = true;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message+"  "+e.StackTrace);
            }
            return success;
        }
    }
}
