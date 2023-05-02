using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace DAMS
{
    public partial class PatientForm : Form
    {
       
        public PatientForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DAMS;Integrated Security=True");
        void populate()
        {
            con.Open();
            string query = "select * from PatientTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            PatientGV.DataSource = ds.Tables[0];
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
            if (PatId.Text == "" || PatName.Text == "" || PatAdd.Text == "" || PatPhone.Text == "" || PatAge.Text == "" || PatDisease.Text == "")
            {
                MessageBox.Show("Please fill values... No empty box is allowed");
            }
            else
            {
                con.Open();
                string query = "insert into PatientTable values(" + PatId.Text + ",'" + PatName.Text + "','" + PatAdd.Text + "','" + PatPhone.Text + "', " + PatAge.Text + ", '" + GenderCb.SelectedItem.ToString() + "','" + BloodCb.SelectedItem.ToString() + "', '" + PatDisease.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient info successfully added");
                con.Close();
                populate();
            }
        }

        private void PatientForm_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (PatId.Text == "")
            {
                MessageBox.Show("Enter the Patient's ID");

            }
            else
            {
                con.Open();
                string query = "delete from PatientTable where PatId =" + PatId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient Info Successfully deleted");
                con.Close();
                populate();
            }
        }

        private void PatientGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PatId.Text = PatientGV.SelectedRows[0].Cells[0].Value.ToString();
            PatName.Text = PatientGV.SelectedRows[0].Cells[1].Value.ToString();
            PatAdd.Text = PatientGV.SelectedRows[0].Cells[2].Value.ToString();
            PatPhone.Text = PatientGV.SelectedRows[0].Cells[3].Value.ToString();
            PatAge.Text = PatientGV.SelectedRows[0].Cells[4].Value.ToString();
            PatDisease.Text = PatientGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update PatientTable set PatName = '" + PatName.Text + "', PatAdd = '" + PatAdd.Text + "', PatPhone = '" + PatPhone.Text + "',PatAge = " + PatAge.Text + ",PatGender='" + GenderCb.SelectedItem.ToString() + "',PatBlood= '" + BloodCb.SelectedItem.ToString() + "' where PatId= " + PatId.Text +"";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Patient Info successfully updated");
            con.Close();
            populate();
        }

        private void PatId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
