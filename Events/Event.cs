using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ICT365_Assignment1
{

    /// <summary>
    /// The Base Class for Events, used to be able to store events as a single object
    /// Handles data types held by all events (ID Number, DateTime and Location in [lat, long])
    /// </summary>
    abstract class Event
    {
        public XElement Data { get; set; }

        public Event()
        {
            Data = new XElement(XMLConstants.LLENameSpace + XMLConstants.Event);
            Data.SetAttributeValue(XMLConstants.EventID, -1);
            Data.SetAttributeValue(XMLConstants.EventType, EventType.None.ToString());
            SetDateTime(DateTime.Now);
            SetLocation(new Location());
        }

        public Event(XElement dataIn)
        {
            Data = dataIn;
        }

        virtual public int GetID()
        {
            int returnValue = -1;

            XAttribute eventID = Data.Attribute(XMLConstants.EventID);
            
            if (eventID != null)
            {
                returnValue = Int16.Parse(eventID.Value);
            }

            return returnValue;
        }

        public virtual void SetID(uint idIn)
        {
            Data.SetAttributeValue(XMLConstants.EventID, idIn);
            return;
        }

        virtual public EventType GetEventType()
        {
            EventType returnValue = EventType.None;

            XAttribute eventType = Data.Attribute(XMLConstants.EventType);

            if (eventType != null)
            {
                returnValue = (EventType)Enum.Parse(typeof(EventType),eventType.Value);
            }

            return returnValue;
        }

        public virtual void SetEventType(EventType etIn)
        {
            Data.SetAttributeValue(XMLConstants.EventType, etIn.ToString());
            return;
        }

        public virtual DateTime GetDateTime()
        {
            DateTime returnValue = new DateTime();

            XElement dateTime = Data.Element(XMLConstants.LLENameSpace + XMLConstants.DateTime);

            if (dateTime != null)
            {
                returnValue = Convert.ToDateTime(dateTime.Value);
            }

            return returnValue;
        }

        public virtual void SetDateTime(DateTime dtIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.DateTime, dtIn);

            return;
        }

        public virtual Location GetLocation()
        {
            Location loc = new Location(-1,-1);

            XElement eventLoc = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Location);

            if (eventLoc != null)
            {
                XElement xLat = eventLoc.Element(XMLConstants.LLENameSpace + XMLConstants.Latitude);
                XElement xLong = eventLoc.Element(XMLConstants.LLENameSpace + XMLConstants.Longitude);

                if(xLat != null)
                {
                    loc.Latitude = float.Parse(xLat.Value);
                }

                if(xLong != null)
                {
                    loc.Longitude = float.Parse(xLong.Value);
                }
            }

            return loc;           
        }

        public virtual void SetLocation(Location locIn)
        {
            XElement xLoc = new XElement(XMLConstants.LLENameSpace + XMLConstants.Location);

            xLoc.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Latitude, locIn.Latitude);
            xLoc.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Longitude, locIn.Longitude);
            if (Data.Element(XMLConstants.LLENameSpace + XMLConstants.Location) != null)
            {
                Data.Element(XMLConstants.LLENameSpace + XMLConstants.Location).Remove();
            }
            Data.Add(xLoc);
        }

        public virtual void SetName(string nameIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.EventName, nameIn);
        }

        public virtual string GetName()
        {
            return Data.Element(XMLConstants.LLENameSpace + XMLConstants.EventName).Value;
        }

    }
}
