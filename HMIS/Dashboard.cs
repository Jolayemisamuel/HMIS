using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMIS
{
    public partial class main : Form
    {
        public void hidePanels()
        {
            home_panel1.Visible = false;
            room_panel3.Visible = false;
            Inventory_panel1.Visible = false;
            customer_panel1.Visible = false;
            employee_panel1.Visible = false;
            bar_panel1.Visible = false;
            kitchen_panel1.Visible = false;
            
        }

        public main()
        {
            InitializeComponent();
            Load += new EventHandler(main_Load);
            customer_panel1.Location = home_panel1.Location;
            room_panel3.Location = home_panel1.Location;
            Inventory_panel1.Location =home_panel1.Location;
            employee_panel1.Location = home_panel1.Location;
            bar_panel1.Location = home_panel1.Location;
            kitchen_panel1.Location = home_panel1.Location;
           
            
        }
        private void main_Load(object sender, EventArgs e)
        {
            hidePanels();
            home_panel1.Visible = true;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void home_Button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            home_panel1.Visible = true;
            room_panel3.BringToFront();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void room_Button2_Click(object sender, EventArgs e)
        {
            hidePanels();
            room_panel3.Visible = true;
          


        }

        private void logout_Button21_Click(object sender, EventArgs e)
        {
            this.Close();
          
           
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
          
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton10_Click(object sender, EventArgs e)
        {

        }

        private void cleanup_Button8_Click(object sender, EventArgs e)
        {

        }

        private void customer_Button3_Click(object sender, EventArgs e)
        {
            hidePanels();
            customer_panel1.Visible = true;
           
            
        }

        private void inventory_Button4_Click(object sender, EventArgs e)
        {
            hidePanels();
            Inventory_panel1.Visible = true;
         
         
        }

        private void employee_Button1_Click(object sender, EventArgs e)
        {
            hidePanels();
            employee_panel1.Visible = true;
            
         
        }

        private void bar_Button5_Click(object sender, EventArgs e)
        {
            hidePanels();
            bar_panel1.Visible = true;
            
           
        }

        private void kitchen_Button6_Click(object sender, EventArgs e)
        {
            hidePanels();
            kitchen_panel1.Visible = true;
          
          
        }

        private void laundry_Button7_Click(object sender, EventArgs e)
        {
            

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
