using Engine.Forms.Events;
using System.Diagnostics;

namespace Engine.Forms.UserControls
{
    public partial class PropertyTreeEditControl : UserControl
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler<TreeNodeEventArgs> NewPropertyClicked = delegate { };
        public EventHandler<TreeNodeEventArgs> RemovePropertyClicked = delegate { };
        public EventHandler<TreeNodeEventArgs> EditPropertyClicked = delegate { };
        public EventHandler<TreeNodeEventArgs> NewItemSelected = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnNewPropertyClicked(TreeNodeEventArgs oArgs)
        {
            EventHandler<TreeNodeEventArgs> oHandler = NewPropertyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnRemovePropertyClicked(TreeNodeEventArgs oArgs)
        {
            EventHandler<TreeNodeEventArgs> oHandler = RemovePropertyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnEditPropertyClicked(TreeNodeEventArgs oArgs)
        {
            EventHandler<TreeNodeEventArgs> oHandler = EditPropertyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnNewItemSelected(TreeNodeEventArgs oArgs)
        {
            EventHandler<TreeNodeEventArgs> oHandler = NewItemSelected;
            oHandler?.Invoke(this, oArgs);
        }
        public PropertyTreeEditControl()
        {
            InitializeComponent();
            NewItemSelected += new EventHandler<TreeNodeEventArgs> (InternalNewItemSelected);
        }
        private void NewPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyTreeView.SelectedNode == null) return;
            TreeNodeEventArgs oArgs = new() { Item = PropertyTreeView.SelectedNode };
            OnNewPropertyClicked(oArgs);
        }
        private void RemovePropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyTreeView.SelectedNode == null) return;
            TreeNodeEventArgs oArgs = new() { Item = PropertyTreeView.SelectedNode };
            OnRemovePropertyClicked(oArgs);
        }
        private void EditPropertyButton_Click(object sender, EventArgs e)
        {
            if (PropertyTreeView.SelectedNode == null) return;
            TreeNodeEventArgs oArgs = new() { Item = PropertyTreeView.SelectedNode };
            OnEditPropertyClicked(oArgs);
        }
        public bool AddProperty(string sText, object oTag, object? oTagParent)
        {
            if (ItemExists(GetNode(oTag))) return false;
            TreeNode oNewNode = new() { Name = sText, Text = sText, Tag = oTag };
            if(oTagParent != null)
            {
                TreeNode? oParentNode = GetNode(oTagParent);
                if (oParentNode != null)
                {
                    oParentNode.Nodes.Add(oNewNode);
                    return true;
                }
            }
            PropertyTreeView.Nodes.Add(oNewNode);
            return true;
        }
        public bool RemoveProperty(object oTag)
        {
            TreeNode? oNode = GetNode(oTag);
            if (oNode != null)
            {
                if(oNode.Parent != null)
                {
                    TreeNode oParentNode = oNode.Parent;
                    oParentNode.Nodes.Remove(oNode);
                }
                else
                {
                    PropertyTreeView.Nodes.Remove(oNode);
                }
                return true;
            }
            return false;
        }
        public bool UpdateProperty(string sText, object oTag)
        {
            TreeNode? oNode = GetNode(oTag);
            if (oNode == null) return false;
            oNode.Text = sText;
            oNode.Name = sText;
            oNode.Tag = oTag;
            return true;
        }
        public void RemoveAllProperties()
        {
            PropertyTreeView.Nodes.Clear();
        }
        private TreeNode? GetNode(object oTag)
        {
            foreach (TreeNode oNode in PropertyTreeView.Nodes)
            {
                TreeNode? oTarget = Search(oTag, oNode);
                if(oTarget != null) return oTarget;
            }
            return null;
        }
        private TreeNode? Search(object oTag, TreeNode oNode)
        {
            if (oNode.Tag == oTag) return oNode;
            foreach(TreeNode oChild in oNode.Nodes)
            {
                TreeNode? oTarget = Search(oTag, oChild);
                if (oTarget != null) return oTarget;
            }
            return null;
        }
        private bool ItemExists(TreeNode? oItem)
        {
            if (oItem == null) return false;
            TreeNode[] oNodes = PropertyTreeView.Nodes.Find(oItem.Name, true);
            Debug.WriteLine(oNodes.Any());
            return oNodes.Any();
        }
        private void InternalNewItemSelected(object? oSender, TreeNodeEventArgs oArgs)
        {
            // Method intentionally left void
        }
        private void CollapseAllButton_Click(object sender, EventArgs e)
        {
            PropertyTreeView.CollapseAll();
        }
        private void ExpandAllButton_Click(object sender, EventArgs e)
        {
            PropertyTreeView.ExpandAll();
        }
    }
}
