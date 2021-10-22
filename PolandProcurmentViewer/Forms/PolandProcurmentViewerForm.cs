using PP.Connection;
using PP.Connection.JsonDataClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PP.Viewer
{
    public partial class PPViewerForm : Form
    {
        private PPConnection _ppConnection { get; set; }

        public PPViewerForm()
        {
            _ppConnection = new PPConnection();

            InitializeComponent();
        }

        private void GetDataBtn_Click(object sender, EventArgs e)
        {
            FillData(_ppConnection.DeserializeJson<Tenders>(_ppConnection.Get("")));
        }

        private void FillData(Tenders tendersData)
        {
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = tendersData.Tender;
            TenderGridViewer.DataSource = bindingSource;
            TenderGridViewer.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            TenderGridViewer.AutoGenerateColumns = true;
        }

    }
}
