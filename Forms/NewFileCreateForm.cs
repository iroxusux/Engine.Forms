using Engine.IO;

namespace Indicon.Api.EplanCommon.Forms
{
    public partial class NewFileCreateForm : Form
    {
        /// <summary>
        /// Event Delegates
        /// </summary>
        public EventHandler BrowseClicked = delegate { };
        public EventHandler FinishClicked = delegate { };
        public EventHandler CancelClicked = delegate { };
        /// <summary>
        ///  Event Delegation Methods
        /// </summary>
        private void OnBrowseClicked(object? oSender, EventArgs oArgs)
        {
            EventHandler oHandler = BrowseClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnFinishClicked(object? oSender, EventArgs oArgs)
        {
            EventHandler oHandler = FinishClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnCancelClicked(object? oSender, EventArgs oArgs)
        {
            EventHandler oHandler = CancelClicked;
            oHandler?.Invoke(this, oArgs);
        }
        public NewFileCreateForm()
        {
            InitializeComponent();
            FileBrowseControl.BrowseClicked += new EventHandler(OnBrowseClicked);
            FinishCancelControl.FinishClicked += new EventHandler(OnFinishClicked);
            FinishCancelControl.FinishClicked += new EventHandler(OnCancelClicked);
            NameEntryControl.TextChanged += new EventHandler(EnableFinish);
            FileBrowseControl.TextChanged += new EventHandler(EnableFinish);

            BrowseClicked += new EventHandler(OnBrowseClickedLocal);

            FinishCancelControl.FinishButton.Enabled = false;
        }
        private void OnBrowseClickedLocal(object? oSender, EventArgs oArgs)
        {
            FileBrowseControl.LocationTextBox.Text = IoManager.GetDirectoryPath();
        }
        private void EnableFinish(object? oSender, EventArgs oArgs)
        {
            FinishCancelControl.FinishButton.Enabled = !String.IsNullOrWhiteSpace(NameEntryControl.NameTextBox.Text) && !String.IsNullOrWhiteSpace(FileBrowseControl.LocationTextBox.Text);
        }
    }
}
