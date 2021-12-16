using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICT365_Assignment1
{
    public partial class BaseEventForm : Form
    {
        protected PictureBox eventIcon;
        protected bool eventCreated;
        public BaseEventForm()
        {
            eventCreated = false;
            InitializeComponent();
        }

        public BaseEventForm(PictureBox eventIconIn)
        {
            eventCreated = false;
            eventIcon = eventIconIn;
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (eventIcon != null)
            {
                if (!eventCreated)
                {
                    eventIcon.Dispose();
                }
            }
        }

        protected void BaseEventForm_Load(object sender, EventArgs e)
        {

        }

        protected void CancelEventButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateEventButton_Click(object sender, EventArgs e)
        {

        }
    }
}
