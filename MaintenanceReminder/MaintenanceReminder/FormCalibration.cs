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
    public partial class FormCalibration : Form
    {
        public FormCalibration()
        {
            InitializeComponent();
        }

        private void dgvUpdate()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Column1", "Eklenme Tarihi");
            //dataGridView1.Columns.Add("Column2", "Eklenme Saati");
            dataGridView1.Columns.Add("Column3","Cihaz Kodu");
            dataGridView1.Columns.Add("Column4","Cihaz Adı");
            //dataGridView1.Columns.Add("Column5","Kullanım Amacı");
            dataGridView1.Columns.Add("Column6","Bina Kodu");
            //dataGridView1.Columns.Add("Column7","Cihaz Künyesi");
            dataGridView1.Columns.Add("Column8","Kalibrasyon Tarihi");
            dataGridView1.Columns.Add("Column9","Kalibrasyon Periyodu");
            dataGridView1.Columns.Add("Column10","Kalibrasyon Zamanı");
            dataGridView1.Columns.Add("Column11","Kalibrasyon Notu");

            for (int i = 0; i < ClassGv.ActiveCalibrationList.Date.Count; i++)
            {
                dataGridView1.Rows.Add(
                    ClassGv.ActiveCalibrationList.Date[i],
                    //ClassGv.ActiveCalibrationList.Time[i],
                    ClassGv.ActiveCalibrationList.DeviceCode[i],
                    ClassGv.ActiveCalibrationList.DeviceName[i],
                    //ClassGv.ActiveCalibrationList.PurposeOfUsage[i],
                    ClassGv.ActiveCalibrationList.StructureCode[i],
                    //ClassGv.ActiveCalibrationList.DeviceTag[i],
                    ClassGv.ActiveCalibrationList.CalibrationDate[i],
                    ClassGv.ActiveCalibrationList.CalibrationPeriod[i],
                    ClassGv.ActiveCalibrationList.NextCalibrationDate[i],
                    ClassGv.ActiveCalibrationList.CalibrationNote[i]
                    );
            }

            foreach (DataGridViewRow item in dataGridView1.Rows)
            {
                TimeSpan timeSpan = Convert.ToDateTime(Convert.ToDateTime(item.Cells[6].Value)) - DateTime.Now.Date;
                TimeSpan remainingTime = new TimeSpan(ClassGv.MailAlertRemainingTime, 0, 0, 0, 0);
                if (timeSpan < TimeSpan.Zero)
                {
                    item.DefaultCellStyle.BackColor = Color.Red;
                }
                else if (timeSpan < remainingTime)
                {
                    item.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                }
            }
        }
        private void AddDataToComboBox()
        {
            cbDeviceCode.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                cbDeviceCode.Items.Add(ClassGv.DeviceList.DeviceCode[i]);
            }

            cbDeviceName.Items.Clear();
            for (int i = 0; i < ClassGv.DeviceList.DeviceName.Count; i++)
            {
                cbDeviceName.Items.Add(ClassGv.DeviceList.DeviceName[i]);
            }
        }

        private void FormCalibration_Load(object sender, EventArgs e)
        {
            AddDataToComboBox();
            dgvUpdate();
        }

        private void cbDeviceCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combo = (ComboBox)sender;
            tbPurposeOfUsage.Text = "";
            tbStructureCode.Text = "";
            tbDeviceTag.Text = "";

            if (ClassGv.ActiveCalibrationList.DeviceCode.Count>0)
            {
                for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
                {
                    if (combo.Name == "cbDeviceCode" && cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                    {
                        //cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                        cbDeviceName.Text = ClassGv.ActiveCalibrationList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.ActiveCalibrationList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.ActiveCalibrationList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.ActiveCalibrationList.DeviceTag[i];
                        dtpCalibrationDate.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.CalibrationDate[i]).ToString();
                        nupCalibrationPeriod.Value = Convert.ToInt16(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                        //dtpNextCalibrationTime.Text = Convert.ToDateTime( ClassGv.CalibrationList.NextCalibrationDate[i]).ToString();
                        tbCalibrationNote.Text = ClassGv.ActiveCalibrationList.CalibrationNote[i];
                        break;
                    }
                    else if (combo.Name == "cbDeviceName" && cbDeviceName.Text == ClassGv.DeviceList.DeviceName[i])
                    {
                        cbDeviceCode.Text = ClassGv.ActiveCalibrationList.DeviceCode[i];
                        //cbDeviceName.Text = ClassGv.ActiveCalibrationList.DeviceName[i];
                        tbPurposeOfUsage.Text = ClassGv.ActiveCalibrationList.PurposeOfUsage[i];
                        tbStructureCode.Text = ClassGv.ActiveCalibrationList.StructureCode[i];
                        tbDeviceTag.Text = ClassGv.ActiveCalibrationList.DeviceTag[i];
                        dtpCalibrationDate.Text = Convert.ToDateTime(ClassGv.ActiveCalibrationList.CalibrationDate[i]).ToString();
                        nupCalibrationPeriod.Value = Convert.ToInt16(ClassGv.ActiveCalibrationList.CalibrationPeriod[i]);
                        //dtpNextCalibrationTime.Text = Convert.ToDateTime( ClassGv.CalibrationList.NextCalibrationDate[i]).ToString();
                        tbCalibrationNote.Text = ClassGv.ActiveCalibrationList.CalibrationNote[i];
                        break;
                    }
                    else//if written new device code clear all text box (action required)
                    {
                        tbPurposeOfUsage.Text = "";
                        tbStructureCode.Text = "";
                        tbDeviceTag.Text = "";
                    }
                }
            }           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbDeviceCode.Text.Contains(";") ||
                  cbDeviceName.Text.Contains(";") ||
                  tbPurposeOfUsage.Text.Contains(";") ||
                  tbStructureCode.Text.Contains(";") ||
                  tbDeviceTag.Text.Contains(";") ||
                  dtpCalibrationDate.Text.Contains(";") ||
                  dtpNextCalibrationTime.Text.Contains(";")||
                  tbCalibrationNote.Text.Contains(";"))
            {
                MessageBox.Show("Noktalı virgül içeren yazı yaılamaz ( ; )");
                return;
            }

            if (nupCalibrationPeriod.Value == 0 ||
              tbCalibrationNote.Text.Length == 0)
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır.\nKalibrasyon periyodu 0 olamaz.");
            }
            else
            {
                bool ThereIsCalibration = false;
                string temp = "";
                for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
                {
                    if (ClassGv.ActiveCalibrationList.DeviceCode[i]==cbDeviceCode.Text)
                    {
                        ThereIsCalibration = true;
                    }
                }

                if (ThereIsCalibration)
                {
                    for (int i = 0; i < ClassGv.ActiveCalibrationList.DeviceCode.Count; i++)
                    {
                        if (ClassGv.ActiveCalibrationList.DeviceCode[i]==cbDeviceCode.Text)
                        {
                            ClassGv.ActiveCalibrationList.Date[i] = DateTime.Now.ToString("dd/MM/yyyy");
                            ClassGv.ActiveCalibrationList.Time[i] = DateTime.Now.ToString("HH:mm:ss");
                            ClassGv.ActiveCalibrationList.DeviceCode[i] = cbDeviceCode.Text;
                            ClassGv.ActiveCalibrationList.DeviceName[i] = cbDeviceName.Text;
                            ClassGv.ActiveCalibrationList.PurposeOfUsage[i] = tbPurposeOfUsage.Text;
                            ClassGv.ActiveCalibrationList.StructureCode[i] = tbStructureCode.Text;
                            ClassGv.ActiveCalibrationList.DeviceTag[i] = tbDeviceTag.Text;
                            ClassGv.ActiveCalibrationList.CalibrationDate[i] = dtpCalibrationDate.Text;
                            ClassGv.ActiveCalibrationList.CalibrationPeriod[i] = nupCalibrationPeriod.Value.ToString();
                            ClassGv.ActiveCalibrationList.NextCalibrationDate[i] = dtpNextCalibrationTime.Text;
                            ClassGv.ActiveCalibrationList.CalibrationNote[i] = tbCalibrationNote.Text;
                        }

                        temp = temp+
                            ClassGv.ActiveCalibrationList.Date[i] + ";" +
                            ClassGv.ActiveCalibrationList.Time[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceCode[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceName[i] + ";" +
                            ClassGv.ActiveCalibrationList.PurposeOfUsage[i] + ";" +
                            ClassGv.ActiveCalibrationList.StructureCode[i] + ";" +
                            ClassGv.ActiveCalibrationList.DeviceTag[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationDate[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationPeriod[i] + ";" +
                            ClassGv.ActiveCalibrationList.NextCalibrationDate[i] + ";" +
                            ClassGv.ActiveCalibrationList.CalibrationNote[i] + ";\n";
                    }
                    ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\ActiveCalibrationList.txt";
                    ClassTxt.Update(temp);
                }
                else
                {
                    ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\ActiveCalibrationList.txt";
                    ClassTxt.Write(
                       DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                       DateTime.Now.ToString("HH:mm:ss") + ";" +
                       cbDeviceCode.Text + ";" +
                       cbDeviceName.Text + ";" +
                       tbPurposeOfUsage.Text + ";" +
                       tbStructureCode.Text + ";" +
                       tbDeviceTag.Text + ";" +
                       dtpCalibrationDate.Text + ";" +
                       nupCalibrationPeriod.Value.ToString() + ";" +
                       dtpNextCalibrationTime.Text + ";" +
                       tbCalibrationNote.Text + ";"
                       );
                }
                FormMain.GetActiveCalibrationList();
                dgvUpdate();

                ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\CalibrationHistoryList.txt";
                ClassTxt.Write(
                   DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                   DateTime.Now.ToString("HH:mm:ss") + ";" +
                   cbDeviceCode.Text + ";" +
                   cbDeviceName.Text + ";" +
                   tbPurposeOfUsage.Text + ";" +
                   tbStructureCode.Text + ";" +
                   tbDeviceTag.Text + ";" +
                   dtpCalibrationDate.Text + ";" +
                   nupCalibrationPeriod.Value.ToString() + ";" +
                   dtpNextCalibrationTime.Text + ";" +
                   tbCalibrationNote.Text + ";"
                   );
                FormMain.GetCalibrationHistoryList();
                FormMain.CalculateNearestAndPassedCalibration();

                FormMain.ClearNearestAndPassedCalibration();
                FormMain.CalculateNearestAndPassedCalibration();

                MessageBox.Show("Güncelleme Tamamlandı");
            }
        }

        private void mtbCalibrationPeriod_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DateTime calibrationTime = Convert.ToDateTime(dtpCalibrationDate.Text);
                DateTime nextCalibrationTime = Convert.ToDateTime(dtpCalibrationDate.Text).AddMonths(Convert.ToInt32(nupCalibrationPeriod.Value.ToString()));
                dtpNextCalibrationTime.Text = nextCalibrationTime.ToShortDateString();
            }
            catch (Exception)
            {

            }
        }

    }
}
