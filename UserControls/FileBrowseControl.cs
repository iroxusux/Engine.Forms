namespace Engine.Forms.UserControls
{
    public partial class FileBrowseControl : UserControl
    {
        /// <summary>
        /// Event Delegates
        /// </summary>
        public EventHandler BrowseClicked = delegate { };
        public EventHandler TextChanged = delegate { };
        /// <summary>
        ///  Event Delegation Methods
        /// </summary>
        private void OnBrowseClicked(EventArgs oArgs)
        {
            EventHandler oHandler = BrowseClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnTextChanged(EventArgs oArgs)
        {
            EventHandler oHandler = TextChanged;
            oHandler?.Invoke(this, oArgs);
        }
        public FileBrowseControl()
        {
            InitializeComponent();
        }

        private void Browse_Click(object oSender, EventArgs oArgs)
        {
            OnBrowseClicked(oArgs);
        }
        private void TextChanged_Event(object oSender, EventArgs oArgs)
        {
            OnTextChanged(oArgs);
        }
    }
}
