using System.Net;
using System.Security.Cryptography;

namespace Engine.Forms.Forms
{
    public partial class DebugForm : Form
    {
        public DebugForm()
        {
            InitializeComponent();
            OutputListView.View = View.Details;
            OutputListView.LabelEdit = false;
            OutputListView.AllowColumnReorder = false;
            OutputListView.GridLines = true;
            OutputListView.Columns.Add("Message", -1, HorizontalAlignment.Left);
        }
        public void Write(string sMessage)
        {
            if (IsDisposed) return;
            if (InvokeRequired)
            {
                this.BeginInvoke((MethodInvoker)delegate
                {
                    Write(sMessage);
                });
                return;
            }
            OutputListView.Items.Add(new ListViewItem(sMessage));
            OutputListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            OutputListView.Items[OutputListView.Items.Count - 1].EnsureVisible();
        }
    }
}
