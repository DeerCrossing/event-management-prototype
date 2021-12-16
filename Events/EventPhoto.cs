using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventPhoto: Event
    {
        public EventPhoto() : base()
        {
            SetEventType(EventType.Photo);
        }

        public EventPhoto(XElement dataIn) : base(dataIn)
        {

        }

        public void SetFilepath(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Filepath, textIn);
            return;
        }

        public string GetFilepath()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Filepath);

            if (ev != null)
            {
                val = ev.Value;
            }

            return val;
        }

        public void SetCaption(string textIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Caption, textIn);
            return;
        }

        public string GetCaption()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Caption);

            if (ev != null)
            {
                val = ev.Value;
            }

            return val;
        }
    }
}
