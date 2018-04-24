using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WsCep
{
    using CEPService;
    public partial class frmConsultar : Form
    {
      

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            //fechar formulario
            this.Close();
        }

        public frmConsultar()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            using (var servico = new AtendeClienteClient())
            {
                //guarda o cep de acordo com o campo no formulario
                var response = servico.consultaCEP(txtCep.Text);


                //set do endereço no formulario
                txtEndereco.Text = response.end;
                //set do bairro no formulario
                txtBairro.Text = response.bairro;
                //ser da cidade no formulario
                txtCidade.Text = response.cidade;
                //set do estado no formulario
                txtEstado.Text = response.uf;

            }

            
        }
    }
}
