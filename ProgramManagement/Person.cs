using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class Person
    {
        public XElement Data { get; set; }

        public Person(XElement dataIn)
        {
            Data = dataIn;
        }

        public Person()
        {
            XElement newPerson = new XElement(XMLConstants.LLENameSpace + XMLConstants.Person);
            newPerson.SetAttributeValue(XMLConstants.PersonID, -1);
        }

        public int GetID()
        {
            int returnValue = -1;

            XAttribute personID = Data.Attribute(XMLConstants.PersonID);

            if (personID != null)
            {
                returnValue = Int16.Parse(personID.Value);
            }

            return returnValue;
        }

        public void SetID(int idIn)
        {
            Data.SetAttributeValue(XMLConstants.PersonID, idIn);
            return;
        }

        public string GetFirstName()
        {
            string val = "";

            XElement fName = Data.Element(XMLConstants.LLENameSpace + XMLConstants.FirstName);

            if(fName != null)
            {
                val = fName.Value;
            }

            return val;
        }

        public void SetFirstName(string fNameIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.FirstName, fNameIn);
            return;
        }

        public string GetLastName()
        {
            string val = "";

            XElement lName = Data.Element(XMLConstants.LLENameSpace + XMLConstants.LastName);

            if (lName != null)
            {
                val = lName.Value;
            }

            return val;
        }

        public void SetLastName(string lNameIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.LastName, lNameIn);
            return;
        }

        public string GetFullName()
        {
            return GetFirstName() + " " + GetLastName();
        }

        public int GetAge()
        {
            int val = 0;

            XElement age = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Age);

            if(age != null)
            {
                val = Int16.Parse(age.Value);
            }

            return val;
        }

        public void SetAge(int ageIn)
        {
            return;
        }

        public string GetPhoto()
        {
            string val = "";

            XElement photo = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Photo);

            if (photo != null)
            {
                val = photo.Value;
            }

            return val;
        }

        public void SetPhoto(string photoIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.LastName, photoIn);
            return;
        }
    }
}
