using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventActivity: Event
    {
        public EventActivity() : base()
        {
            SetEventType(EventType.Activity);
        }

        public EventActivity(XElement dataIn) : base(dataIn)
        {

        }

        public void SetActivity(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Activity, textIn);
            return;
        }

        public string GetActivity()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Activity);

            if (ev != null)
            {
                val = ev.Value;
            }

            return val;
        }

        public void SetDuration(TimeSpan timeIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Duration, timeIn);
            return;
        }

        public TimeSpan GetDuration()
        {
            TimeSpan val = new TimeSpan();
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Duration);

            if (ev != null)
            {
                try
                {
                    val = TimeSpan.Parse(ev.Value);
                }
                catch
                {
                    val = TimeSpan.Zero;
                }
            }

            return val;
        }


        public void SetComment(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + "comment", textIn);
            return;
        }

        public string GetComment()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + "comment");

            if (ev != null)
            {
                val = ev.Value;
            }

            return val;
        }

    }
}
