using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT365_Assignment1
{
    public class ManagerSingleton
    {
        private static LLEManager instance = null;
        private static readonly object padlock = new object();

        ManagerSingleton()
        {
        }

        public static LLEManager Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new LLEManager();
                    }
                    return instance;
                }
            }
        }
        
    }
}
