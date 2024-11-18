using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfazdeUsuario.Formularios
{
    public partial class FrmStudent : MetroFramework.Forms.MetroForm
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            string cif = tbCif.Text;

            if(cif.Length < 8)
            {
                MessageBox.Show("El cif debe tener 8 digitos, por favor rellena el campo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(cif.Length > 8)
            {
                MessageBox.Show("El cif debe tener exactamente 8 digitos, ha ingresado de más", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else
            {
                MessageBox.Show("Registro exitoso.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
