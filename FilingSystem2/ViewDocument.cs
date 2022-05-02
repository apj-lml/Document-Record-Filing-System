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
    public partial class ViewDocument : Form
    {

        FindControl fc = new FindControl();
        private readonly dashboardForm _dashboardForm;
        public ViewDocument(dashboardForm dashboardform)
        {
            InitializeComponent();
            _dashboardForm = dashboardform;
        }

        private void ViewDocument_Load(object sender, EventArgs e)
        {
            DataGridView dgv = ((DataGridView)fc.Ctrl(fc.TheForm("dashboardForm"), "dgDocumentsRecords"));
            var id = dgv.CurrentRow.Cells[0].Value;
            var code = dgv.CurrentRow.Cells[1].Value;
            var subject = dgv.CurrentRow.Cells[2].Value;
            var particulars = dgv.CurrentRow.Cells[3].Value;
            var remarks = dgv.CurrentRow.Cells[4].Value;
            var folder = dgv.CurrentRow.Cells[5].Value;
            var file_box = dgv.CurrentRow.Cells[6].Value;
            var filed_by = dgv.CurrentRow.Cells[7].Value;

            tbID.Text = id.ToString();
            tbCode.Text = code.ToString();
            tbFolder.Text = folder.ToString();

            tbFileBox.Text = file_box.ToString();
            tbFiledBy.Text = filed_by.ToString();

            //cbFolder.SelectedText = folder.ToString();
            //cbFolder.SelectedIndex = cbFolder.FindStringExact(folder.ToString());


            tbSubject.Text = subject.ToString();
            tbParticulars.Text = particulars.ToString();
            tbRemarks.Text = remarks.ToString();  
        }

        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditDocument(_dashboardForm).ShowDialog();
        }
    }
}
