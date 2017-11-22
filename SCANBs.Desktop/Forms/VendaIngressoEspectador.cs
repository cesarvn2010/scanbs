using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCANBs.Desktop.Forms
{
    public partial class VendaIngressoEspectador : Form
    {
        public VendaIngressoEspectador()
        {
            InitializeComponent();
        }

        private void IngressoEspectador_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
    }
}
