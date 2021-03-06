using System;
using System.Data;
using System.Windows.Forms;
using KabMan.Import;
using KabMan.Test;
using KabMan.Windows;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using KabMan.Extensions;
using KabMan.Controls;
using userSettings = KabMan.Properties.Settings;

namespace KabMan.Forms
{

    public partial class ExcelImportForm : DevExpress.XtraEditors.XtraForm
    {

        #region Fields

        private DataSet switchDataSet = new DataSet();
        private DataSet serverDataSet = new DataSet();
        private DataSet dasdDataSet = new DataSet();
        private DataSet dccDataSet = new DataSet();

        private List<LocationListItem> listLocation = new List<LocationListItem>();
        private List<DataCenterListItem> listDataCenter = new List<DataCenterListItem>();

        private List<DataCenterListItem> listDataCenter1 = new List<DataCenterListItem>();
        private List<DataCenterListItem> listDataCenter2 = new List<DataCenterListItem>();

        private List<CoordinateListItem> listCoordinate = new List<CoordinateListItem>();
        private List<SwitchModelListItem> listSwitchModel = new List<SwitchModelListItem>();
        private List<SwitchListItem> listSwitchAll = new List<SwitchListItem>();
        private List<SwitchGroupedListItem> listSwitchGrouped = new List<SwitchGroupedListItem>();
        private List<TrunkListItem> listTrunkGrouped = new List<TrunkListItem>();
        private List<JumperListItem> listLcUrmJumperGrouped = new List<JumperListItem>();
        private List<JumperListItem> listUrmUrmJumperGrouped = new List<JumperListItem>();
        private List<BlechListItem> listBlechAll = new List<BlechListItem>();
        private List<BlechGroupedListItem> listBlechGrouped = new List<BlechGroupedListItem>();
        private List<VtPortGroupedListItem> listVtPortGrouped = new List<VtPortGroupedListItem>();
        private List<VtPortGroupedListItem> listVtPort1Grouped = new List<VtPortGroupedListItem>();
        private List<VtPortGroupedListItem> listVtPort2Grouped = new List<VtPortGroupedListItem>();
        private List<OSListItem> listOS = new List<OSListItem>();
        private List<ServerListItem> listServerAll = new List<ServerListItem>();
        private List<ServerGroupedListItem> listServerGrouped = new List<ServerGroupedListItem>();
        private List<DasdListItem> listDasdAll = new List<DasdListItem>();
        private List<DasdGroupedListItem> listDasdGrouped = new List<DasdGroupedListItem>();

        private List<DccListItem> listDccAll = new List<DccListItem>();
        private List<DccGroupedListItem> listDccGrouped = new List<DccGroupedListItem>();
        #endregion

        #region Constructor

        public ExcelImportForm()
        {
            InitializeComponent();
            InitializeManager();
        }

        #endregion

        private void ExcelImportForm_Load(object sender, EventArgs e)
        {
            //WindowAssistant.RunNewForm(typeof(SwitchImportTest));
            ReCreateErrorTable();
            //WindowAssistant.RunNewForm(typeof(DataSetVisualizerForm));
        }

