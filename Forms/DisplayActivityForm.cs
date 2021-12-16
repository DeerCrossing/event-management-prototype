using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class DisplayActivityForm : ICT365_Assignment1.Forms.ActivityEventForm
    {
        protected int eventID;
        public DisplayActivityForm()
        {
            InitializeComponent();
        }

        public DisplayActivityForm(int eventIDIn)
        {
            eventID = eventIDIn;
            EventActivity data = (EventActivity)ManagerSingleton.Instance.Events.GetEventByID(eventID);
            NameBox.Text = data.GetName();
            CommentBox.Text = data.GetComment();
            ActivityNameBox.Text = data.GetActivity();
            LatitudeTextBox.Text = data.GetLocation().Latitude.ToString();
            LongitudeTextBox.Text = data.GetLocation().Longitude.ToString();
            dateTime.Value = data.GetDateTime();
            DurationBox.Text = data.GetDuration().ToString();
            CreateEventButton.Text = "Delete Event";
        }

        protected override void OnClosed(EventArgs e)
        {
        
        }

        protected override void CreateEventButton_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<PictureBox, int> kv in ManagerSingleton.Instance.IconList)
            {
                if(kv.Value == eventID)
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

        private void DisplayActivityForm_Load(object sender, EventArgs e)
        {

        }
    }
}
