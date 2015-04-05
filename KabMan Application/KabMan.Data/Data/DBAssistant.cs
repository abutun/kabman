using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace KabMan.Data
{
    public static class DBAssistant
    {

        // connection to data source
        private static SqlConnection connection;
        

        
        public static DataSet ExecProcedure(string argProcedureName)
        {
            return ExecProcedure(argProcedureName, null);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argProcedureName">Name of the procedure</param>
        /// <param name="argParams">Parameter Name/Value array</param>
        /// <returns></returns>
        public static DataSet ExecProcedure(string argProcedureName, object[] argParameters)
        {           
            // New DataSet for return table from procedure
            DataSet retValue = new DataSet();
            if (!string.IsNullOrEmpty(Settings.ConnectionString))
            {
                // Parameter array for procedure
                List<SqlParameter> parameters = new List<SqlParameter>();
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SqlCommand command;
                    if (argParameters != null)
                    {
                        parameters = CreateParameters(argParameters);
                        command = CreateCommand(argProcedureName, parameters.ToArray());
                    }
                    else
                    {
                        command = CreateCommand(argProcedureName, parameters.ToArray());
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);                    
                    adapter.Fill(retValue);

                    Cursor.Current = Cursors.Default;
                }
                catch (System.Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show(ex.Message, "KabMan.Data.DBAssistant.ExecProcedure(); " + argProcedureName + " - " + argParameters, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                    Close();
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                XtraMessageBox.Show("Connection String is not defined!", "KabMan.Data.DBAssistant.ExecProcedure()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return retValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="argProcedureName">Name of the procedure</param>
        /// <param name="argParams">Parameter Name/Value array</param>
        /// <returns></returns>
        public static int ExecProcedureAndGetReturnValue(string argProcedureName, object[] argParameters)
        {
            // New DataSet for return table from procedure
            DataSet retValue = new DataSet();

            int returnValAsInt = -1001;

            if (!string.IsNullOrEmpty(Settings.ConnectionString))
            {
                // Parameter array for procedure
                List<SqlParameter> parameters = new List<SqlParameter>();
                try
                {
                    Cursor.Current = Cursors.WaitCursor;

                    SqlCommand command;
                    if (argParameters != null)
                    {
                        parameters = CreateParameters(argParameters);
                        command = CreateCommand(argProcedureName, parameters.ToArray());
                    }
                    else
                    {
                        command = CreateCommand(argProcedureName, parameters.ToArray());
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(retValue);

                    returnValAsInt = (int)command.Parameters["@ReturnValue"].Value;

                    Cursor.Current = Cursors.Default;
                }
                catch (System.Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show(ex.Message, "KabMan.Data.DBAssistant.ExecProcedure(); " + argProcedureName + " - " + argParameters, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                    Close();
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                XtraMessageBox.Show("Connection String is not defined!", "KabMan.Data.DBAssistant.ExecProcedure()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return returnValAsInt;
        }

        public static DataSet RunQuery(string argQuery)
        {

            // New DataSet for return table from procedure
            DataSet retValue = new DataSet();
            if (!string.IsNullOrEmpty(Settings.ConnectionString))
            {
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    SqlCommand command = CreateCommand(argQuery);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);

                    adapter.Fill(retValue);
                    Cursor.Current = Cursors.Default;
                }
                catch (System.Exception ex)
                {
                    Cursor.Current = Cursors.Default;
                    XtraMessageBox.Show(ex.Message, "KabMan.Data.DBAssistant.RunQuery()", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                    Close();
                }
            }
            else
            {
                Cursor.Current = Cursors.Default;
                XtraMessageBox.Show("Connection String is not defined!", "KabMan.Data.DBAssistant.RunQuery()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return retValue;
        }
        public static int Update(string Sql, object[] SqlParams, object[] SqlValues)
        {
            Cursor.Current = Cursors.WaitCursor;

            SqlCommand command = new SqlCommand(Sql, connection);
            connection.Close();
            connection.Open();
            for (int i = 0; i < SqlParams.Length; i++)
            {
                command.Parameters.AddWithValue(SqlParams[i].ToString(), SqlValues[i]);
            }
            int result = command.ExecuteNonQuery();
            connection.Close();

            Cursor.Current = Cursors.Default;
            return result;
        }
        /// <summary>
        /// Converts NameValue Array to SqlParameter List
        /// </summary>
        /// <param name="argParameters">ParameterName/ParameterValue Pairs</param>
        /// <returns>SqlParameter List</returns>
        public static List<SqlParameter> CreateParameters(object[] argParameters)
        {
            List<SqlParameter> retValue = new List<SqlParameter>();
            // Converts object array values to SqlParameter array
            for (int i = 0; i < argParameters.Length / 2; i++)
            {
                int index = i * 2;

                string direction = argParameters[index].ToString().Split('@')[0];
                argParameters[index] = argParameters[index].ToString().Replace(direction + "@", "@");
                SqlParameter param = new SqlParameter(argParameters[index].ToString(), argParameters[index + 1]);
                param.Direction = direction == "out" ? ParameterDirection.Output : ParameterDirection.Input;
                retValue.Add(param);
            }
            return retValue;
        }

        /// <summary>
        /// Open the connection.
        /// </summary>
        /// <remarks>DatabaseLib</remarks>
        private static void Open()
        {
            try
            {
                // open connection
                if (connection == null)
                {
                    connection = new SqlConnection(Settings.ConnectionString);
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message, "KabMan.Data.DBAssistant.Open()", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="procName"></param>
        /// <param name="prams"></param>
        /// <returns></returns>
        /// <remarks>DatabaseLib</remarks>
        private static SqlCommand CreateCommand(string argProcedureName, SqlParameter[] argParameters)
        {
            // make sure connection is open
            Open();

            SqlCommand command = new SqlCommand(argProcedureName, connection);

            command.CommandType = CommandType.StoredProcedure;
            if (argParameters != null)
            {
                command.Parameters.AddRange(argParameters);
            }

            command.Parameters.Add(
                new SqlParameter("@ReturnValue", SqlDbType.Int, 4,
                                 ParameterDirection.ReturnValue, false, 0, 0,
                                 string.Empty, DataRowVersion.Default, null));
            return command;

        }

        /// <remarks>DatabaseLib</remarks>
        private static SqlCommand CreateCommand(string argQuery)
        {
            // make sure connection is open
            Open();

            SqlCommand command = new SqlCommand(argQuery, connection);
            command.CommandType = CommandType.Text;

            return command;
        }


        /// <summary>
        /// Close the connection.
        /// </summary>
        /// <remarks>DatabaseLib</remarks>
        private static void Close()
        {
            if (connection != null)
                connection.Close();
        }


    }
}
