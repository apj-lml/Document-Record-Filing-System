using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilingSystem2
{
    public partial class reportViewerForm : Form
    {
        public reportViewerForm()
        {
            InitializeComponent();
        }

        private void reportViewerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_filingsystemDataSetForReports1.tbl_file' table. You can move, or remove it, as needed.
            this.tbl_fileTableAdapter.Fill(this.db_filingsystemDataSetForReports1.tbl_file);

            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            setup.Landscape = true;
            this.reportViewer1.SetPageSettings(setup);

            this.reportViewer1.RefreshReport();
        }
    }
}
