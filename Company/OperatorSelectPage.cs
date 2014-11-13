using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompanyBussinesLayer;

namespace Company
{
    public partial class OperatorSelectPage : Form
    {
        CompanyBusiness Company;

        public OperatorSelectPage(CompanyBusiness CB)
        {
            InitializeComponent();
            Company = CB;
            FillForm();
            
        }

        public void FillForm()
        {

            DataTable dt = new DataTable();
            dt = Company.OperatorsList();



            dataGridView1.DataSource = dt;

            dataGridView1.Columns[0].HeaderText = "نام";
            dataGridView1.Columns[1].HeaderText = "نام خانوادگی";
            dataGridView1.Columns[2].HeaderText = "شماره کاربری";

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = ((DataTable)dataGridView1.DataSource).Columns[1].ColumnName + " like '" + textBox1.Text.Trim().Replace("'", "''") + "%'";
            }
            catch (Exception)
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
            try
            {
                ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = "Convert(" + ((DataTable)dataGridView1.DataSource).Columns[2].ColumnName + ", 'System.String')" + " like '" + textBox2.Text.Trim().Replace("'", "''") + "%'";
            }
            catch (Exception)
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username_str;
            username_str = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();

            Int64 username_int = Int64.Parse(username_str);
            OperatorEditPage OEP = new OperatorEditPage(Company, username_int);
            OEP.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("fa-ir");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            System.Globalization.CultureInfo language = new System.Globalization.CultureInfo("en-us");
            InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(language);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                textBox2.Text = string.Empty;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                textBox1.Text = string.Empty;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username_str;
            username_str = dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[2].Value.ToString();

            Int64 username_int = Int64.Parse(username_str);
            OperatorShowPage OSP = new OperatorShowPage(Company, username_int);
            OSP.Show();
        }
    }
}
