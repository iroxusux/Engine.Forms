namespace Engine.Forms.UserControls
{
    partial class FileBrowseControl
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
            this.LocationLabel = new System.Windows.Forms.Label();
            this.LocationTextBox = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LocationLabel
            // 
            this.LocationLabel.AutoSize = true;
            this.LocationLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationLabel.Location = new System.Drawing.Point(0, 3);
            this.LocationLabel.Name = "LocationLabel";
            this.LocationLabel.Size = new System.Drawing.Size(72, 21);
            this.LocationLabel.TabIndex = 0;
            this.LocationLabel.Text = "Location:";
            // 
            // LocationTextBox
            // 
            this.LocationTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocationTextBox.Location = new System.Drawing.Point(77, 0);
            this.LocationTextBox.Name = "LocationTextBox";
            this.LocationTextBox.ReadOnly = true;
            this.LocationTextBox.Size = new System.Drawing.Size(288, 29);
            this.LocationTextBox.TabIndex = 1;
            this.LocationTextBox.TextChanged += new System.EventHandler(this.TextChanged_Event);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BrowseButton.Location = new System.Drawing.Point(370, 0);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(75, 30);
            this.BrowseButton.TabIndex = 2;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.Browse_Click);
            // 
            // FileBrowseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.LocationTextBox);
            this.Controls.Add(this.LocationLabel);
            this.Name = "FileBrowseControl";
            this.Size = new System.Drawing.Size(445, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LocationLabel;
        public TextBox LocationTextBox;
        public Button BrowseButton;
    }
}
