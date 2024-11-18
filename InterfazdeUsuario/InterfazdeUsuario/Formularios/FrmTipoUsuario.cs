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
    public partial class FrmTipoUsuario : MetroFramework.Forms.MetroForm
    {
        public FrmTipoUsuario()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmStudent student = new FrmStudent();
            this.Hide();
            student.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            FrmExternal external = new FrmExternal();
            this.Hide();
            external.ShowDialog();
        }
    }
}
