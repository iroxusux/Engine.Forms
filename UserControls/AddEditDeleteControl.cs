using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Engine.Forms.UserControls
{
    public partial class AddEditDeleteControl : UserControl
    {
        /// <summary>
        ///  Event Delegates
        /// </summary>
        public EventHandler AddClicked = delegate { };
        public EventHandler EditClicked = delegate { };
        public EventHandler DeleteClicked = delegate { };

        /// <summary>
        /// Event Delegation Methods
        /// </summary>
        private void OnAddClicked(EventArgs args)
        {
            EventHandler handler = AddClicked;
            handler?.Invoke(this, args);
        }
        private void OnEditClicked(EventArgs args)
        {
            EventHandler handler = EditClicked;
            handler?.Invoke(this, args);
        }
        private void OnDeleteClicked(EventArgs args)
        {
            EventHandler handler = DeleteClicked;
            handler?.Invoke(this, args);
        }
        private void Add_Click(object sender, EventArgs e)
        {
            OnAddClicked(EventArgs.Empty);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            OnEditClicked(EventArgs.Empty);
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            OnDeleteClicked(EventArgs.Empty);
        }

        public AddEditDeleteControl()
        {
            InitializeComponent();
        }
    }
}
