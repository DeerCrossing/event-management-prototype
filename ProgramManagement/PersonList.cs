using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class PersonList
    {
        private Dictionary<int, Person> personMap;

        public PersonList()
        {
            personMap = new Dictionary<int, Person>();
        }

        public PersonList(XElement dataIn)
        {
            personMap = new Dictionary<int, Person>();

            IEnumerable<XElement> people = dataIn.Elements(XMLConstants.LLENameSpace + XMLConstants.Person);

            foreach (XElement p in people)
            {
                AddPerson(new Person(p));
            }
        }

        public Person GetPersonByID(int idIn)
        {
            return personMap[idIn];
        }

        public List<Person> GetPeopleByFirstName(string fNameIn)
        {
            List<Person> list = new List<Person>();

            foreach (KeyValuePair<int, Person> kv in personMap)
            {
                if (kv.Value.GetFirstName() == fNameIn)
                {
                    list.Add(kv.Value);
                }
            }

            return list;
        }
        public List<Person> GetPeopleByLastName(string lNameIn)
        {
            List<Person> list = new List<Person>();

            foreach (KeyValuePair<int, Person> kv in personMap)
            {
                if (kv.Value.GetFirstName() == lNameIn)
                {
                    list.Add(kv.Value);
                }
            }

            return list;
        }

        public List<Person> GetPeopleByName(string fNameIn, string lNameIn)
        {
            List<Person> list = new List<Person>();
            
            foreach (KeyValuePair<int, Person> kv in personMap)
            {
                if (kv.Value.GetFullName() == fNameIn + " " + lNameIn)
                {
                    list.Add(kv.Value);
                }
            }
            return list;
        }

        public List<Person> GetAllPeople()
        {
            List<Person> list = new List<Person>();

            foreach (KeyValuePair<int, Person> kv in personMap)
            {
                list.Add(kv.Value);
            }

            return list;
        }

        public void AddPerson(Person personIn)
        {
            personMap.Add(personIn.GetID(), personIn);
            return;
        }

        public void RemovePerson(int idIn)
        {
            personMap.Remove(idIn);
            return;
        }

        public void RemovePerson(Person personIn)
        {
            personMap.Remove(personIn.GetID());
            return;
        }

        public int PersonCount()
        {
            return personMap.Count;
        }
    }
}