        // ImportFilesValidating
        private void CImportFilesPath_ButtonPressed(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (Equals(e.Button.Tag, "Open"))
            {
                DateTime startTime = DateTime.Now;
                CFolderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                 var folderResult = CFolderBrowserDialog.ShowDialog();
                if (folderResult == DialogResult.OK)
                {
                    ReCreateErrorTable();
                    Stopwatch watcher = Stopwatch.StartNew();

                    CImportFilesPath.Text = CFolderBrowserDialog.SelectedPath;
                    importValidator = new ImportFilesPathValidator(CImportFilesPath.Text);

                    if (importValidator.ContainsAllFiles)
                    {
                        //progressBarControl1
                        progressBarControl1.Properties.Minimum = 0;
                        progressBarControl1.Properties.Maximum = 210;
                        progressBarControl1.Properties.Step = 10;
                        //progressBarControl1

                        FillWithWorksheets();
                        MakeProgress(10);

                        ProcessTrunks();
                        MakeProgress(10);

                        ProcessJumpers("LcUrm");
                        MakeProgress(10);

                        ProcessJumpers("UrmUrm");
                        MakeProgress(10);

                        ProcessOSs();//!
                        MakeProgress(10);

                        ProcessSwitchModels();
                        MakeProgress(10);

                        ProcessDasdModels();
                        MakeProgress(10);

                        ProcessLocations();
                        MakeProgress(10);

                        ProcessDataCenters("VtPort");
                        MakeProgress(10);

                        ProcessDataCenters("VtPort1");
                        MakeProgress(10);

                        ProcessDataCenters("VtPort2");
                        MakeProgress(10);

                        ProcessCoordinates();
                        MakeProgress(10);

                        ProcessVtPorts("VtPort");
                        MakeProgress(10);

                        ProcessVtPorts("VtPort1");
                        MakeProgress(10);

                        ProcessVtPorts("VtPort2");
                        MakeProgress(10);

                        ProcessBleches();
                        MakeProgress(10);

                        ProcessSwitches();
                        MakeProgress(10);

                        ProcessServers();
                        MakeProgress(10);

                        ProcessDasds();
                        MakeProgress(10);

                        ProcessDCCs();
                        MakeProgress(10);
                        
                        ValidatePageColumns();
                        MakeProgress(10);
                    }
                    else
                    {
                        this.AddImportPathError();
                    }

                    CErrorListGrid.DataSource = errorDataTable;

                    FilterErrorList();

                    CErrorListView.BestFitColumns();

                    if (errorDataTable.Rows.Count > 0)
                    {
                        CErrorListDockPanel.Show();
                    }

                    watcher.Stop();

                    this.progressBarControl1.Position = 0;

                    Debug.WriteLine(string.Format("Process took {0}", watcher.Elapsed));
                }
            }
        }

        private void MakeProgress(int value)
        {
            progressBarControl1.Position += value;
            progressBarControl1.Refresh();
        }

        private void itemClose_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        #region Page Selection

        private void CSwitchExcelPages_EditValueChanged(object sender, EventArgs e)
        {
            CSwitchView.Columns.Clear();
            CSwitchGrid.DataSource = switchDataSet.Tables[CSwitchExcelPages.EditValue.ToString()];
            CSwitchView.BestFitColumns();
        }

        private void CRackExcelPages_EditValueChanged(object sender, EventArgs e)
        {
            CRackView.Columns.Clear();
            CRackGrid.DataSource = serverDataSet.Tables[CRackExcelPages.EditValue.ToString()];
            CRackView.BestFitColumns();
        }

        private void CDasdExcelPages_EditValueChanged(object sender, EventArgs e)
        {
            CDasdView.Columns.Clear();
            CDasdGrid.DataSource = dasdDataSet.Tables[CDasdExcelPages.EditValue.ToString()];
            CDasdView.BestFitColumns();
        }

        private void CDCCExcelPages_EditValueChanged(object sender, EventArgs e)
        {
            CDCCView.Columns.Clear();
            CDCCGrid.DataSource = dccDataSet.Tables[CDCCExcelPages.EditValue.ToString()];
            CDCCView.BestFitColumns();
        }

        #endregion

        private void itemImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            if (errorDataTable.Select("ErrorType = 'Error'").Length > 0)
            {
                CErrorListDockPanel.Show();
            }
            else
            {
                ImportToDB();
            }
        }

        void CSwitchView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            int index = e.FocusedRowHandle;
            SwitchImportComponent swi = new SwitchImportComponent();

            try
            {
                swi.Switch.Name = GetValue(index, "Name");
                swi.Switch.Model = GetValue(index, "Model");

                DataTable tmpTable = (DataTable)CSwitchGrid.DataSource;
                swi.Switch.PortCount = Convert.ToInt32(tmpTable.Compute("COUNT(No)", "No IS NOT NULL").ToString());

                swi.LcUrmCable.Parse(GetValue(index, "URM LC"));

                swi.Blech.Parse(GetValue(index, "BLECH"));

                swi.TrunkCable.Parse(GetValue(index, "TRUNK"));

                swi.VtPort.Parse(GetValue(index, "VT PORT"));

                swi.UrmUrmCable.Parse(GetValue(index, "URM URM"));
            }
            catch
            {
                swi = new SwitchImportComponent();
            }

            RefreshAssistant.RefreshSwitchImportTest(swi);
        }

        private string GetValue(int argIndex, string argColumn)
        {
            return CSwitchView.GetRowCellValue(argIndex, argColumn).ToString();
        }

        private void CTabControl_Click(object sender, EventArgs e)
        {

        }

        private void CImportFilesPath_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}