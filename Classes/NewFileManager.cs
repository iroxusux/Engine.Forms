using Engine.Structs;
using Indicon.Api.EplanCommon.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Forms.Classes
{
    public static class NewFileManager
    {
        public static FileLocation? GetNewFileLocation()
        {
            NewFileCreateForm oForm = new();
            oForm.FinishCancelControl.FinishButton.Click += (oSender, oArgs) => { oForm.Close(); };
            return oForm.ShowDialog() == DialogResult.OK ? new FileLocation
            {
                Name = oForm.NameEntryControl.NameTextBox.Text,
                Directory = oForm.FileBrowseControl.LocationTextBox.Text,
            } : null;
        }
    }
}
