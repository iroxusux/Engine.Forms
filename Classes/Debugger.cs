using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Forms.Forms;

namespace Engine.Forms.Classes
{
    public static class Debugger
    {
        private static bool _Loaded = false;
        private static DebugForm Form;
        public static void Load()
        {
            Form = new DebugForm();
            Form.Show();
            _Loaded = true;
            Write("Debugger loaded...");
        }
        public static void Unload()
        {
            Form.Close();
            _Loaded = false;
        }
        public static void Write(string sMessage)
        {
            if (!_Loaded) return;
            Form.Write(sMessage);
        }
    }
}
