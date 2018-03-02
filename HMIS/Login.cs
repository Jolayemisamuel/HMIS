using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HMIS
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginButton1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SAMUELSON-PC\SQLEXPRESS;Initial Catalog=HMIS;Integrated Security=True;Pooling=False");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + username_Textbox1.text + "' and password ='" + password_Textbox2.text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {


                this.Hide();
                main mm = new main();
                mm.Show();

            }
            else
            {
                MessageBox.Show("Please enter your username and password", "alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void cancel_Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
