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
    public partial class FormAddDevice : Form
    {
        public FormAddDevice()
        {
            InitializeComponent();
        }

        private void dgvUpdate()
        {
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Column1", "Eklenme Tarihi");
            //dataGridView1.Columns.Add("Column2", "Eklenme Saati");
            dataGridView1.Columns.Add("Column3", "Cihaz Kodu");
            dataGridView1.Columns.Add("Column4", "Cihaz Adı");
            dataGridView1.Columns.Add("Column5", "Kullanım Amacı");
            dataGridView1.Columns.Add("Column6", "Bina Kodu");
            dataGridView1.Columns.Add("Column7", "Cihaz Künyesi");
            dataGridView1.Columns.Add("Column8", "Kalibrasyon Gerekliliği");

            for (int i = 0; i < ClassGv.DeviceList.Date.Count; i++)
            {
                dataGridView1.Rows.Add(ClassGv.DeviceList.Date[i],
                    //ClassGv.DeviceList.Time[i],
                    ClassGv.DeviceList.DeviceCode[i],
                    ClassGv.DeviceList.DeviceName[i],
                    ClassGv.DeviceList.PurposeOfUsage[i],
                    ClassGv.DeviceList.StructureCode[i],
                    ClassGv.DeviceList.DeviceTag[i],
                    ClassGv.DeviceList.CalibrationRequired[i]
                    );

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

        private void FormAddDevice_Load(object sender, EventArgs e)
        {
            AddDataToComboBox();
            dgvUpdate();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (tbStructureCode.Text.Length == 0 ||
               cbDeviceCode.Text.Length == 0 ||
               tbPurposeOfUsage.Text.Length == 0)
            {
                MessageBox.Show("Bütün alanlar doldurulmalıdır");
            }
            else
            {
                for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
                {
                    if (ClassGv.DeviceList.DeviceCode[i]== cbDeviceCode.Text)
                    {
                        MessageBox.Show("Aynı cihaz kodu ile tekrar cihaz eklenemez");
                        return;
                    }
                }

                if (cbDeviceCode.Text.Contains(";") ||
                    cbDeviceName.Text.Contains(";") ||
                    tbPurposeOfUsage.Text.Contains(";") ||
                    tbStructureCode.Text.Contains(";") ||
                    tbDeviceTag.Text.Contains(";"))
                {
                    MessageBox.Show("Noktalı virgül içeren yazı yaılamaz ( ; )");
                    return;
                }
                

                ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\DeviceList.txt";
                ClassTxt.Write(
                   DateTime.Now.ToString("dd/MM/yyyy") + ";" +
                   DateTime.Now.ToString("HH:mm:ss") + ";" +
                   cbDeviceCode.Text + ";" +
                   cbDeviceName.Text + ";" +
                   tbPurposeOfUsage.Text + ";" +
                   tbStructureCode.Text + ";" +
                   tbDeviceTag.Text + ";"+
                   cbCalibrationRequired.Checked+";"
                   );

                FormMain.ClearDeviceData();
                FormMain.GetDeviceList();
                AddDataToComboBox();
                dgvUpdate();
                MessageBox.Show("Kayıt Tamamlandı");

            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string temp = "";
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (ClassGv.DeviceList.DeviceCode[i] == cbDeviceCode.Text)
                {
                    ClassGv.DeviceList.Date[i] = DateTime.Now.ToString("dd/MM/yyyy");
                    ClassGv.DeviceList.Time[i] = DateTime.Now.ToString("HH:mm:ss");
                    ClassGv.DeviceList.DeviceCode[i] = cbDeviceCode.Text;
                    ClassGv.DeviceList.DeviceName[i] = cbDeviceName.Text;
                    ClassGv.DeviceList.PurposeOfUsage[i] = tbPurposeOfUsage.Text;
                    ClassGv.DeviceList.StructureCode[i] = tbStructureCode.Text;
                    ClassGv.DeviceList.DeviceTag[i] = tbDeviceTag.Text;
                    ClassGv.DeviceList.CalibrationRequired[i] = cbCalibrationRequired.Checked.ToString();
                }

                temp = temp +
                    ClassGv.DeviceList.Date[i] + ";" +
                    ClassGv.DeviceList.Time[i] + ";" +
                    ClassGv.DeviceList.DeviceCode[i] + ";" +
                    ClassGv.DeviceList.DeviceName[i] + ";" +
                    ClassGv.DeviceList.PurposeOfUsage[i] + ";" +
                    ClassGv.DeviceList.StructureCode[i] + ";" +
                    ClassGv.DeviceList.DeviceTag[i] + ";" +
                    ClassGv.DeviceList.CalibrationRequired[i] + ";\n";
            }
            ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\DeviceList.txt";
            ClassTxt.Update(temp);
            FormMain.GetDeviceList();
            AddDataToComboBox();
            dgvUpdate();
            MessageBox.Show("Cihaz güncellendi");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ClassGv.FilePathOfTxt = System.IO.Directory.GetCurrentDirectory() + "\\DeviceList.txt";
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                {
                    ClassGv.DeviceList.Date.Remove(ClassGv.DeviceList.Date[i]);
                    ClassGv.DeviceList.Time.Remove(ClassGv.DeviceList.Time[i]);
                    ClassGv.DeviceList.DeviceCode.Remove(ClassGv.DeviceList.DeviceCode[i]);
                    ClassGv.DeviceList.DeviceName.Remove(ClassGv.DeviceList.DeviceName[i]);
                    ClassGv.DeviceList.PurposeOfUsage.Remove(ClassGv.DeviceList.PurposeOfUsage[i]);
                    ClassGv.DeviceList.StructureCode.Remove(ClassGv.DeviceList.StructureCode[i]);
                    ClassGv.DeviceList.DeviceTag.Remove(ClassGv.DeviceList.DeviceTag[i]);                    
                    ClassGv.DeviceList.CalibrationRequired.Remove(ClassGv.DeviceList.CalibrationRequired[i]);                    
                }
            }

            string temp="";
            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                temp = ClassGv.DeviceList.Date[i]+";"+
                    ClassGv.DeviceList.Time[i] + ";" +
                    ClassGv.DeviceList.DeviceCode[i] + ";" +
                    ClassGv.DeviceList.DeviceName[i] + ";" +
                    ClassGv.DeviceList.PurposeOfUsage[i] + ";" +
                    ClassGv.DeviceList.StructureCode[i] + ";" +
                    ClassGv.DeviceList.DeviceTag[i] + ";"+
                    ClassGv.DeviceList.CalibrationRequired[i] + ";";
            }
            ClassTxt.Update(temp);
            FormMain.ClearDeviceData();
            FormMain.GetDeviceList();
            AddDataToComboBox();
            dgvUpdate();
            MessageBox.Show("Cihaz silindi");
        }

        private void cbDeviceCode_SelectedIndexChanged(object sender, EventArgs e)
        {           
            ComboBox combo=(ComboBox)sender;

            for (int i = 0; i < ClassGv.DeviceList.DeviceCode.Count; i++)
            {
                if (combo.Name == "cbDeviceCode" && cbDeviceCode.Text == ClassGv.DeviceList.DeviceCode[i])
                {
                    cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                    if (ClassGv.DeviceList.CalibrationRequired[i]=="True") cbCalibrationRequired.Checked = true;
                    else cbCalibrationRequired.Checked = false;
                    return;
                }
                else if (combo.Name == "cbDeviceName" && cbDeviceName.Text == ClassGv.DeviceList.DeviceName[i])
                {
                    cbDeviceCode.Text = ClassGv.DeviceList.DeviceCode[i];
                    cbDeviceName.Text = ClassGv.DeviceList.DeviceName[i];
                    tbPurposeOfUsage.Text = ClassGv.DeviceList.PurposeOfUsage[i];
                    tbStructureCode.Text = ClassGv.DeviceList.StructureCode[i];
                    tbDeviceTag.Text = ClassGv.DeviceList.DeviceTag[i];
                    if (ClassGv.DeviceList.CalibrationRequired[i] == "True") cbCalibrationRequired.Checked = true;
                    else cbCalibrationRequired.Checked = false;
                    return;
                }
                else//if written new device code clear all text box (action required)
                {
                    tbPurposeOfUsage.Text = "";
                    tbStructureCode.Text = "";
                    tbDeviceTag.Text = "";
                    cbCalibrationRequired.Checked = false;
                }
            }
        }
    }
}
