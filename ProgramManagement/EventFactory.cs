using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;

namespace ICT365_Assignment1
{
    static class EventFactory
    {
        public static Event CreateEvent(XElement dataIn)
        {
            Event e = new EventGeneral(dataIn);

            EventType type = (EventType)Enum.Parse(typeof(EventType), dataIn.Attribute(XMLConstants.EventType).Value);
            switch (type)
            {
                case EventType.General:
                    EventGeneral g = new EventGeneral(dataIn);
                    e = g;
                    break;

                case EventType.FacebookUpdate:
                    EventFacebookUpdate f = new EventFacebookUpdate(dataIn);
                    e = f;
                    break;

                case EventType.Tweet:
                    EventTweet t = new EventTweet(dataIn);
                    e = t;
                    break;

                case EventType.Photo:
                    EventPhoto p = new EventPhoto(dataIn);
                    e = p;
                    break;

                case EventType.Video:
                    EventVideo v = new EventVideo(dataIn);
                    e = v;
                    break;

                case EventType.Purchase:
                    EventPurchase u = new EventPurchase(dataIn);
                    e = u;
                    break;

                case EventType.Activity:
                    EventActivity a = new EventActivity(dataIn);
                    e = a;
                    break;
            }

            return e;
        }
    }
}
