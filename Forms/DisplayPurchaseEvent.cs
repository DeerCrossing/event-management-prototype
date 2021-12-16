using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ICT365_Assignment1.Forms
{
    public partial class DisplayPurchaseEvent : ICT365_Assignment1.Forms.PurchaseEventForm
    {
        protected int eventID;
        public DisplayPurchaseEvent()
        {
            InitializeComponent();
        }

        public DisplayPurchaseEvent(int eventIDIn)
        {
            eventID = eventIDIn;
            EventPurchase data = (EventPurchase)ManagerSingleton.Instance.Events.GetEventByID(eventID);
            NameBox.Text = data.GetName();
            DollarBox.Text = ((int)data.GetCost()).ToString();
            CentsBox.Text = (data.GetCost() - (int)data.GetCost()).ToString();
            List<string> items = data.GetPurchaseList();

            Console.WriteLine(items.Count.ToString());
            foreach(string s in items)
            {
                Console.WriteLine(s);
                ItemsBox.AppendText(s);
                ItemsBox.AppendText(Environment.NewLine);
            }
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

        private void DisplayPurchaseEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
