using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class DisplayVideoEvent : ICT365_Assignment1.Forms.VideoEventForm
    {
        protected int eventID;
        public DisplayVideoEvent()
        {
            InitializeComponent();
        }

        public DisplayVideoEvent(int eventIDIn)
        {
            eventID = eventIDIn;
            EventVideo data = (EventVideo)ManagerSingleton.Instance.Events.GetEventByID(eventID);
            NameBox.Text = data.GetName();
            CommentBox.Text = data.GetComment();
            FilePathBox.Text = data.GetFilepath();
            DurationBox.Text = data.GetDuration().ToString();
            LatitudeTextBox.Text = data.GetLocation().Latitude.ToString();
            LongitudeTextBox.Text = data.GetLocation().Longitude.ToString();
            dateTime.Value = data.GetDateTime();
            CreateEventButton.Text = "Delete Event";
        }

        protected override void CreateEventButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<PictureBox, int> kv in ManagerSingleton.Instance.IconList)
            {
                if (kv.Value == eventID)
                {
                    PictureBox key = kv.Key;
                    ManagerSingleton.Instance.IconList.Remove(key);
                    key.Dispose();
                    ManagerSingleton.Instance.Events.RemoveEvent(eventID);
                    break;
                }
            }
            Close();
        }

        private void DisplayVideoEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
