
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bussines;



namespace Administracion_de_contactos
{
    public  partial class frm_Agregar : Form
    {

     private readonly agregarcontacto cont;

        public int? reposeditar;
        public frm_Agregar()
        {
            cont = new agregarcontacto();
            InitializeComponent();
        }

       

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            add();


            
            
        }

       
        private void add()
        {
            repos2 Repos2 = new repos2();

            Repos2.nombre2 = txt_nombre.Text;
            Repos2.apellido = txt_apellido.Text;
            Repos2.direccion = txt_direccion.Text;
            Repos2.numerop = txt_Np.Text;
            Repos2.numerot = txt_nt.Text;

            if (reposeditar != null)
            {
                cont.aditar(reposeditar.Value, Repos2);


            }
            else
            {

                cont.agregar(Repos2);

               
            }
            MessageBox.Show("Se a agregado el contacto");
            frm_contactos newform = new frm_contactos();
            newform.Show();
            this.Close();
        }

        private void frm_Agregar_Load(object sender, EventArgs e)
        {

            if (reposeditar != null)
            {
                var Reditado = cont.Getcontacto(reposeditar.Value);

                txt_nombre.Text = Reditado.nombre2;
                txt_apellido.Text = Reditado.apellido;
                txt_direccion.Text = Reditado.direccion;
                txt_Np.Text = Reditado.numerop;
                txt_nt.Text = Reditado.numerot;


            }
        }
    }
}
