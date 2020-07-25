
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
    [Serializable]
    public sealed partial class frm_contactos : Form
    {
        Serialization serialization;

        private readonly agregarcontacto agree;

        private const string directorioelemento = "elemento";
        private const string elementofilename = "elemento.dat";

        public frm_contactos()
        {



            serialization = new Serialization();

            agree = new agregarcontacto();
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Agregar newform = new frm_Agregar();
            newform.Show();
            this.Hide();
        }

        private void contactos_Load(object sender, EventArgs e)
        {
            



            loadcontacto();   
        }
        private void loadcontacto()
        {

            txt_contacto.BeginUpdate();

            txt_contacto.Items.Clear();       
            var contacto = Rcontacto.instancia.elementos;

            foreach (var repos2 in contacto)
            {

                txt_contacto.Items.Add(repos2.cont);
            }


            txt_contacto.EndUpdate();
          


        }

        private void lbox_contacto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       

        private void btn_borrar_Click(object sender, EventArgs e)
        {
            var index = txt_contacto.SelectedIndex;

            if(index < 0)
            {

                MessageBox.Show("Selecciona un contacto");

            }
            else
            {


                agree.borrar(index);

                loadcontacto();
            }
        }

        

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            var index = txt_contacto.SelectedIndex;



            if (index < 0)
            {
                MessageBox.Show("Selecciona un contacto");


            }
            else
            {
                frm_Agregar newform = new frm_Agregar();
                newform.reposeditar = index;
                newform.Show();
                this.Hide();

            }
        }
    }
}
