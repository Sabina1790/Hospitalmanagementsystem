using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Hospital_Management_System
{
    public class HelperClass
    {
        public static void makeFieldsBlank(Control ctrl)
        {
            foreach (Control a in ctrl.Controls)
            {
                if (a is TextBox)
                    a.Text = "";
                if (a is ComboBox)
                    a.Text = null;
                if (a is RadioButton)
                    a.Text = null;
                if (a is CheckBox)
                    a.Text = null;
                if (a is DateTimePicker)
                    a.Text = null;
            }
        }
        public static byte[] imageConverter(PictureBox pictureBox)
        {
            try
            {
                MemoryStream memoryStream = new MemoryStream();
                pictureBox.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] ImageFile = new byte[memoryStream.Length];
                memoryStream.Position = 0;
                memoryStream.Read(ImageFile, 0, ImageFile.Length);
                return ImageFile;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
