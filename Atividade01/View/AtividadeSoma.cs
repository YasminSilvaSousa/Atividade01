using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade01.View
{
    public partial class AtividadeSoma : Form
    {
        public AtividadeSoma()
        {
            InitializeComponent();
        }

        private void btn_Executar_Click(object sender, EventArgs e)
        {
            int valor1 = Convert.ToInt16(txb_PrimeiroNumero.Text);
            int valor2 = Convert.ToInt16(txb_SegundoNumero.Text);
            int soma = valor1 + valor2;

            lbl_Mensagem.Text = soma.ToString();

        }
    }
}
