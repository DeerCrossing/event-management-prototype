using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventTweet: Event
    {
        public EventTweet() : base()
        {
            SetEventType(EventType.Tweet);
        }

        public EventTweet(XElement dataIn) : base(dataIn)
        {

        }

        public void SetText(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Text, textIn);    
            return;
        }

        public string GetText()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Text);

            if(ev != null)
            {
                val = ev.Value;
            }

            return val;
        }
    }
}
