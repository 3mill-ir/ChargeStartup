using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersianMessageBoxComponent
{
    public partial class PersianMessageBox : Form
    {
        private int counter = 0;
        private bool state = false;

        public const int Warning = 0;
        public const int Error = 1;
        public const int Information = 2;
        public const int Question = 3;
        public int g = 6;


        public PersianMessageBox()
        {
            InitializeComponent();

        }
        public bool show(string msg, string title, int img, int btnNum, string btnStr)
        {

            label1.Text = msg;
            this.Text = title;
            pictureBox1.Image = image(img); ;

            
            if (btnNum == 1)
            {
                CreateButton_Click("تایید", 200, 25, 60, 40);
            }
            else if (btnNum == 2)
            {
                if (btnStr == "YES/NO")
                {
                    CreateButton_Click("بله", 236, 25, 60, 40);
                    CreateButton_Click("خیر", 136, 25, 60, 40);
                    
                }
                else if (btnStr == "OK/CANCEL")
                {
                    CreateButton_Click("تایید", 236, 25, 60, 40);
                    CreateButton_Click("لغو", 136, 25, 60, 40);
                }
            }
            
            this.ShowDialog();
            return state;
        }
        public Image image(int img)
        {

            if (img == Warning)
                return Properties.Resources.Warning_pic;
            else if (img == Error)
                return Properties.Resources.Error_pic;
            else if (img == Information)
                return Properties.Resources.Info_pic;
            else if (img == Question)
                return Properties.Resources.Question_pic;

            return Properties.Resources.Info_pic;
        }
        private void CreateButton_Click(string btnTxt, int x_lox, int y_loc, int x_size, int y_size)
        {

            Button button = new Button();

            button.Name = "Butt" + counter;
            button.Text = btnTxt;
            button.Location = new Point(x_lox, y_loc);
            button.Size = new Size(x_size, y_size);

            if (btnTxt == "بله" || btnTxt == "تایید")
                this.AcceptButton = button;
            else if (btnTxt == "خیر" || btnTxt == "لغو")
                this.CancelButton = button;
            counter++;

            button.Click += new EventHandler(NewButton_Click);
            panel1.Controls.Add(button);
        }


        private void NewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            for (int i = 0; i < counter; i++)
            {
                if (btn.Name == ("Butt" + i))
                {
                    if (btn.Text == "تایید" || btn.Text == "بله")
                    {
                        state = true;
                        Close();
                    }
                    else if (btn.Text == "لغو" || btn.Text == "خیر")
                    {
                        state = false;
                        Close();
                    }
                    break;
                }
            }
        }
    }
}
