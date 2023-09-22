using ExamenP.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace ExamenP
{
    public partial class Inicio : Form
    {
        private object fCliente;

        public Inicio()
        {
            InitializeComponent();
            ConexionPGADMIN.ConexionPG objetoConexion = new ConexionPGADMIN.ConexionPG();
            objetoConexion.establecerConexion();       //Realizamos la conexion a la BD al inicio del proyecto
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FCiudad fp = new FCiudad();
            fp.Show();// Para mostrar el formulario al tocar sobre Ciudades
        }

        private void btn_Movimiento_Click(object sender, EventArgs e)
        {
            FMovimientos fp = new FMovimientos();
            fp.Show();// Para visualizar el formulario Movimiento 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FCliente fp = new FCliente();
            fp.Show(); //para ver el formulario cliente

        }

        private static void NewMethod()
        {
            //FCliente.Show();// para visualizar el formulario Cliente 
        }

        private void button1_Click_2(object sender, EventArgs e, FCliente fCliente)
        {
            //FCliente fp = new FCliente();
            //fp.Show();// para visualizar el formulario Cliente 
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            FCuentas fcuenta = new FCuentas();
            fcuenta.Show(); //Para Visualizar el formulario persona
        }

        private void btn_Persona_Click(object sender, EventArgs e)
        {
            FPersona fPersona = new FPersona();
            fPersona.Show(); //Para Visualizar el formulario persona
        }

        private void btn_movimiento_Click_1(object sender, EventArgs e)
        {
            FMovimientos fPersona = new FMovimientos();
            fPersona.Show(); //Para Visualizar el formulario persona

        }
    }
}
