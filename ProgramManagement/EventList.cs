using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventList
    {
       private Dictionary<int, Event> eventMap;

        public EventList()
        {
            eventMap = new Dictionary<int, Event>();
        }

        public EventList(XElement dataIn)
        {
            eventMap = new Dictionary<int, Event>();

            IEnumerable<XElement> events = dataIn.Elements(XMLConstants.LLENameSpace + XMLConstants.Event);
            uint i = 0;
            foreach(XElement e in events)
            {
                Event ev = EventFactory.CreateEvent(e);
                ev.SetID(i);
                AddEvent(ev);
                i++;
            }
        }

        public Event GetEventByID(int idIn)
        {
            return eventMap[idIn];
        }

        public List<Event> GetEventsOfType(EventType typeIn)
        {
            List<Event> list = new List<Event>();

            foreach(KeyValuePair<int,Event> kv in eventMap)
            {
                if(kv.Value.GetEventType() == typeIn)
                {
                    list.Add(kv.Value);
                }
            }

            return list;
        }

        public List<Event> GetEventsNear(Location locIn, float radius)
        {
            List<Event> list = new List<Event>();

            foreach (KeyValuePair<int, Event> kv in eventMap)
            {
                Location kvLoc = kv.Value.GetLocation();
                Vector2 distance = new Vector2();
                distance.X = Math.Abs(locIn.Latitude - kvLoc.Latitude);
                distance.Y = Math.Abs(locIn.Longitude - kvLoc.Longitude);

                if(distance.Length <= radius)
                {
                    list.Add(kv.Value);
                }

            }

            return list;
        }

        public List<Event> GetAllEvents()
        {
            List<Event> list = new List<Event>();

            foreach (KeyValuePair<int, Event> kv in eventMap)
            {
                list.Add(kv.Value);
            }

            return list;
        }

        public void AddEvent(Event eventIn)
        {
            eventMap.Add(eventIn.GetID(), eventIn);
            return;
        }

        public void RemoveEvent(int idIn)
        {
            eventMap.Remove(idIn);
            return;
        }

        public void RemoveEvent(Event eventIn)
        {
            eventMap.Remove(eventIn.GetID());
            return;
        }

        public int EventCount()
        {
            return eventMap.Count;
        }
    }
}
