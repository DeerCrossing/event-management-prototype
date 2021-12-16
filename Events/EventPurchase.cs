using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    class EventPurchase : Event
    {
        public EventPurchase() : base()
        {
            SetEventType(EventType.Purchase);
            SetPurchaseList(new List<string>());
            SetCost(0.0m);
        }

        public EventPurchase(XElement dataIn) : base(dataIn)
        {
        }

        public void SetPurchaseList(List<string> itemsIn)
        {
            XElement purchaseList = new XElement(XMLConstants.LLENameSpace + XMLConstants.PurchaseList);
            purchaseList.SetAttributeValue(XMLConstants.Count, itemsIn.Count);
            
            foreach(string str in itemsIn)
            {
                purchaseList.Add(new XElement(XMLConstants.LLENameSpace + XMLConstants.Item, str));
            }

            if(Data.Element(XMLConstants.LLENameSpace + XMLConstants.PurchaseList) != null)
            {
                Data.Element(XMLConstants.LLENameSpace + XMLConstants.PurchaseList).Remove();
            }

            Data.Add(purchaseList);

            return;
        }

        public List<string> GetPurchaseList()
        {
            List<string> val = new List<string>();
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.PurchaseList);
            Console.WriteLine(ev.ToString());
            IEnumerable<XElement> items = ev.Elements(XMLConstants.LLENameSpace + XMLConstants.Item);

            if(ev != null)
            {
                if(items.Count() > 0)
                {
                    foreach(XElement e in items)
                    {
                        val.Add(e.Value);
                    }
                }
            }

            return val;
        }

        public void SetCost(decimal costIn)
        {
            Data.SetElementValue(XMLConstants.LLENameSpace + XMLConstants.Cost, costIn);
            return;
        }

        public decimal GetCost()
        {
            decimal val = 0.0m;
            XElement ev = Data.Element(XMLConstants.LLENameSpace + XMLConstants.Cost);

            if (ev != null)
            {
                val = decimal.Parse(ev.Value);
            }

            return val;
        }
    }
}
