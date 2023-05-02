using System.Data;
using System.Data.SqlClient;

namespace DAMS
{
    public partial class DiagnosisForm : Form
    {
        public DiagnosisForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }
        SqlConnection con = new SqlConnection(@"Data Source=HP\SQLEXPRESS;Initial Catalog=DAMS;Integrated Security=True");
        void populatecombo()
        {
            string sql = "select * from PatientTable";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader rdr;
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("PatId");
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                PatientIdCb.ValueMember = "PatId";
                PatientIdCb.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {

            }
        }
        string patname;
        void fetchPatientName()
        {
            con.Open();
            string mysql = "select * from PatientTable where PatId = " + PatientIdCb.SelectedValue.ToString() + "";
            SqlCommand cmd = new SqlCommand(mysql, con);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                patname = dr["PatName"].ToString();
                PatientTb.Text = patname;
            }
            con.Close();
        }
        void populate()
        {
            con.Open();
            string query = "select * from DiagnosisTable";
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            DiagnosisGV.DataSource = ds.Tables[0];
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
            if (DiagId.Text == "" || MedicineTb.Text == "" || DiagnosisTb.Text == "" || PatientTb.Text == "" || SymptomsTb.Text == "")
            {
                MessageBox.Show("Please fill values... No empty box is allowed");
            }
            else
            {
                con.Open();
                string query = "insert into DiagnosisTable values(" + DiagId.Text + "," + PatientIdCb.SelectedValue.ToString() + ",'" + PatientTb.Text + "','" + SymptomsTb.Text + "', '" + DiagnosisTb.Text + "','" + MedicineTb.Text + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis info successfully added");
                con.Close();
                populate();
            }
        }

        private void DiagnosisFormcs_Load(object sender, EventArgs e)
        {
            populatecombo();
            populate();
        }

        private void PatientIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            fetchPatientName();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (DiagId.Text == "")
            {
                MessageBox.Show("Enter the Diagnosis ID");

            }
            else
            {
                con.Open();
                string query = "delete from DiagnosisTable where PatId =" + DiagId.Text + "";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Diagnosis Info Successfully deleted");
                con.Close();
                populate();
            }
        }

        private void DiagnosisGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DiagId.Text = DiagnosisGV.SelectedRows[0].Cells[0].Value.ToString();
            PatientIdCb.Text = DiagnosisGV.SelectedRows[0].Cells[1].Value.ToString();
            PatientTb.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            DiagnosisTb.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            SymptomsTb.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            MedicineTb.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
            PatientNamelbl.Text = DiagnosisGV.SelectedRows[0].Cells[2].Value.ToString();
            Diagnosislbl.Text = DiagnosisGV.SelectedRows[0].Cells[3].Value.ToString();
            Symptomslbl.Text = DiagnosisGV.SelectedRows[0].Cells[4].Value.ToString();
            Medicineslbl.Text = DiagnosisGV.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update DiagnosisTable set PatId = " + PatientIdCb.SelectedValue.ToString() + ", PatName = '" + PatientTb.Text + "', Symptoms = '" + SymptomsTb.Text + "',Diagnosis = '" + DiagnosisTb.Text + "',Medicines = '" + MedicineTb.Text + "' where DiagId = " + DiagId.Text + "";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Diagnosis Info successfully updated");
            con.Close();
            populate();
        }

        private void DiagId_TextChanged(object sender, EventArgs e)
        {

        }

        private void SymptomsTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
