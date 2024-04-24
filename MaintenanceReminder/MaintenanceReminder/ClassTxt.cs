using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaintenanceReminder
{
    class ClassTxt
    {
        static int k;
        public static void Write(string data)
        {
            try
            {                
                if (ClassGv.FilePathOfTxt != string.Empty)
                {
                    FileStream fs = new FileStream(ClassGv.FilePathOfTxt, FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public static string Read()
        {
            k = 0;
            if (ClassGv.FilePathOfTxt != string.Empty)
            {
                ClassGv.DataOfTxtFile = "";
                StreamReader sr = new StreamReader(ClassGv.FilePathOfTxt);
                while (sr.Peek() > -1)
                {
                    ClassGv.DataOfTxtFile = ClassGv.DataOfTxtFile+ sr.ReadLine();
                    k++;
                }
                sr.Close();
            }
            return ClassGv.DataOfTxtFile;
        }

        public static void FileCreate()
        {
            FileStream fs = new FileStream(ClassGv.FilePathOfTxt, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Close();
        }

        public static void Update(string data)
        {
            try
            {
                if (ClassGv.FilePathOfTxt != string.Empty)
                {
                    FileStream fs = new FileStream(ClassGv.FilePathOfTxt, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
            catch (Exception)
            {
            }
        }
    }
}

