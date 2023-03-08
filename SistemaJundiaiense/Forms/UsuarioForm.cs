using SistemaJundiaiense.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaJundiaiense.Forms
{
    /// <summary>
    /// Form para a criação de usuário
    /// </summary>
    public partial class UsuarioForm : Form
    {
        /// <summary>
        /// Iniciliza os componentes
        /// </summary>
        public UsuarioForm()
        {
            InitializeComponent();
        }

        private void UsuarioForm_Load(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton_Click(object sender, EventArgs e)
        {
            UsuarioRepositorio.InserirUsuario(txtLogin.Text, txtSenha.Text, txtNome.Text, txtEmail.Text, comboBoxGrupo.Text, checkInativo.Checked == true ? "S" : "N");
        }
    }
}
