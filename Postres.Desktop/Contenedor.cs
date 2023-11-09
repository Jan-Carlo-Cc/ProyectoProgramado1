using Postres.Core.CasosDeUso;
using Postres.Desktop.Forms;
using System;
using System.Windows.Forms;

namespace Postres.Desktop
{
    public partial class Contenedor : Form
    {
        private readonly RepositorioDeMenu _repositorioDePostres;
        public Contenedor( RepositorioDeMenu repositorioDePostres)
        {
            InitializeComponent();
            _repositorioDePostres = repositorioDePostres;
        }

      
        private void PostresButtom_Click(object sender, EventArgs e)
        {
            ListaClientes postresView = new ListaClientes(this, _repositorioDePostres);
            CargarFormulario(postresView);
        }

        // para cambiar entre las vistas del Layout
        public void CargarFormulario(Form form)
        {
            if(this.PrincipalPanel.Controls.Count > 0)
            {
                PrincipalPanel.Controls.RemoveAt(0);
                Form parcial = form as Form;
                parcial.TopLevel = false;
                parcial.Dock = DockStyle.Fill;  
                PrincipalPanel.Controls.Add(parcial);   
                PrincipalPanel.Tag = parcial;
                parcial.Show();

            }
            
        }

        private void Contenedor_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
