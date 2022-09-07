using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace EdadPersona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Persona persona;
        private void btnPersona_Click(object sender, EventArgs e)
        {
            try
            {
                persona = new Persona(
                    txtNombre.Text, 
                    Convert.ToInt32(txtDNI.Text), 
                    DateTime.Parse(txtFechaNac.Text)
                );

                if (persona.DNI.ToString().Length != 8)
                {
                    MessageBox.Show("Documento debe tener 8 caracteres");
                    persona = null;
                    return;
                }
                
                MessageBox.Show("Ha generado una persona correctamente!");

            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error. Intentelo de nuevo.");
            }
        }

        private void btnEdad_Click(object sender, EventArgs e)
        {
            if (persona == null)
            {
                MessageBox.Show("Debe generar una Persona para obtener la edad.");
                return;
            }

            lblEdad.Text = persona.DevolucionEdad().ToString();
        }
    }
}
