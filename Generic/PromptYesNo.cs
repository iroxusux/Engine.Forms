using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Forms.Generic
{
    public static class PromptYesNo
    {
        public static bool Prompt(string sText, string sTitle)
        {
            var oConfirm = MessageBox.Show(sText, sTitle, MessageBoxButtons.YesNo);
            if (oConfirm == DialogResult.Yes) return true;
            return false;
        }
    }
}
