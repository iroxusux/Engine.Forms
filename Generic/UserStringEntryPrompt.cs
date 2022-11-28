using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Forms.Generic
{
    public static class UserStringEntryPrompt
    {
        public static string ShowDialog(string sText, string sCaption)
        {
            Form oPromptForm = new()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = sCaption,
                StartPosition = FormStartPosition.CenterScreen,
            };
            Label oTextLabel = new() { Left = 50, Top = 20, Text = sText };
            TextBox oTextBox = new() { Left = 50, Top = 50, Width = 400, TabIndex = 0, TabStop = true };
            Button oConfirmation = new() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK, TabIndex = 1, TabStop = true };
            oConfirmation.Click += (sender, e) => { oPromptForm.Close(); };
            oPromptForm.Controls.Add(oTextBox);
            oPromptForm.Controls.Add(oTextLabel);
            oPromptForm.Controls.Add(oConfirmation);
            oPromptForm.AcceptButton = oConfirmation;

            return oPromptForm.ShowDialog() == DialogResult.OK ? oTextBox.Text : string.Empty;
        }
    }
}
