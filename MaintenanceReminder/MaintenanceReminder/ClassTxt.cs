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
        public static void Write(string data,string path)
        {
            try
            {                
                if (path != string.Empty)
                {
                    FileStream fs = new FileStream(path, FileMode.Append, FileAccess.Write, FileShare.Write);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine(data);
                    sw.Close();
                }
            }
            catch (Exception)
            {
            }
        }

        public static string Read(string path)
        {
            k = 0;
            if (path != string.Empty)
            {
                ClassGv.DataOfTxtFile = "";
                StreamReader sr = new StreamReader(path);
                while (sr.Peek() > -1)
                {
                    ClassGv.DataOfTxtFile = ClassGv.DataOfTxtFile+ sr.ReadLine();
                    k++;
                }
                sr.Close();
            }
            return ClassGv.DataOfTxtFile;
        }

        public static void FileCreate(string path)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Close();
        }

        public static void Update(string data,string path)
        {
            try
            {
                if (path != string.Empty)
                {
                    FileStream fs = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite);
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

