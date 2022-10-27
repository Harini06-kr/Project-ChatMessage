using ProjectChatMessage.Repository.Repository.Models;

namespace ProjectChatMessage.Repository.Repository
{
    public interface IChatRepository
    {
        void AddChat(Chat chat);
        List<Chat> GetAllChat();

    }
}