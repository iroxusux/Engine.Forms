namespace Engine.Forms.UserControls
{
    partial class PropertyTreeEditControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyTreeEditControl));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.EditPropertyButton = new System.Windows.Forms.ToolStripButton();
            this.DeletePropertyButton = new System.Windows.Forms.ToolStripButton();
            this.ExpandAllButton = new System.Windows.Forms.ToolStripButton();
            this.CollapseAllButton = new System.Windows.Forms.ToolStripButton();
            this.PropertyTreeView = new System.Windows.Forms.TreeView();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.EditPropertyButton,
            this.DeletePropertyButton,
            this.ExpandAllButton,
            this.CollapseAllButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(392, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "New Property";
            this.toolStripButton1.Click += new System.EventHandler(this.NewPropertyButton_Click);
            // 
            // EditPropertyButton
            // 
            this.EditPropertyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditPropertyButton.Image = ((System.Drawing.Image)(resources.GetObject("EditPropertyButton.Image")));
            this.EditPropertyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditPropertyButton.Name = "EditPropertyButton";
            this.EditPropertyButton.Size = new System.Drawing.Size(23, 22);
            this.EditPropertyButton.Text = "Edit Property";
            this.EditPropertyButton.Click += new System.EventHandler(this.EditPropertyButton_Click);
            // 
            // DeletePropertyButton
            // 
            this.DeletePropertyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeletePropertyButton.Image = ((System.Drawing.Image)(resources.GetObject("DeletePropertyButton.Image")));
            this.DeletePropertyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeletePropertyButton.Name = "DeletePropertyButton";
            this.DeletePropertyButton.Size = new System.Drawing.Size(23, 22);
            this.DeletePropertyButton.Text = "Delete Property";
            this.DeletePropertyButton.Click += new System.EventHandler(this.RemovePropertyButton_Click);
            // 
            // ExpandAllButton
            // 
            this.ExpandAllButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ExpandAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExpandAllButton.Image = ((System.Drawing.Image)(resources.GetObject("ExpandAllButton.Image")));
            this.ExpandAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExpandAllButton.Name = "ExpandAllButton";
            this.ExpandAllButton.Size = new System.Drawing.Size(23, 22);
            this.ExpandAllButton.Text = "toolStripButton4";
            this.ExpandAllButton.Click += new System.EventHandler(this.ExpandAllButton_Click);
            // 
            // CollapseAllButton
            // 
            this.CollapseAllButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.CollapseAllButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CollapseAllButton.Image = ((System.Drawing.Image)(resources.GetObject("CollapseAllButton.Image")));
            this.CollapseAllButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CollapseAllButton.Name = "CollapseAllButton";
            this.CollapseAllButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CollapseAllButton.Size = new System.Drawing.Size(23, 22);
            this.CollapseAllButton.Text = "toolStripButton5";
            this.CollapseAllButton.Click += new System.EventHandler(this.CollapseAllButton_Click);
            // 
            // PropertyTreeView
            // 
            this.PropertyTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyTreeView.Location = new System.Drawing.Point(0, 25);
            this.PropertyTreeView.Name = "PropertyTreeView";
            this.PropertyTreeView.Size = new System.Drawing.Size(392, 290);
            this.PropertyTreeView.TabIndex = 1;
            // 
            // PropertyTreeEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropertyTreeView);
            this.Controls.Add(this.toolStrip1);
            this.Name = "PropertyTreeEditControl";
            this.Size = new System.Drawing.Size(392, 315);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private ToolStripButton EditPropertyButton;
        private ToolStripButton DeletePropertyButton;
        private TreeView PropertyTreeView;
        private ToolStripButton ExpandAllButton;
        private ToolStripButton CollapseAllButton;
    }
}
