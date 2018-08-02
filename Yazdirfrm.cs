using System;

using System.Windows.Forms;

namespace YollukProgrami
{
    public partial class Yazdirfrm : Form
    {
        public Yazdirfrm()
        {
            InitializeComponent();
        }

        private void Yazdirfrm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vtDataSet.yolluk' table. You can move, or remove it, as needed.
            this.yollukTableAdapter.Fill(this.vtDataSet.yolluk);

            this.reportViewer1.RefreshReport();
        }
    }
}
