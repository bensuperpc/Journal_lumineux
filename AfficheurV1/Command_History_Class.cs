using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AfficheurV1
{
    [Serializable]
    public class Command_History_Class
    {
        public List<Message_Maker> Command_History_List = new List<Message_Maker>();
        
            public  Command_History_Class()
        {
            Command_History_List = new List<Message_Maker>();
            
        }
		//Test Commit 2
        
    }
}
