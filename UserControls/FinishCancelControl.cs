using Engine.Forms.Interfaces;

namespace Engine.Forms.UserControls
{
    public partial class FinishCancelControl : UserControl, IUserControlAvailability
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler FinishClicked = delegate { };
        public EventHandler CancelClicked = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnFinishClicked(EventArgs oArgs)
        {
            EventHandler oHandler = FinishClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnCancelClicked(EventArgs oArgs)
        {
            EventHandler oHandler = CancelClicked;
            oHandler?.Invoke(this, oArgs);
        }
        public FinishCancelControl()
        {
            InitializeComponent();
        }
        private void Finish_Click(object oSender, EventArgs oArgs)
        {
            OnFinishClicked(EventArgs.Empty);
        }
        private void Cancel_Click(object oSender, EventArgs oArgs)
        {
            OnCancelClicked(EventArgs.Empty);
        }
        public void EnableAll()
        {
            FinishButton.Enabled = true;
            CancelButton.Enabled = true;
        }
        public void DisableAll()
        {
            FinishButton.Enabled = false;
            CancelButton.Enabled = false;
        }
        public void ResetAll()
        {
            // There is nothing to reset for this user control
        }
    }
}
