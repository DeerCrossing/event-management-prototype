using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class DisplayPhotoEvent : ICT365_Assignment1.Forms.PhotoEventForm
    {
        protected int eventID;
        public DisplayPhotoEvent()
        {
            InitializeComponent();
        }

        public DisplayPhotoEvent(int eventIDIn)
        {
            eventID = eventIDIn;
            EventPhoto data = (EventPhoto)ManagerSingleton.Instance.Events.GetEventByID(eventID);
            NameBox.Text = data.GetName();
            CommentBox.Text = data.GetCaption();
            FilePathTextBox.Text = data.GetFilepath();
            LatitudeTextBox.Text = data.GetLocation().Latitude.ToString();
            LongitudeTextBox.Text = data.GetLocation().Longitude.ToString();
            dateTime.Value = data.GetDateTime();
            CreateEventButton.Text = "Delete Event";
        }
        private void DisplayPhotoEvent_Load(object sender, EventArgs e)
        {

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
    }
}
