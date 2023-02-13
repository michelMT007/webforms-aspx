using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebSistemas
{
    public partial class AbrirModal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ModalTesteAbrir.Visible = false;
            txtAnoCodigo.Text = DateTime.Now.Year.ToString();
        }

        protected void btnModal_Click(object sender, EventArgs e)
        {
            txtBtn.Text = "O botão foi clicado com sucesso!";
    
        }
    

        protected void chkModal_CheckedChanged(object sender, EventArgs e)
        {
            txtMensagemChk.Text = string.Empty;
            if (chkModal.Checked == true)
            {
                ModalTesteAbrir.Visible = true;

                txtMensagemChk.Text = "O check Box foi marcado com sucesso!";
            }
                
        }

        protected void btnSalvarCodigo_Click(object sender, EventArgs e)
        {
            if (chkModal.Checked ==true) {
                var ano = txtAnoCodigo.Text;
                var codigo = txtCodigoInicial.Text;
                txtMostrarCodigo.Text = $"{codigo}/{ano}";
            }
            
        }
    }
}