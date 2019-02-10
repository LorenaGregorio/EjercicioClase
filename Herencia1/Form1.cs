using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> listaempleados = new List<Empleado>();
        List<Cliente> listaclientes = new List<Cliente>();

        private void button1_Click(object sender, EventArgs e)
        {

            Habilidad MiHabilidad1 = new Habilidad
            {
                Numero = 1,
                Nombre = "Puntualidad",
                Descripcion = "No es irresponsable"

            };


            Habilidad MiHabilidad2 = new Habilidad
            {
                Numero = 2,
                Nombre = "Confianza",
                Descripcion = "Es confiable"
            };

            Habilidad MiHabilidad3 = new Habilidad
            {
                Numero = 3,
                Nombre = "Respeto",
                Descripcion = "Es respetuso"
            };

            Habilidad MiHabilidad4 = new Habilidad
            {
                Numero = 4,
                Nombre = "Honradez",
                Descripcion = "Persona honrada"

            };

            List<Habilidad> MisHabilidades = new List<Habilidad>();
            {
                MisHabilidades.Add(MiHabilidad1);
                MisHabilidades.Add(MiHabilidad2);
                MisHabilidades.Add(MiHabilidad3);
                MisHabilidades.Add(MiHabilidad4);

            };

            var empleado1 = new Empleado

            {
                //Empleado
                Carne = 140405001,
                Nombre = "Lorena",
                Apellidos = "Gregorio",
                Direccion = "zona 21",
                Telefono = 5625160,
                Email = "lorena@hotmail.com",
                //Factura
                NIT = "125-5",
                DireccionFactura = "Calzada Roosevelt",
                Fecha = DateTime.Now,
                NombreEmpresa = "Motursa",
                NumeroFactura = 1,
            };

            
            var cliente1 = new Cliente
            {
                //Cliente
                CodigoCliente = 325,
                NombreCliente = "PERFORSA",
                TipoCliente = "A",
                EstadoCliente = true,
                //Producto
                Codigo = 123,
                Descripcion = "Tubos HG",


             };




           


           
            //a la lista creada arriba,se le agregaran los datos que sean 
            //ingresadosen objeto cuenta1
            listaempleados.Add(empleado1 );

            //se restea el dataGridView1 o la pantalla
            dataGridView1.DataSource = null;
            //se muestra en el dataGridView1 los datos que tenga la lista
            dataGridView1.DataSource = listaempleados;

            //listaclientes.Add(cliente1);

            //dataGridView1.DataSource = listaclientes; 

                      

            MisHabilidades.Add(MiHabilidad1);
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = MisHabilidades;

            listaclientes.Add(cliente1);
            dataGridView3.DataSource = null;
            dataGridView3.DataSource = listaclientes;






        }
    }
}
