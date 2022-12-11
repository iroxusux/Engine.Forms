using Engine.Forms.Interfaces;

namespace Engine.Forms.UserControls
{
    public partial class AddDeleteControl : UserControl, IUserControlAvailability
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler AddClicked = delegate { };
        public EventHandler DeleteClicked = delegate { };
        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnAddClicked(EventArgs oArgs)
        {
            EventHandler oHandler = AddClicked;
            oHandler?.Invoke(this, oArgs);
        }
        private void OnDeleteClicked(EventArgs oArgs)
        {
            EventHandler oHandler = DeleteClicked;
            oHandler?.Invoke(this, oArgs);
        }
        public AddDeleteControl()
        {
            InitializeComponent();
        }
        private void Add_Click(object oSender, EventArgs oArgs)
        {
            OnAddClicked(EventArgs.Empty);
        }
        private void Delete_Click(object oSender, EventArgs oArgs)
        {
            OnDeleteClicked(EventArgs.Empty);
        }
        public void EnableAll()
        {
            AddButton.Enabled = true;
            DeleteButton.Enabled = true;
        }
        public void DisableAll()
        {
            AddButton.Enabled = false;
            DeleteButton.Enabled = false;
        }
        public void ResetAll()
        {
            // There is nothing to reset for this user control
        }
    }
}
