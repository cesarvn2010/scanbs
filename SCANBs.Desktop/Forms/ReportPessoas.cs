using SCANBs.ApplicationImplementation;
using SCANBs.Data;
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
    public partial class ReportPessoas : Form
    {
        public ReportPessoas()
        {
            InitializeComponent();
        }

        private void ReportVendas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
          
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            try
            {
                using (SCANBsEntities db = new SCANBsEntities())
                {
                    PessoaBindingSource.DataSource = db.Pessoa.ToList();
                    reportViewer1.RefreshReport();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Message",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
