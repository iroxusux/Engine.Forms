namespace Engine.Forms.UserControls
{
    public partial class ComboBoxControl : UserControl
    {
        private string[] Names = Array.Empty<string>();
        private object[] Objects = Array.Empty<object>();
        public ComboBoxControl()
        {
            InitializeComponent();
        }
        public void AddItem(object oObject, string sName)
        {
            // Do the strings
            string[] aNewString = new string[Names.Length + 1];
            Names.CopyTo(aNewString, 0);
            aNewString[aNewString.Length -1] = sName;
            Names = new string[aNewString.Length];
            aNewString.CopyTo(Names, 0);
            // Do the objects
            object[] aNewObject = new object[Objects.Length + 1];
            Objects.CopyTo(aNewObject, 0);
            aNewObject[aNewObject.Length-1] = oObject;
            Objects = new object[aNewObject.Length];
            aNewObject.CopyTo(Objects, 0);
            // Add to list
            ComboBox.Items.Add(Names.Last());
        }
        public void RemoveItem(object oObject)
        {
            for(int i = 0; i < Objects.Length; i++)
            {
                if(oObject == Objects[i])
                {
                    // Do the objects
                    object[] aNewObject = new object[Objects.Length - 1];
                    Array.Copy(Objects, 0, aNewObject, 0, i - 1);
                    Array.Copy(Objects, i + 1, aNewObject, i, aNewObject.Length - i);
                    Objects = new object[aNewObject.Length];
                    aNewObject.CopyTo(Objects, 0);
                    // Do the strings
                    string[] aNewString = new string[Names.Length - 1];
                    Array.Copy(Names, 0, aNewString, 0, i - 1);
                    Array.Copy(Objects, i + 1, aNewString, i, aNewString.Length - i);
                    Names = new string[aNewString.Length];
                    aNewString.CopyTo(Names, 0);
                    // Remove from list
                    ComboBox.Items.Remove(Names[i]);
                }
            }
        }
        public void AddRange(object[] oObjects, string[] sNames)
        {
            if (oObjects.Length != sNames.Length) throw new InvalidCastException();
            for(int i = 0; i < oObjects.Length; i++)
            {
                AddItem(oObjects[i], sNames[i]);
            }
        }
        public void RemoveRange(object[] oObjects)
        {
            for(int i = 0; i < oObjects.Length; i++)
            {
                RemoveItem(oObjects[i]);
            }
        }
        public void Clear()
        {
            Names = Array.Empty<string>();
            Objects = Array.Empty<object>();
            ComboBox.Items.Clear();
        }
        public object? GetSelectedObject()
        {
            if (Objects.Length <= 0) return null;
            try
            {
                return Objects[ComboBox.SelectedIndex];
            }
            catch (ArgumentOutOfRangeException oE)
            {
                MessageBox.Show($"Combo Box Selection Error:\n{oE.Message}", "Combo Box Get Selected Object Failure");
                return null;
            }
        }
        public void SetSelectedIndex(object oObject)
        {
            for(int i = 0; i < Objects.Length; i++)
            {
                if(oObject == Objects[i])
                {
                    ComboBox.SelectedIndex = i;
                    return;
                }
            }
            ComboBox.SelectedIndex = -1;
        }
    }
}
