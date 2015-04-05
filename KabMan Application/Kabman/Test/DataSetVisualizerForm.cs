using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using KabMan.Import;
using System.Collections;
using DevExpress.XtraPrinting;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace KabMan.Test
{
    public partial class DataSetVisualizerForm : DevExpress.XtraEditors.XtraForm
    {
        public DataSetVisualizerForm()
        {
            InitializeComponent();
        }

        private Dictionary<string, IEnumerable> _DataSet = new Dictionary<string, IEnumerable>();
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<string, IEnumerable> DataSet
        {
            get
            {
                return _DataSet;
            }
            set
            {
                _DataSet = value;
            }
        }

        public void AddDataTable(string argKey, IEnumerable argTable)
        {
            this.DataSet.Add(argKey, argTable);
            visualizerList.Properties.Items.Clear();
            visualizerList.Properties.Items.AddRange(this.DataSet.Keys);
        }

        private void visualizerList_SelectedIndexChanged(object sender, EventArgs e)
        {
            visualizerView.Columns.Clear();
            visualizerGrid.DataSource = DataSet[visualizerList.SelectedItem.ToString()];
            barStaticItem1.Caption = visualizerView.RowCount.ToString();
        }
    }
}