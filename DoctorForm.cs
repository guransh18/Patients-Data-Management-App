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

namespace DAMS
{
    public partial class DoctorForm : Form
    {
        
        public DoctorForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DAMS;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "select * from DoctorTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DocGV.DataSource = ds.Tables[0];
            con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (DocId.Text == "" || DocName.Text == "" || DocPass.Text == "" || DocExp.Text == "")
            {
                MessageBox.Show("Please fill values... No empty box is allowed");
            }
            else
            {
                con.Open();
                string query = "insert into DoctorTable values(" + DocId.Text + ",'" + DocName.Text + "'," + DocExp.Text + ",'" + DocPass.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                _ = cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor info successfully added");
                con.Close();
                populate();
            }

        }

        private void DoctorForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(DocId.Text == "")
            {
                MessageBox.Show("Enter the Doctor's ID");
                
            }
            else
            {
                con.Open();
                string query = "delete from DoctorTable where DocId =" + DocId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Doctor Successfully deleted");
                con.Close();    
                populate();
            }
        }

        private void DocGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DocId.Text = DocGV.SelectedRows[0].Cells[0].Value.ToString();
            DocName.Text = DocGV.SelectedRows[0].Cells[1].Value.ToString();
            DocExp.Text = DocGV.SelectedRows[0].Cells[2].Value.ToString();
            DocPass.Text = DocGV.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update DoctorTable set DocName = '" + DocName.Text + "', DocExp = '" + DocExp.Text + "', DocPass = '" + DocPass.Text + "',DocId = '" + DocId.Text + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Doctor Info successfully updated");
            con.Close();
            populate();
        }

        private void DocId_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Form1 h = new Form1  ();
            h.Show();
            this.Hide();
        }
    }
}
