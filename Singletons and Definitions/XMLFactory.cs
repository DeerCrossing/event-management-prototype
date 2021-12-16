using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    /// <summary>
    /// Used to construct default versions of XMLElements, used for creating new events and filling in a blank XMLDocument
    /// </summary>
    static class XMLFactory
    {
        public static XElement SOAPEnvelope()
        {
            XElement env = new XElement(XMLConstants.SOAPEnvelope);
            env.SetAttributeValue(XNamespace.Xmlns + "soap", XMLConstants.SOAPNameSpace.ToString());
            env.SetAttributeValue(XMLConstants.SOAPNameSpace + XMLConstants.SOAPEncoding, XMLConstants.SOAPEncodingURI);
            env.Add(SOAPBody());

            return env;
        }

        public static XElement SOAPBody()
        {
            XElement bod = new XElement(XMLConstants.SOAPNameSpace + XMLConstants.SOAPBody);
            bod.SetAttributeValue(XNamespace.Xmlns + "lle", XMLConstants.LLENameSpace.ToString());
            bod.Add(EventList());
            bod.Add(PersonList());
            bod.Add(EventToPeopleList());
            bod.Add(PersonToEventsList());

            return bod;
        }

        public static XElement EventList()
        {
            XElement events = new XElement(XMLConstants.LLENameSpace + XMLConstants.EventList);
            events.SetAttributeValue("count", 0);
            return events;
        }

        public static XElement PersonList()
        {
            XElement people = new XElement(XMLConstants.LLENameSpace + XMLConstants.PersonList);
            people.SetAttributeValue("count", 0);
            return people;
        }

        public static XElement EventToPeopleList()
        {
            XElement eToPeopleList = new XElement(XMLConstants.LLENameSpace + XMLConstants.EventToPeople);
            eToPeopleList.SetAttributeValue("count", 0);
            return eToPeopleList;
        }

        public static XElement PersonToEventsList()
        {
            XElement pToEventsList = new XElement(XMLConstants.LLENameSpace + XMLConstants.PersonToEvents);
            pToEventsList.SetAttributeValue("count", 0);
            return pToEventsList;
        }

        public static XElement EventRelationElement(int id)
        {
            XElement eRel = new XElement(XMLConstants.LLENameSpace + XMLConstants.Event);
            eRel.SetAttributeValue(XMLConstants.EventID, id);
            return eRel;
        }

        public static XElement PersonRelationElement(int id)
        {
            XElement pRel = new XElement(XMLConstants.LLENameSpace + XMLConstants.Person);
            pRel.SetAttributeValue(XMLConstants.PersonID, id);
            return pRel;
        }
    }
}
