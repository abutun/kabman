using System.Data;
using System.Data.OleDb;

namespace KabMan.Import
{

    public class ExcelConnector
    {

        #region Constructors

        public ExcelConnector()
        {

        }

        public ExcelConnector(string argFilePath)
        {
            this.FilePath = argFilePath;
        }

        #endregion

        #region Fields
        private string ExcelConnectionStringTemplate = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source={0}; Extended Properties=Excel 8.0;";
        private string SelectPageQueryTemplate = "SELECT * FROM [{0}]";
        private OleDbConnection excelConnection;

        #endregion

        #region Properties

        public string FilePath { get; set; }

        #endregion

        #region Methods

        private void CreateConnection()
        {
            if (!System.IO.File.Exists(this.FilePath))
            {
                throw new System.IO.FileNotFoundException("Excel file not found!", this.FilePath);
            }

            if (excelConnection != null)
            {
                CloseConnection();
            }

            if (excelConnection == null)
            {
                excelConnection = new OleDbConnection(string.Format(this.ExcelConnectionStringTemplate, this.FilePath));
            }

        }

        private void OpenConnection()
        {

            CreateConnection();
            excelConnection.Open();

        }

        private void CloseConnection()
        {
            if (excelConnection != null)
            {
                excelConnection.Close();
                excelConnection = null;
            }
        }

        public DataTable GetWorksheets()
        {
            OpenConnection();
            return excelConnection.GetSchema("Tables");
        }

        public DataTable GetDataPage(object argPageName)
        {
            DataTable retValue = new DataTable();

            CreateConnection();

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(string.Format(SelectPageQueryTemplate, argPageName.ToString()), excelConnection);

            dataAdapter.Fill(retValue);

            return retValue;
        }

        #endregion

    }
}
