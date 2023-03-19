using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using SpreadsheetLight;

namespace Practica3_Threads_9CM11
{
    public partial class Form1 : Form
    {
        Thread ADC1, ADC2,ADC3;
        SLDocument ArchivoRegistro;     //Varable para manejar el archivo
        DataTable Registros;            //Variable para almacenar datos que se enviaran al archivo
        double Dato1, Dato2, Dato3, DatoRetorno;
        double Vin = 0, R;
        double Vin1 = 0, Vin2=0;
    
        private void label1_Click(object sender, EventArgs e)
        {

        }

        int Bits = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (BtnIniciar.Text == "Iniciar")
            {
                BtnIniciar.Text = "Finalizar";
                PctBxXls.Enabled = false;

                Registros = new DataTable();             //Instanciamos la Variable para almacenar datos en forma de tabla
                //Creamos el encabezado de las columnas de la tabla
                Registros.Columns.Add("ADC 1", typeof(string));
                Registros.Columns.Add(" ", typeof(string));
                Registros.Columns.Add("ADC 2", typeof(string));
                Registros.Columns.Add("  ", typeof(string));
                Registros.Columns.Add("ADC 3", typeof(string));
                Registros.Columns.Add("    ", typeof(string));
                Registros.Rows.Add("Vin", "Dato", "Vin", "Dato", "Vin", "Dato");

                timer1.Start();                 //Inicia el proceso de forma cíclica (10 registros por segundo)
            }
            else
            {
                BtnIniciar.Text = "Iniciar";
                timer1.Stop();                  //Detiene el proceso
                string pathFile = AppDomain.CurrentDomain.BaseDirectory + "Registros.xlsx";     //Creamos la ruta donde se guardará el archivo
                ArchivoRegistro = new SLDocument();      //Instanciamos la variable para crear el archivo
                ArchivoRegistro.ImportDataTable(1, 1, Registros, true);     //Importamos todos los registros guardados en la tabla al archivo excel
                ArchivoRegistro.SaveAs(pathFile);         //Guardamos el archivo actualizado
                PctBxXls.Enabled = true;       //Habilitamos el control de la imagen para darle clic y abrir el archivo desde la interfaz
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //CREAR LOS HILOS
            ADC1 = new Thread(()=>CalculoADC(Vin,Vin1,Vin2,Rbtn1_8.Checked,Rbtn1_10.Checked,Rbtn1_16.Checked));
            ADC1.Name = "Primer hilo";
            ADC2 = new Thread(()=>CalculoADC(Vin,Vin1,Vin2,Rbtn2_8.Checked, Rbtn2_10.Checked, Rbtn2_16.Checked));
            ADC2.Name = "Segundo hilo";
            ADC3 = new Thread(()=>CalculoADC(Vin,Vin1,Vin2, Rbtn3_8.Checked, Rbtn3_10.Checked, Rbtn3_16.Checked));
            ADC3.Name = "Tercer hilo";

            // LEEMOS VALORES PARA EL HILO-1 Y ACTIVAMOS EL HILO CON LOS VALORES CORRESPONDIENTES YA ALMACENADOS
            Vin = double.Parse(TxBxV1.Value.ToString());
            ADC1.Start();
            ADC1.Join();                //Sincronizacion de Threads
            Dato1 = DatoRetorno;

            // LEEMOS VALORES PARA EL HILO-2 Y ACTIVAMOS EL HILO CON LOS VALORES CORRESPONDIENTES YA ALMACENADOS
            Vin1 = double.Parse(TxBxV2.Value.ToString());
            ADC2.Start();
            ADC2.Join();                //Sincronizacion de Threads
            Dato2 = DatoRetorno;

            // LEEMOS VALORES PARA EL HILO-3 Y ACTIVAMOS EL HILO CON LOS VALORES CORRESPONDIENTES YA ALMACENADOS
            Vin2 = double.Parse(TxBxV3.Value.ToString());
            ADC3.Start();
            ADC3.Join();                //Sincronizacion de Threads
            Dato3 = DatoRetorno;

            //Almacenamos los datos en la tabla de registros
            Registros.Rows.Add(TxBxV1.Value.ToString(), Dato1.ToString(), TxBxV2.Value.ToString(), Dato2.ToString(), TxBxV3.Value.ToString(), Dato3.ToString());
        }

        private void PctBxXls_Click(object sender, EventArgs e)     //Abrir el archivo excel
        {
            System.Diagnostics.Process.Start("Registros.xlsx");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void credencialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Credenciales miFirma = new Credenciales();
            miFirma.ShowDialog();
        }

        //--------> HILOS <-------------
        public void CalculoADC(double vin, double vin1, double vin2, bool status_8, bool status_10, bool status_16)
        {
            try
            {

                if (Thread.CurrentThread.Name == "Primer hilo")
                {
                    if (status_8)
                        Bits = 8;
                    if (status_10)
                        Bits = 10;
                    if (status_16)
                        Bits = 16;
                    R = 5 / (Math.Pow(2, Bits) - 1);     // Calculo de la resolución
                    DatoRetorno = Math.Round(Vin / R);         //Cálculo del dato
                }
                if (Thread.CurrentThread.Name == "Segundo hilo")
                {
                    if (status_8)
                        Bits = 8;
                    if (status_10)
                        Bits = 10;
                    if (status_16)
                        Bits = 16;
                    R = 5 / (Math.Pow(2, Bits) - 1);     // Calculo de la resolución
                    DatoRetorno = Math.Round(Vin1 / R);         //Cálculo del dato
                }
                if (Thread.CurrentThread.Name == "Tercer hilo")
                {
                    if (status_8)
                        Bits = 8;
                    if (status_10)
                        Bits = 10;
                    if (status_16)
                        Bits = 16;
                    R = 5 / (Math.Pow(2, Bits) - 1);     // Calculo de la resolución
                    DatoRetorno = Math.Round(Vin2 / R);         //Cálculo del dato
                }
            }
            catch
            {
                error.Text = "Falla en el sistema por favor detenga la aplicación.";
            }
        }
    }
}
