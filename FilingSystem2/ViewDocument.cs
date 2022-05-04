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
            var folder_tag_color = dgv.CurrentRow.Cells[6].Value;
            var file_box = dgv.CurrentRow.Cells[7].Value;
            var file_box_tag_color = dgv.CurrentRow.Cells[8].Value;
            var filed_by = dgv.CurrentRow.Cells[9].Value;
            var date_filed = dgv.CurrentRow.Cells[10].Value;

            tbID.Text = id.ToString();
            tbCode.Text = code.ToString();
            tbFolder.Text = folder.ToString();

            tbFileBox.Text = file_box.ToString();
            tbFiledBy.Text = filed_by.ToString();

            tbSubject.Text = subject.ToString();
            tbParticulars.Text = particulars.ToString();
            tbRemarks.Text = remarks.ToString();

            tbFolderTagColor.Text = folder_tag_color.ToString();
            tbFileBoxTagColor.Text = file_box_tag_color.ToString();

            tbDateFiled.Text = date_filed.ToString();
        }

        private void btnEditDocument_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EditDocument(_dashboardForm).ShowDialog();
        }
    }
}
