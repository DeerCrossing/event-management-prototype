using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class FacebookEventForm : ICT365_Assignment1.BaseEventForm
    {
        public FacebookEventForm()
        {
            InitializeComponent();
        }

        public FacebookEventForm(PictureBox eventIconIn)
        {
            eventIcon = eventIconIn;
            InitializeComponent();
            LatitudeTextBox.Text = eventIcon.Location.X.ToString();
            LongitudeTextBox.Text = eventIcon.Location.Y.ToString();
        }

        private void FacebookEventForm_Load(object sender, EventArgs e)
        {

        }

        protected virtual void CreateEventButton_Click(object sender, EventArgs e)
        {

            Event newEvent = new EventFacebookUpdate();
            EventFacebookUpdate cast;

            newEvent.SetID((uint)ManagerSingleton.Instance.IdCount++);
            newEvent.SetDateTime(dateTime.Value);
            newEvent.SetName(NameBox.Text);
            try
            {
                newEvent.SetLocation(new Location(float.Parse(LatitudeTextBox.Text), float.Parse(LongitudeTextBox.Text)));

            }
            catch
            {
                newEvent.SetLocation(new Location(200, 200));
            }

            newEvent.SetEventType(EventType.FacebookUpdate);
            cast = (EventFacebookUpdate)newEvent;
            cast.SetText(ContentBox.Text);

            eventCreated = true;

            ManagerSingleton.Instance.Events.AddEvent(newEvent);
            ManagerSingleton.Instance.IconList[eventIcon] = newEvent.GetID();

            Close();
            
        }
    }
}
