using bussines;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Administracion_de_contactos
{
    [Serializable]

   
    public partial class frm_login : Form
    {
        private const string directorionombre = "nombre";
        private const string nombrefilename = "nombre.dat";

        private const string directorionombreusuario = "nombreusuario";
        private const string nombreususariofilename = "nombreusuario.dat";

        private const string directoriocontraseña = "contraseña";
        private const string contraseñafilename = "contraseña.dat";

        private const string directorioconfirmacion = "confirmacion";
        private const string confirmacionfilename = "confirmacion.dat";
        private readonly addusuario addu;
        public frm_login()
        {
            addu = new addusuario();
            InitializeComponent();
        }

        private void btn_registrar_Click(object sender, EventArgs e)
        {
            frm_Registrar newform =  frm_Registrar.instance;
            newform.Show();
            this.Hide();
        }

        private void tb_nombre_TextChanged(object sender, EventArgs e)
        {

        }
        public void login()
        {
            registro Registro = new registro();

            if (tb_nombreU.Text == null )
            {
               if(tb_contraseña.Text == null)
                {

                    MessageBox.Show("Escribe el usuario y la contraseña");
                }

            }
            else
            {
                frm_contactos Contactos = new frm_contactos();
                Contactos.Show();
                this.Hide();


            }











        }

        private void btn_iniciarsesion_Click(object sender, EventArgs e)
        {
            login();
        }

        private void frm_login_Load(object sender, EventArgs e)
        {

        }
    }
}
