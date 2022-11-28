using Engine.Forms.Interfaces;

namespace Engine.Forms.UserControls
{
    public partial class StartStopControl : UserControl, IUserControlAvailability
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler StartClicked = delegate { };
        public EventHandler StopClicked = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnStartClicked(EventArgs oArgs)
        {
            EventHandler oHandler = StartClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnStopClicked(EventArgs oArgs)
        {
            EventHandler oHandler = StopClicked;
            oHandler?.Invoke(this, oArgs);
        }
        public StartStopControl()
        {
            InitializeComponent();
        }
        private void Start_Click(object oSender, EventArgs oArgs)
        {
            OnStartClicked(EventArgs.Empty);
        }
        private void Stop_Click(object oSender, EventArgs oArgs)
        {
            OnStopClicked(EventArgs.Empty);
        }
        public void EnableAll()
        {
            StartButton.Enabled = true;
            StopButton.Enabled = true;
        }
        public void DisableAll()
        {
            StartButton.Enabled = false;
            StopButton.Enabled = false;
        }
        public void ResetAll()
        {
            // There is nothing to reset for this user control
        }
    }
}
