using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventGeneral: Event
    {
        public EventGeneral() : base()
        {
            SetEventType(EventType.General);
        }

        public EventGeneral(XElement dataIn) : base(dataIn)
        {

        }

        public void SetComment(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Comment, textIn);    
            return;
        }

        public string GetComment()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Comment);

            if(ev != null)
            {
                val = ev.Value;
            }

            return val;
        }
    }
}
