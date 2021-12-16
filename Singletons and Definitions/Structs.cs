using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_Assignment1
{
    struct Location
    {
        float latitude;
        float longitude;

        public Location(float latIn, float longIn)
        {
            latitude = latIn;
            longitude = longIn;
        }

        public float Latitude { get => latitude; set => latitude = value; }
        public float Longitude { get => longitude; set => longitude = value; }
    }


    struct Vector2
    {
        float x;
        float y;

        public Vector2(float xIn, float yIn)
        {
            x = xIn;
            y = yIn;
        }

        public float X {get => x; set => x = value;}
        public float Y {get => y; set => y = value;}

        public float Length
        {
            get => (float)Math.Sqrt(x * x + y * y);
        }
    }
}
