using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPExcepcion;

namespace TPExcepcionForms
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

        private void btn_nombreUnCaracter_Click(object sender, EventArgs e)
        {
            try
            {   string txtIngresado = txt_nombreUsuario.Text;
                Alumno alumno = new Alumno(txtIngresado);
                MessageBox.Show(alumno.Nombre);
            }

            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
