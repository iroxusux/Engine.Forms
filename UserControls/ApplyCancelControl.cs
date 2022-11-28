using Engine.Forms.Interfaces;

namespace Engine.Forms.UserControls
{
    public partial class ApplyCancelControl : UserControl, IUserControlAvailability
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler ApplyClicked = delegate { };
        public EventHandler CancelClicked = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnApplyClicked(EventArgs oArgs)
        {
            EventHandler oHandler = ApplyClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnCancelClicked(EventArgs oArgs)
        {
            EventHandler oHandler = CancelClicked;
            oHandler?.Invoke(this, oArgs);
        }
        public ApplyCancelControl()
        {
            InitializeComponent();
        }
        private void Apply_Click(object oSender, EventArgs oArgs)
        {
            OnApplyClicked(EventArgs.Empty);
        }
        private void Cancel_Click(object oSender, EventArgs oArgs)
        {
            OnCancelClicked(EventArgs.Empty);
        }
        public void EnableAll()
        {
            ApplyButton.Enabled = true;
            CancelButton.Enabled = true;
        }
        public void DisableAll()
        {
            ApplyButton.Enabled = false;
            CancelButton.Enabled = false;
        }
        public void ResetAll()
        {
            // There is nothing to reset for this user control
        }
    }
}
