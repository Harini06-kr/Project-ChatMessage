using ProjectChatMessage.Repository.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_ChatMessage_Services.Services
{
    public  interface IChatServices
    {
        void AddChat(Chat chat);
        List<Chat> GetAllChats();
    }
}
