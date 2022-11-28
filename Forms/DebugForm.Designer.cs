namespace Engine.Forms.Forms
{
    partial class DebugForm
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
            this.OutputListView = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // OutputListView
            // 
            this.OutputListView.Location = new System.Drawing.Point(11, 12);
            this.OutputListView.Name = "OutputListView";
            this.OutputListView.Size = new System.Drawing.Size(488, 495);
            this.OutputListView.TabIndex = 0;
            this.OutputListView.UseCompatibleStateImageBehavior = false;
            // 
            // DebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(509, 518);
            this.ControlBox = false;
            this.Controls.Add(this.OutputListView);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DebugForm";
            this.Text = "DebugForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView OutputListView;
    }
}