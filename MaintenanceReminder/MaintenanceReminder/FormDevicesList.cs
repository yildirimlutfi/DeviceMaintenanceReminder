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

        private void FormDevicesList_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Column1", "Eklenme Tarihi");
            dataGridView1.Columns.Add("Column2", "Eklenme Saati");
            dataGridView1.Columns.Add("Column3", "Cihaz Kodu");
            dataGridView1.Columns.Add("Column4", "Cihaz Adı");
            dataGridView1.Columns.Add("Column5", "Kullanım Amacı");
            dataGridView1.Columns.Add("Column6", "Bina Kodu");
            dataGridView1.Columns.Add("Column7", "Cihaz Künyesi");
            dataGridView1.Columns.Add("Column8", "Kalibrasyon Tarihi");
            dataGridView1.Columns.Add("Column9", "Kalibrasyon Periyodu");
            dataGridView1.Columns.Add("Column10", "Kalibrasyon Zamanı");
            dataGridView1.Columns.Add("Column11", "Kalibrasyon Notu");

            for (int i = 0; i < ClassGv.CalibrationHistoryList.Date.Count; i++)
            {
                dataGridView1.Rows.Add(ClassGv.CalibrationHistoryList.Date[i],
                    ClassGv.CalibrationHistoryList.Time[i],
                    ClassGv.CalibrationHistoryList.DeviceCode[i],
                    ClassGv.CalibrationHistoryList.DeviceName[i],
                    ClassGv.CalibrationHistoryList.PurposeOfUsage[i],
                    ClassGv.CalibrationHistoryList.StructureCode[i],
                    ClassGv.CalibrationHistoryList.DeviceTag[i],
                    ClassGv.CalibrationHistoryList.CalibrationDate[i],
                    ClassGv.CalibrationHistoryList.CalibrationPeriod[i],
                    ClassGv.CalibrationHistoryList.NextCalibrationDate[i],
                    ClassGv.CalibrationHistoryList.CalibrationNote[i]);
            }
        }
    }
}
