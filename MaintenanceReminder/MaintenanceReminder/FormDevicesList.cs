using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceReminder
{
    public partial class FormDevicesList : Form
    {
        public FormDevicesList()
        {
            InitializeComponent();
        }

        DataTable dataTable = new DataTable();
        private void dgvUpdate()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.AutoSize = true;

            dataTable.Columns.Clear();
            dataTable.Rows.Clear();

            dataTable.Columns.Add("Eklenme Tarihi");
            dataTable.Columns.Add("Eklenme Saati");
            dataTable.Columns.Add("Cihaz Kodu");
            dataTable.Columns.Add("Cihaz Adı");
            dataTable.Columns.Add("Kullanım Amacı");
            dataTable.Columns.Add("Bina Kodu");
            dataTable.Columns.Add("Cihaz Künyesi");
            dataTable.Columns.Add("Kalibrasyon Tarihi");
            dataTable.Columns.Add("Kalibrasyon Periyodu");
            dataTable.Columns.Add("Kalibrasyon Zamanı");
            dataTable.Columns.Add("Kalibrasyon Şirketi");
            dataTable.Columns.Add("Sertifika Numarası");
            dataTable.Columns.Add("Kalibrasyon Notu");
            for (int i = 0; i < ClassGv.CalibrationHistoryList.Date.Count; i++)
            {
                dataTable.Rows.Add(
                    ClassGv.CalibrationHistoryList.Date[i],
                    ClassGv.CalibrationHistoryList.Time[i],
                    ClassGv.CalibrationHistoryList.DeviceCode[i],
                    ClassGv.CalibrationHistoryList.DeviceName[i],
                    ClassGv.CalibrationHistoryList.PurposeOfUsage[i],
                    ClassGv.CalibrationHistoryList.StructureCode[i],
                    ClassGv.CalibrationHistoryList.DeviceTag[i],
                    ClassGv.CalibrationHistoryList.CalibrationDate[i],
                    ClassGv.CalibrationHistoryList.CalibrationPeriod[i],
                    ClassGv.CalibrationHistoryList.NextCalibrationDate[i],
                    ClassGv.CalibrationHistoryList.CalibrationCompany[i],
                    ClassGv.CalibrationHistoryList.NumberOfCertificate[i],
                    ClassGv.CalibrationHistoryList.CalibrationNote[i]
                    );
            }
            dataGridView1.DataSource = dataTable;
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[1].Visible = false;
            dataGridView1.Columns[12].AutoSizeMode=DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FormDevicesList_Load(object sender, EventArgs e)
        {
            dgvUpdate();
        }

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.RowFilter = dataGridView1.FilterString;
        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            dataTable.DefaultView.Sort = dataGridView1.SortString;
        }
    }
}
