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
    public partial class RelatorioDeUsuarios : Form
    {
        public RelatorioDeUsuarios()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.ReportPessoas reportPessoas = new Forms.ReportPessoas();
            reportPessoas.Show();
        }
    }
}
