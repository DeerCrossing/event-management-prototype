using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace ICT365_Assignment1
{
    public class XMLConstants
    {
        //Namespaces
        public static XNamespace LLENameSpace = "http://www.xyz.org/lifelogevents";
        public static XNamespace SOAPNameSpace = "http://www.w3.org/2001/12/soap-envelope";

        //Soap Envelope Variables
        public static string SOAPEncoding = "encodingStyle";
        public static string SOAPEncodingURI = "http://www.w3.org/2001/12/soap-encoding";
        public static string SOAPEnvelope = "Envelope";
        public static string SOAPBody = "Body";

        //List Variables
        public static string EventList = "EventList";
        public static string PersonList = "PersonList";
        public static string EventToPeople = "EventToPeople";
        public static string PersonToEvents = "PersonToEvents";

        //Event Element Names
        public static string Event = "Event";
        public static string EventName = "eventName";
        public static string Location = "location";
        public static string Longitude = "longitude";
        public static string Latitude = "latitude";
        public static string DateTime = "datetime";
        public static string Duration = "duration";
        public static string Filepath = "filepath";
        public static string Cost = "cost";
        public static string Comment = "comment";
        public static string Activity = "activity";
        public static string Caption = "caption";
        public static string PurchaseList = "purchaseList";
        public static string Item = "item";
        public static string Text = "text";

        //Event Attribute Names
        public static string Count = "count";
        public static string EventID = "eventID";
        public static string EventType = "EventType";

        //Person Element Names
        public static string Person = "Person";
        public static string Title = "title";
        public static string FirstName = "firstName";
        public static string LastName = "lastName";
        public static string Age = "age";
        public static string Photo = "photo";

        //Person Attribute Names
        public static string PersonID = "personID";
    }
}
