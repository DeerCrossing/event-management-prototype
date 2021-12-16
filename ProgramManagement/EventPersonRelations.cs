using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using RelationList = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, System.Collections.Generic.List<int>>>;

namespace ICT365_Assignment1
{
    class EventPersonRelations
    {
        Dictionary<int, List<int>> eventsPerPerson;
        Dictionary<int, List<int>> peoplePerEvent;

        public EventPersonRelations()
        {
            eventsPerPerson = new Dictionary<int, List<int>>();
            peoplePerEvent = new Dictionary<int, List<int>>();
        }
        
        public EventPersonRelations(XElement peopleEvent, XElement eventsPerson)
        {
            eventsPerPerson = new Dictionary<int, List<int>>();
            peoplePerEvent = new Dictionary<int, List<int>>();

            //Loop Through events, get list of people at each event
            IEnumerable<XElement> eventsElem = peopleEvent.Elements(XMLConstants.LLENameSpace + XMLConstants.Event);
            IEnumerable<XElement> peopleElem;

            foreach(XElement e in eventsElem)
            {
                int id = Int16.Parse(e.Attribute(XMLConstants.EventID).Value);

                peoplePerEvent.Add(id, new List<int>());
                peopleElem = e.Elements(XMLConstants.LLENameSpace + XMLConstants.Person);

                foreach(XElement p in peopleElem)
                {
                    peoplePerEvent[id].Add(Int16.Parse(p.Attribute(XMLConstants.PersonID).Value));
                }
            }

            //Loop Through people get list of all events person has attended

            peopleElem = eventsPerson.Elements(XMLConstants.LLENameSpace + XMLConstants.Person);

            foreach(XElement p in peopleElem)
            {
                int id = Int16.Parse(p.Attribute(XMLConstants.PersonID).Value);

                eventsPerPerson.Add(id, new List<int>());
                eventsElem = p.Elements(XMLConstants.LLENameSpace + XMLConstants.Event);

                foreach(XElement e in eventsElem)
                {
                    eventsPerPerson[id].Add(Int16.Parse(e.Attribute(XMLConstants.EventID).Value));
                }

            }
        }

        public void LinkPersonToEvent(int eventID, int personID)
        {
            if(eventsPerPerson[personID] == null)
            {
                eventsPerPerson[personID] = new List<int>();
            }

            if(peoplePerEvent[eventID] == null)
            {
                peoplePerEvent[eventID] = new List<int>();
            }

            if (!eventsPerPerson[personID].Contains(eventID))
            {
                eventsPerPerson[personID].Add(eventID);
            }

            if(!peoplePerEvent[eventID].Contains(personID))
            {
                peoplePerEvent[eventID].Add(personID);
            }

            return;
        }

        public void UnlinkPersonAndEvent(int eventID, int personID)
        {
            peoplePerEvent[eventID].Remove(personID);
            eventsPerPerson[personID].Remove(eventID);
        }

        public List<int> GetPeopleForEvent(int eventID)
        {
            return peoplePerEvent[eventID];
        }

        public List<int> GetEventsForPerson(int personID)
        {
            return eventsPerPerson[personID];
        }

        public RelationList GetEvents()
        {
            RelationList list = new RelationList();

            foreach (KeyValuePair<int, List<int>> kv in peoplePerEvent)
            {
                list.Add(kv);
            }

            return list;
        }

        public RelationList GetPeople()
        {
            RelationList list = new RelationList();

            foreach (KeyValuePair<int, List<int>> kv in eventsPerPerson)
            {
                list.Add(kv);
            }

            return list;
        }
    }
}
