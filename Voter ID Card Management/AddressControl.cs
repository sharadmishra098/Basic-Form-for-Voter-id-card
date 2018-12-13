using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Voter_ID_Card_Management
{
    public partial class AddressControl : UserControl
    {
        private static AddressControl _instance;
        public static AddressControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AddressControl();
                }
                return _instance;
            }
        }

        public AddressControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True");

        public void refresh_DataGridView()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("ShowAllData_SP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("          <<<INVALID SQL OPERATION>>>: \n" + ex);
                }
                con.Close();

                dataGridView1.DataSource = DS.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }




        private void AddressControl_Load(object sender, EventArgs e)
        {
            refresh_DataGridView();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Address_sp", con);
            cmd.CommandType = CommandType.StoredProcedure;

           // cmd.Parameters.AddWithValue("@Id", textBox1.Text);
            cmd.Parameters.AddWithValue("@houseNo", textBox2.Text);
            cmd.Parameters.AddWithValue("@street", textBox3.Text);
            cmd.Parameters.AddWithValue("@city", textBox4.Text);
            cmd.Parameters.AddWithValue("@country", textBox5.Text);
            cmd.Parameters.AddWithValue("@pincode", textBox6.Text);
            cmd.Parameters.AddWithValue("@district", textBox7.Text);
            cmd.Parameters.AddWithValue("@constituency", textBox8.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("      <<<INVALID SQL QUERY>>>:  \n" + ex);
            }
            con.Close();

            refresh_DataGridView();
            MessageBox.Show("Congrats!! Voter Added Successfully");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("AddressDelete_sp", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@houseNo", textBox2.Text);


                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("      <<<INVALID SQL QUERY>>>:  \n" + ex);
                }
                con.Close();

                refresh_DataGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
        }
    }
}
