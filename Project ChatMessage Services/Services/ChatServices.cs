using ProjectChatMessage.Repository.Repository;
using ProjectChatMessage.Repository.Repository.Models;

namespace Project_ChatMessage_Services.Services
{
    public class ChatServices:IChatServices
    {
        private readonly IChatRepository _chatRepository;

        public ChatServices(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }
        public void AddChat(Chat chat)
        {
            _chatRepository.AddChat(chat);
        }
       
        public List<Chat> GetAllChats()
        {
           return  _chatRepository.GetAllChat();
        }
    }
}