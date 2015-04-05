using System;
using System.Data;
using System.Data.SqlClient;
using DevExpress.XtraEditors;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Utils
{
    /// <summary>
    /// ADO.NET data access using the SQL Server Managed Provider.
    /// </summary>
    public class DatabaseLib : IDisposable
    {

        

        /// <summary>
        /// Run Sql query.
        /// </summary>
        /// <returns>Execute Non Query</returns>
        public void RunSqlQuery(string queryString, out SqlDataReader dataReader)
        {
            SqlCommand cmd = CreateCommand(queryString);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }


        /*        public void RunSearch()
                {
                    SqlDataAdapter Adap3 = new SqlDataAdapter("Select * from" + TableName + "where" + SearchFieldStrings + "ServerName like '" + textEdit1.Text + "%' or Standort like ' " + textEdit1.Text + "%'", ConnString);
                    Adap3.SelectCommand.CommandType = CommandType.Text;
                    DataSet ds3 = new DataSet();
                    Adap3.Fill(ds3);
                    gridControl1.DataSource = ds3.Tables[0]; 
                }*/

        public void RunSqlQuery(string queryString, out DataSet dataSet)
        {
            SqlCommand cmd = CreateCommand(queryString);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dataSet = new DataSet();
            dap.Fill(dataSet);
        }

        public void RunSqlQuery(string queryString)
        {
            SqlCommand cmd = CreateCommand(queryString);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <returns>Stored procedure return value.</returns>
        /*  public int RunProc(string procName)
        {
            SqlCommand cmd = CreateCommand(procName, null);
            cmd.ExecuteNonQuery();
            Close();
            return (int) cmd.Parameters["@ReturnValue"].Value;
        } */
        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <returns>Stored procedure return value.</returns>
        public int RunProc(string procName, SqlParameter[] prams)
        {
            SqlCommand cmd = CreateCommand(procName, prams);
            cmd.ExecuteNonQuery();
            Close();
            return (int)cmd.Parameters["@ReturnValue"].Value;
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="dataSet">Return result of procedure.</param>
        public void RunProc(string procName, out DataSet dataSet)
        {
            SqlCommand cmd = CreateCommand(procName, null);
            //dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dataSet = new DataSet();
            dap.Fill(dataSet);
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="dataSet">Return result of procedure.</param>
        public void RunProc(string procName, SqlParameter[] prams, out DataSet dataSet)
        {
            SqlCommand cmd = CreateCommand(procName, prams);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);

            dataSet = new DataSet();
            dap.Fill(dataSet);
        }

        public void RunProc(string procName, SqlParameter[] prams, DataSet dataSet)
        {
            SqlCommand cmd = CreateCommand(procName, prams);
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dataSet);
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string procName, out SqlDataReader dataReader)
        {
            SqlCommand cmd = CreateCommand(procName, null);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Run stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Stored procedure params.</param>
        /// <param name="dataReader">Return result of procedure.</param>
        public void RunProc(string procName, SqlParameter[] prams, out SqlDataReader dataReader)
        {
            SqlCommand cmd = CreateCommand(procName, prams);
            dataReader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }

        /// <summary>
        /// Create command object used to call stored procedure.
        /// </summary>
        /// <param name="procName">Name of stored procedure.</param>
        /// <param name="prams">Params to stored procedure.</param>
        /// <returns>Command object.</returns>
        /// 







        

        /// <summary>
        /// Make input param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Value">Param value.</param>
        /// <returns>New parameter.</returns>
        public SqlParameter MakeInParam(string ParamName, SqlDbType DbType, object Value)
        {
            if (Value == null)
            {
                Value = DBNull.Value;
                return MakeParam(ParamName, DbType, ParameterDirection.Input, Value);
            }
            else
                return MakeParam(ParamName, DbType, ParameterDirection.Input, Value);
        }

        public SqlParameter MakeInParam(string ParamName, object Value)
        {
            if (Value == null)
            {
                Value = DBNull.Value;
                return MakeParam(ParamName, ParameterDirection.Input, Value);
            }
            else
                return MakeParam(ParamName, ParameterDirection.Input, Value);
        }

        /// <summary>
        /// Make input param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Size">Param size.</param>
        /// <returns>New parameter.</returns>
        public SqlParameter MakeOutParam(string ParamName, SqlDbType DbType, int Size)
        {
            return MakeParam(ParamName, DbType, ParameterDirection.Output, null);
        }

        /// <summary>
        /// Make stored procedure param.
        /// </summary>
        /// <param name="ParamName">Name of param.</param>
        /// <param name="DbType">Param type.</param>
        /// <param name="Direction">Param direction.</param>
        /// <param name="Value">Param value.</param>
        /// <returns>New parameter.</returns>
        public SqlParameter MakeParam(string ParamName, SqlDbType DbType, ParameterDirection Direction, object Value)
        {
            SqlParameter param;

            //if(Size > 0)
            //    param = new SqlParameter(ParamName, DbType, Size);
            //else
            param = new SqlParameter(ParamName, DbType);

            param.Direction = Direction;
            if (!(Direction == ParameterDirection.Output && Value == null))
                param.Value = Value;

            return param;
        }

        public SqlParameter MakeParam(string ParamName, ParameterDirection Direction, object Value)
        {
            SqlParameter param;

            //if(Size > 0)
            //    param = new SqlParameter(ParamName, DbType, Size);
            //else			
            param = new SqlParameter(ParamName, Value);

            param.Direction = Direction;
            if (!(Direction == ParameterDirection.Output && Value == null))
                param.Value = Value;

            return param;
        }
    }
}