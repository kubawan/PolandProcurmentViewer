using PP.Connection;
using PP.Data.Models;
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
            FillData(_ppConnection.DeserializeJson<Tenders>(_ppConnection.Get("", RequestType.ListTenders)));
        }

        private void FillData(Tenders tendersData)
        {
            foreach (Tender tender in tendersData.TendersList)
            {
                TendersListBox.Items.Add(tender);
                TendersListBox.DisplayMember = "Id";
            }
        }

        private void TendersListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var tender = TendersListBox.SelectedItem as Tender;

            tender = _ppConnection.DeserializeJson<Tender>(_ppConnection.Get($"{tender.Id}", RequestType.TenderDetails));

            lblTenderIdData.Text = tender.Id;
            lblTenderTitleData.Text = tender.Title;
        }

    }
}
