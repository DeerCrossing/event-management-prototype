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
    public partial class EventSelect : Form
    {
        bool formCreated;
        PictureBox newEventIcon;
        public EventSelect()
        {
            formCreated = false;
            InitializeComponent();
        }

        public EventSelect(PictureBox newEventIn)
        {
            formCreated = false;
            newEventIcon = newEventIn;
            InitializeComponent();
        }

        protected override void OnClosed(EventArgs e)
        {
            if (!formCreated)
            {
                if (newEventIcon != null)
                {
                    newEventIcon.Dispose();
                }
            }
        }

        private void EventSelectList_SelectedIndexChanged(object sender, EventArgs e)
        {

            formCreated = true;
            EventType selectedEvent = (EventType)EventSelectList.SelectedIndex;
            Console.WriteLine(EventSelectList.SelectedIndex);
            Console.WriteLine(selectedEvent);

            //Create New Form
            BaseEventForm newEventForm;

            switch(selectedEvent)
            {
                case EventType.None:
                    newEventIcon.Dispose();
                    break;

                case EventType.FacebookUpdate:
                    newEventForm = new Forms.FacebookEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;

                case EventType.Tweet:
                    newEventForm = new Forms.TweetEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;

                case EventType.Photo:
                    newEventForm = new Forms.PhotoEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;

                case EventType.Video:
                    newEventForm = new Forms.VideoEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;
                
                case EventType.Activity:
                    newEventForm = new Forms.ActivityEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;

                case EventType.Purchase:
                    newEventForm = new Forms.PurchaseEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;

                case EventType.General:
                    newEventForm = new Forms.GeneralEventForm(newEventIcon);
                    newEventForm.Activate();
                    newEventForm.Show();
                    break;
            }

            //Close This Form
            Close();
        }

        private void EventSelect_Load(object sender, EventArgs e)
        {

        }
    }
}
