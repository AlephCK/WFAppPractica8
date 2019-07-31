using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAppPractica8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ID_Factura = tbx_idfactura.Text;
            string Condiciones = tbx_condiciones.Text;
            string ID_Cliente = tbx_idcliente.Text;
            string Fecha = tbx_fecha.Text;
            string Monto = tbx_monto.Text;
            string Estado = cmb_estado.Text;


            string[] arr = { ID_Factura, Condiciones, ID_Cliente, Fecha, Monto, Estado };
            
            var process = new Process();
            process.StartInfo.FileName = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName, "caFactura/bin/Debug/caFactura.exe");
            process.StartInfo.Arguments = arr[2];  
            process.Start();

        }
    }
}
