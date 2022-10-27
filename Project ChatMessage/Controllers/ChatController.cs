using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project_ChatMessage_Services.Services;
using ProjectChatMessage.Repository.Repository;
using ProjectChatMessage.Repository.Repository.Models;

namespace Project_ChatMessage.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChatController : ControllerBase
    {
        private readonly IChatServices _chatServices;

        public ChatController (IChatServices chatServices)
        {
            _chatServices = chatServices;
        }
            
        [HttpPost]
        [Route("AddChat")]
        public IActionResult Addchat (Chat chat)
        {
         _chatServices.AddChat(chat);
            return Ok();
        }
        [HttpGet]
        [Route("GetAllChat")]
        public async Task<IActionResult> GetAllChat()
        {
            List<Chat> chats=new List<Chat> ();
            chats =_chatServices.GetAllChats();
            return Ok(chats);

        }
    }
}
