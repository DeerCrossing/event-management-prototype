using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace ICT365_Assignment1
{
    public partial class LifeLogger : Form
    {
        public LifeLogger()
        {
            InitializeComponent();

            ManagerSingleton.Instance.LoadData("saved_file.xml");
            foreach (Event ev in ManagerSingleton.Instance.Events.GetAllEvents())
            {
                PictureBox tempEvent = new PictureBox();
                MapBox.Controls.Add(tempEvent);
                tempEvent.BackColor = Color.Transparent;
                tempEvent.Size = new Size(24, 24);
                tempEvent.Image = Properties.Resources.icon;
                Location loc = ev.GetLocation();
                Point locP = new Point((int)loc.Latitude, (int)loc.Longitude);
                locP.X -= 12;
                locP.Y -= 12;
                tempEvent.Location = locP;
                tempEvent.BringToFront();
                tempEvent.Click += Event_Click;
                ManagerSingleton.Instance.IconList[tempEvent] = ev.GetID();
            }
        }

        private void Event_Click(object sender, EventArgs e)
        {
            foreach(PictureBox c in MapBox.Controls)
            {
                c.Image = Properties.Resources.icon;
            }

            PictureBox active = (PictureBox)sender;
            active.Image = Properties.Resources.icon_selected;
            int eventID = ManagerSingleton.Instance.IconList[active];

            EventType activeEvent = ManagerSingleton.Instance.Events.GetEventByID(eventID).GetEventType();
            Form form;

            switch (activeEvent)
            {
                case EventType.General:
                    form = new Forms.DisplayGeneralEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.FacebookUpdate:
                    form = new Forms.DisplayFacebookEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.Tweet:
                    form = new Forms.DisplayTweetEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.Photo:
                    form = new Forms.DisplayPhotoEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.Video:
                    form = new Forms.DisplayVideoEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.Activity:
                    form = new Forms.DisplayActivityForm(eventID);
                    form.Activate();
                    form.Show();
                    break;

                case EventType.Purchase:
                    form = new Forms.DisplayPurchaseEvent(eventID);
                    form.Activate();
                    form.Show();
                    break;
            }
        }

        private void MapBox_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 1)
            {
                MouseEventArgs eM = (MouseEventArgs)e;
                PictureBox tempEvent = new PictureBox();
                MapBox.Controls.Add(tempEvent);
                tempEvent.BackColor = Color.Transparent;
                tempEvent.Size = new Size(24, 24);
                tempEvent.Image = Properties.Resources.icon;
                Point loc = eM.Location;
                loc.X -= 12;
                loc.Y -= 12;
                tempEvent.Location = loc;
                tempEvent.BringToFront();
                tempEvent.Click += Event_Click;

                Form form = new EventSelect(tempEvent);
                form.Activate();
                form.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnClosed(EventArgs e)
        {
            ManagerSingleton.Instance.SaveData("saved_file.xml");
        }
    }
}
