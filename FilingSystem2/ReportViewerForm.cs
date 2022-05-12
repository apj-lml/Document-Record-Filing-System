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
        string _cbFolderValue;
        public reportViewerForm(String CbFolderValue)
        {
            InitializeComponent();
            _cbFolderValue = CbFolderValue;
        }

        private void reportViewerForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_filingsystemDataSetForReports1.tbl_file' table. You can move, or remove it, as needed.
            MyConnectionString myConnectionString = new MyConnectionString();

            this.tbl_fileTableAdapter.Connection.Close();
            this.tbl_fileTableAdapter.Connection = myConnectionString.MyConnection();
            this.tbl_fileTableAdapter.Connection.Open();

            if (_cbFolderValue == "All")
            {
                this.tbl_fileTableAdapter.Fill(this.db_filingsystemDataSetForReports1.tbl_file);

            }
            else
            {
                this.tbl_fileTableAdapter.FillByFolderId(this.db_filingsystemDataSetForReports1.tbl_file, int.Parse(_cbFolderValue));

            }


            var setup = this.reportViewer1.GetPageSettings();
            setup.Margins = new System.Drawing.Printing.Margins(1, 1, 1, 1);
            //setup.PaperSize = new System.Drawing.Printing.PaperSize("My A4 Size", 3508, 2480);
            setup.Landscape = true;
            this.reportViewer1.SetPageSettings(setup);

            this.reportViewer1.RefreshReport();

           

        }
    }
}
