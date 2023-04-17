using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecology
{
    public class GlobalData
    {
        public string Token { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
         

        //for ID 
        private static int id;
        
        public static void ID_Set(int ID)
        {
            id = ID;
        }
        public static int ID_Get()
        {
            return id;
        }

      
        public List<string> Completed_Tasks { get; set; }

    }
}
