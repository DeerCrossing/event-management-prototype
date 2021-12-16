using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using RelationList = System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<int, System.Collections.Generic.List<int>>>;

namespace ICT365_Assignment1
{
    public class LLEManager
    {
        EventList events;
        PersonList people;
        EventPersonRelations relations;
        Dictionary<PictureBox, int> iconList;
        int idCount;

        public int IdCount { get => idCount; set => idCount = value; }
        internal EventList Events { get => events; set => events = value; }
        internal PersonList People { get => people; set => people = value; }
        internal EventPersonRelations Relations { get => relations; set => relations = value; }
        public Dictionary<PictureBox, int> IconList { get => iconList; set => iconList = value; }

        public LLEManager()
        {
            idCount = 0;
            events = new EventList();
            people = new PersonList();
            relations = new EventPersonRelations();
            iconList = new Dictionary<PictureBox, int>();
        }

        public LLEManager(string filePath)
        {
            LoadData(filePath);
        }

        public void SaveData(string filePath)
        {
            XDocument doc;
            XElement envelope;
            XElement body;

            envelope = XMLFactory.SOAPEnvelope();
            body = envelope.Element(XMLConstants.SOAPNameSpace + XMLConstants.SOAPBody);

            //Save Event List
            List<Event> eventObjects = events.GetAllEvents();
            body.Element(XMLConstants.LLENameSpace + XMLConstants.EventList).SetAttributeValue(XMLConstants.Count, eventObjects.Count);
            foreach(Event e in eventObjects)
            {
                body.Element(XMLConstants.LLENameSpace + XMLConstants.EventList).Add(e.Data);
            }

            //Save Person List
            List<Person> personObjects = people.GetAllPeople();
            body.Element(XMLConstants.LLENameSpace + XMLConstants.PersonList).SetAttributeValue(XMLConstants.Count, personObjects.Count);
            foreach (Person p  in personObjects)
            {
                body.Element(XMLConstants.LLENameSpace + XMLConstants.PersonList).Add(p.Data);
            }

            //Save Person to Event Relations
            RelationList eRel = relations.GetEvents();
            RelationList pRel = relations.GetPeople();

            foreach(KeyValuePair<int,List<int>> kv in eRel)
            {
                XElement e = XMLFactory.EventRelationElement(kv.Key);
                foreach(int i in kv.Value)
                {
                    e.Add(XMLFactory.PersonRelationElement(i));
                }

                body.Element(XMLConstants.LLENameSpace + XMLConstants.EventToPeople).Add(e);
            }

            foreach (KeyValuePair<int, List<int>> kv in pRel)
            {
                XElement p = XMLFactory.PersonRelationElement(kv.Key);
                foreach (int i in kv.Value)
                {
                    p.Add(XMLFactory.EventRelationElement(i));
                }

                body.Element(XMLConstants.LLENameSpace + XMLConstants.PersonToEvents).Add(p);
            }

            //Write to XML Document
            XmlWriterSettings s = new XmlWriterSettings();
            s.Indent = true;
            XmlWriter writer = XmlWriter.Create(filePath,s);
            doc = new XDocument();
            doc.Add(envelope);
            doc.Save(writer);
            writer.Close();

            return;
        }

        public void LoadData(string filePath)
        {
            idCount = 0;
            XDocument doc;
            XmlReader reader;
            reader = XmlReader.Create(filePath);

            try
            {
                doc = XDocument.Load(reader);
                Console.WriteLine("PrINTY BOIT");
                reader.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                doc = new XDocument();
                doc.Add(XMLFactory.SOAPEnvelope());
                reader.Close();
            }

            //Access Body of Document
            XElement body = doc.Element(XMLConstants.SOAPEnvelope).Element(XMLConstants.SOAPNameSpace + XMLConstants.SOAPBody);

            //Load Event List
            events = new EventList(body.Element(XMLConstants.LLENameSpace + XMLConstants.EventList));
            idCount = events.EventCount();

            //Load Person List
            people = new PersonList(body.Element(XMLConstants.LLENameSpace + XMLConstants.PersonList));

            //Load Relations
            relations = new EventPersonRelations(body.Element(XMLConstants.LLENameSpace + XMLConstants.EventToPeople), body.Element(XMLConstants.LLENameSpace + XMLConstants.PersonToEvents)); 
            return;
        }

        
    }
}
