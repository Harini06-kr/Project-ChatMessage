using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectChatMessage.Repository.Repository.Models
{
    public  class Chat
    {
        public int ID { get; set; }
        public int ParentID { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }
    }
}
