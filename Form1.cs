using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace DAMS
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DAMS;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DocNameTb.Text == "" || PassTb.Text == "")
            {
                MessageBox.Show("Please enter a UserName and a PassWord");
            }
            else
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from DoctorTable where DocName='" + DocNameTb.Text + "'and DocPass = '"+ PassTb.Text +"'", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    Home h = new Home();
                    h.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Wrong UserName and Password");
                }
                con.Close();
            }
           
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DocNameTb.Text = "";
            PassTb.Text = "";
        }

        private void DocNameTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            DoctorForm h = new DoctorForm();
            h.Show();
            this.Hide();
        }
    }
}