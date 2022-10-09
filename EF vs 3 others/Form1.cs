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

using System.Collections.Generic;

namespace EF_vs_3_others
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-PPIILUB;Initial Catalog=crudTest;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_adHoc_Click(object sender, EventArgs e)
        {
            

            SqlConnection conn = new SqlConnection(connectionString);
            SqlDataAdapter SqlDa = new SqlDataAdapter("select * from friends where id=" + textBox1.Text, conn);
            DataTable DTable = new DataTable();
            SqlDa.Fill(DTable);
            dataGridView1.DataSource = DTable;
        }

        private void btn_para_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("select * from friends where id=@id",con);
            da.SelectCommand.Parameters.AddWithValue("@id", textBox1.Text);
            //da.SelectCommand.Parameters.AddWithValue("@id", int.Parse(textBox1.Text));
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_stored_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter da = new SqlDataAdapter("getlist", con);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@id", textBox1.Text);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_ef_Click(object sender, EventArgs e)
        {
            
            int id = int.Parse(textBox1.Text);
            crudTestEntities1 TE = new crudTestEntities1();
            var query = from row in TE.friends
                        where row.id == id
                        select row;
            dataGridView1.DataSource = query.ToList();
        }
    }
}
