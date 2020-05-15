using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Windows.Forms;

namespace BMWi8_ProductOverview
{
    public partial class Login : Form
    {
        int username;
        public Login()
        {
            InitializeComponent();
            
        }
        private void btm_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_design_Click(object sender, EventArgs e)
        {

        }

        private void btn_details_Click(object sender, EventArgs e)
        {
 
        }

        private void btn_spec_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            guna2PictureBox_i8.Load("im_carbmwi8\\1.png");
            guna2PictureBox_i81.Load("im_carbmwi8\\1.png");
            guna2PictureBox_i82.Load("im_carbmwi8\\2.png");
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            guna2PictureBox_i8.Load("im_carbmwi8\\4.png");
            guna2PictureBox_i81.Load("im_carbmwi8\\4.png");
            guna2PictureBox_i82.Load("im_carbmwi8\\3.png");
        }

        private void guna2PictureBox_i81_Click(object sender, EventArgs e)
        {
            guna2PictureBox_i8.Image = guna2PictureBox_i81.Image;
        }

        private void guna2PictureBox_i82_Click(object sender, EventArgs e)
        {
            guna2PictureBox_i8.Image = guna2PictureBox_i82.Image;
        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.05;
            }
            else
            {
                timer1.Stop();
                Application.Exit();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void guna2ControlBox2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = textBox1.Text;
            pass = textBox2.Text;
            if (user == "customer" && pass == "12345")
            {
                MessageBox.Show("Succesfull Logged In");
                this.Hide();
                Form1 f1 = new Form1();
                f1.Show();
            }
            while (user != "customer" && pass != "12345")
            {
                    MessageBox.Show("Incorrect Password or Username");
                    this.Hide();
                    Login f2 = new Login();
                    f2.Show();
                break;
            }
        }
    }
}
