namespace Engine.Forms.UserControls
{
    public partial class NameEntryDisplayControl : UserControl
    {
        public EventHandler<KeyEventArgs> TextKeyDown = delegate { };
        public EventHandler TextChanged = delegate { };
        public NameEntryDisplayControl()
        {
            InitializeComponent();
        }

        private void OnTextKey_Down(object oSender, KeyEventArgs oArgs)
        {
            EventHandler<KeyEventArgs> oHandler = TextKeyDown;
            oHandler?.Invoke(this, oArgs);
        }

        private void TextChanged_Event(object oSender, EventArgs oArgs)
        {
            EventHandler oHandler = TextChanged;
            oHandler?.Invoke(this, oArgs);
        }
    }
}
