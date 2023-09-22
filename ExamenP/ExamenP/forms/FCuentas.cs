using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenP.forms
{
    public partial class FCuentas : Form
    {
        public FCuentas()
        {
            InitializeComponent();

            NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Port=5432;Username=postgres;Password=12qwaszx;Database=postgres;");
            conn.Open();

            // InitializeComponent(); 

            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = conn;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "Select * from cuentas;";
            NpgsqlDataReader dr = comm.ExecuteReader();
            if (dr.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(dr);
                GRIDCUENTA.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
                GRIDCUENTA.DataSource = dt;

            }
            comm.Dispose();
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FCuentas_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_añadir_Click(object sender, EventArgs e)
        {
            boxcosto.Enabled = true;
            boxestado.Enabled = true;
            boxmoneda.Enabled = true;
            boxnrocontrato.Enabled = true;
            boxprom.Enabled = true;
            boxsaldo.Enabled = true;
            boxtipcuent.Enabled = true;
            BOXCUENTA.Enabled = true;
            BOXFECHAALTA.Enabled = true;
            Boxnrocuenta.Enabled = true;
            bool nuevo;
            nuevo = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOXCUENTA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
