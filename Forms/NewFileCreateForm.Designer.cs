namespace Indicon.Api.EplanCommon.Forms
{
    partial class NewFileCreateForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.FinishCancelControl = new Engine.Forms.UserControls.FinishCancelControl();
            this.FileBrowseControl = new Engine.Forms.UserControls.FileBrowseControl();
            this.NameEntryControl = new Engine.Forms.UserControls.NameEntryDisplayControl();
            this.SuspendLayout();
            // 
            // FinishCancelControl
            // 
            this.FinishCancelControl.Location = new System.Drawing.Point(302, 84);
            this.FinishCancelControl.Name = "FinishCancelControl";
            this.FinishCancelControl.Size = new System.Drawing.Size(155, 30);
            this.FinishCancelControl.TabIndex = 5;
            // 
            // FileBrowseControl
            // 
            this.FileBrowseControl.Location = new System.Drawing.Point(12, 48);
            this.FileBrowseControl.Name = "FileBrowseControl";
            this.FileBrowseControl.Size = new System.Drawing.Size(445, 30);
            this.FileBrowseControl.TabIndex = 6;
            // 
            // NameEntryControl
            // 
            this.NameEntryControl.Location = new System.Drawing.Point(12, 12);
            this.NameEntryControl.Name = "NameEntryControl";
            this.NameEntryControl.Size = new System.Drawing.Size(365, 30);
            this.NameEntryControl.TabIndex = 7;
            // 
            // EplanProjectNewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 123);
            this.Controls.Add(this.NameEntryControl);
            this.Controls.Add(this.FileBrowseControl);
            this.Controls.Add(this.FinishCancelControl);
            this.Name = "EplanProjectNewForm";
            this.Text = "EplanProjectNewForm";
            this.ResumeLayout(false);

        }

        #endregion

        internal Engine.Forms.UserControls.FinishCancelControl FinishCancelControl;
        internal Engine.Forms.UserControls.FileBrowseControl FileBrowseControl;
        internal Engine.Forms.UserControls.NameEntryDisplayControl NameEntryControl;
    }
}