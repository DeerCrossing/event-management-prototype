using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventVideo: Event
    {
        public EventVideo() : base()
        {
            SetEventType(EventType.Video);
        }

        public EventVideo(XElement dataIn) : base(dataIn)
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

            if(ev != null)
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
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Comment, textIn);
            return;
        }

        public string GetComment()
        {
            string val = "";
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Comment);

            if (ev != null)
            {
                val = ev.Value;
            }

            return val;
        }
    }
}
