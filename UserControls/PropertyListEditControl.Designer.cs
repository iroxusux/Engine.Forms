namespace Engine.Forms.Generic
{
    partial class PropertyListEditControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PropertyListEditControl));
            this.PropertyToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewPropertyButton = new System.Windows.Forms.ToolStripButton();
            this.EditPropertyButton = new System.Windows.Forms.ToolStripButton();
            this.DeletePropertyButton = new System.Windows.Forms.ToolStripButton();
            this.PropertyListView = new System.Windows.Forms.ListView();
            this.DefaultContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PropertyToolStrip.SuspendLayout();
            this.DefaultContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PropertyToolStrip
            // 
            this.PropertyToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewPropertyButton,
            this.EditPropertyButton,
            this.DeletePropertyButton});
            this.PropertyToolStrip.Location = new System.Drawing.Point(0, 0);
            this.PropertyToolStrip.Name = "PropertyToolStrip";
            this.PropertyToolStrip.Size = new System.Drawing.Size(479, 25);
            this.PropertyToolStrip.TabIndex = 3;
            this.PropertyToolStrip.Text = "PropertyListToolStrip";
            // 
            // NewPropertyButton
            // 
            this.NewPropertyButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewPropertyButton.Image = ((System.Drawing.Image)(resources.GetObject("NewPropertyButton.Image")));
            this.NewPropertyButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewPropertyButton.Name = "NewPropertyButton";
            this.NewPropertyButton.Size = new System.Drawing.Size(23, 22);
            this.NewPropertyButton.Text = "New Property";
            this.NewPropertyButton.Click += new System.EventHandler(this.NewPropertyButton_Click);
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
            this.DeletePropertyButton.Click += new System.EventHandler(this.DeletePropertyButton_Click);
            // 
            // PropertyListView
            // 
            this.PropertyListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PropertyListView.Location = new System.Drawing.Point(0, 25);
            this.PropertyListView.Name = "PropertyListView";
            this.PropertyListView.Size = new System.Drawing.Size(479, 548);
            this.PropertyListView.TabIndex = 4;
            this.PropertyListView.UseCompatibleStateImageBehavior = false;
            this.PropertyListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Mouse_Click);
            this.PropertyListView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MouseDown_Click);
            this.PropertyListView.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MouseUp_Click);
            // 
            // DefaultContextMenuStrip
            // 
            this.DefaultContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.DefaultContextMenuStrip.Name = "contextMenuStrip1";
            this.DefaultContextMenuStrip.Size = new System.Drawing.Size(136, 70);
            // 
            // createNewToolStripMenuItem
            // 
            this.createNewToolStripMenuItem.Name = "createNewToolStripMenuItem";
            this.createNewToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.createNewToolStripMenuItem.Text = "Create New";
            this.createNewToolStripMenuItem.Click += new System.EventHandler(this.NewPropertyButton_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.EditPropertyButton_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.DeletePropertyButton_Click);
            // 
            // PropertyListEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PropertyListView);
            this.Controls.Add(this.PropertyToolStrip);
            this.Name = "PropertyListEditControl";
            this.Size = new System.Drawing.Size(479, 573);
            this.PropertyToolStrip.ResumeLayout(false);
            this.PropertyToolStrip.PerformLayout();
            this.DefaultContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip PropertyToolStrip;
        private ToolStripButton NewPropertyButton;
        private ToolStripButton EditPropertyButton;
        private ToolStripButton DeletePropertyButton;
        private ContextMenuStrip DefaultContextMenuStrip;
        private ToolStripMenuItem createNewToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem;
        public ListView PropertyListView;
    }
}
