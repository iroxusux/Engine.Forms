using Engine.Forms.Events;

namespace Engine.Forms.Generic
{
    public partial class PropertyListEditControl : UserControl
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler NewPropertyClicked = delegate { };
        public EventHandler<ListViewEventArgs> DeletePropertyClicked = delegate { };
        public EventHandler<ListViewEventArgs> EditPropertyClicked = delegate { };
        public EventHandler<ListViewEventArgs> NewItemSelected = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnNewPropertyClicked(EventArgs oArgs)
        {
            EventHandler oHandler = NewPropertyClicked;
            oHandler?.Invoke(this, EventArgs.Empty);
        }
        private void OnDeletePropertyClicked(ListViewEventArgs oArgs)
        {
            EventHandler<ListViewEventArgs> oHandler = DeletePropertyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnEditPropertyClicked(ListViewEventArgs oArgs)
        {
            EventHandler<ListViewEventArgs> oHandler = EditPropertyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnNewItemSelected(ListViewEventArgs oArgs)
        {
            EventHandler<ListViewEventArgs> oHandler = NewItemSelected;
            oHandler?.Invoke(this, oArgs);
        }
        private ListViewItem? _SelectedItem { get; set; }
        public ListViewItem? SelectedItem { get { return _SelectedItem; } }
        private ListViewItem? LastItem { get; set; }
        public PropertyListEditControl()
        {
            InitializeComponent();
            NewItemSelected += new EventHandler<ListViewEventArgs>(InternalNewItemSelected);
            createNewToolStripMenuItem.Enabled = true;
            editToolStripMenuItem.Enabled = false;
            deleteToolStripMenuItem.Enabled = false;
        }
        private void NewPropertyButton_Click(object sender, EventArgs e)
        {
            OnNewPropertyClicked(EventArgs.Empty);
        }
        private void DeletePropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyListView.SelectedItems.Count != 1) return;
            ListViewEventArgs oArgs = new() { Item = PropertyListView.SelectedItems[0] };
            OnDeletePropertyClicked(oArgs);
        }
        private void EditPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyListView.SelectedItems.Count != 1) return;
            ListViewEventArgs oArgs = new() { Item = PropertyListView.SelectedItems[0] };
            OnEditPropertyClicked(oArgs);
        }
        public bool AddProperty(string sText, object oTag)
        {
            if (ItemExists(GetItem(oTag))) return false;
            ListViewItem oItem = new() { Text = sText, Name = sText, Tag = oTag };
            PropertyListView.Items.Add(oItem);
            return true;
        }
        public bool DeleteProperty(object oTag)
        {
            ListViewItem? oItem = GetItem(oTag);
            if (oItem != null && PropertyListView.Items.Contains(oItem))
            {
                PropertyListView.Items.Remove(oItem);
                return true;
            }
            return false;
        }
        public bool UpdateProperty(string sText, object oTag)
        {
            ListViewItem? oItem = GetItem(oTag);
            if (oItem == null) return false;
            oItem.Text = sText;
            oItem.Name = sText;
            oItem.Tag = oTag;
            return true;
        }
        private ListViewItem? GetItem(object oTag)
        {
            foreach (ListViewItem oExistingItem in PropertyListView.Items)
            {
                if (oExistingItem.Tag == oTag)
                {
                    return oExistingItem;
                }
            }
            return null;
        }
        private bool ItemExists(ListViewItem? oItem)
        {
            if (oItem == null) return false;
            return PropertyListView.Items.Contains(oItem);
        }
        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            // Not Implimented
        }
        private void MouseDown_Click(object sender, MouseEventArgs e)
        {
            LastItem = _SelectedItem;
            _SelectedItem = null;
        }
        private void MouseUp_Click(object oSender, MouseEventArgs oArgs)
        {
            _SelectedItem = PropertyListView.GetItemAt(oArgs.X, oArgs.Y);
            ListViewEventArgs oNewItemArgs = new() { Item = _SelectedItem };
            if (_SelectedItem != LastItem)
            {
                OnNewItemSelected(oNewItemArgs);
            }
            if (oArgs.Button == MouseButtons.Left)
            {
                LeftMouseClick(oArgs);
            }
            else if (oArgs.Button == MouseButtons.Right)
            {
                RightMouseClick(oArgs);
            }
        }
        private void LeftMouseClick(MouseEventArgs oArgs)
        {
            // Not Implimented
        }
        private void RightMouseClick(MouseEventArgs oArgs)
        {

            Point oPoint = Engine.NativeWinFuncs.NativeWinFuncs.GetCursorPosition();
            DefaultContextMenuStrip.Show(oPoint);
        }
        private void InternalNewItemSelected(object? oSender, ListViewEventArgs oArgs)
        {
            if (oArgs.Item == null)
            {
                createNewToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = false;
                deleteToolStripMenuItem.Enabled = false;
            }
            else
            {
                createNewToolStripMenuItem.Enabled = true;
                editToolStripMenuItem.Enabled = true;
                deleteToolStripMenuItem.Enabled = true;
            }
        }
    }
}
