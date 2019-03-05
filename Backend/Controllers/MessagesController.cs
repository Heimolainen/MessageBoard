using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        static List<Message> messages = new List<Message>
        {
            new Message
                {
                    Owner = "Jouni",
                    Text = "Jotain tekstiä..."
                },
                new Message
                {
                    Owner = "Jouni2",
                    Text = "Jotain tekstiä... lisää"
                }
        };
        public IEnumerable<Message> Get()
        {
            return messages;
        }

        [HttpPost]
        public void Post([FromBody] Message message)
        {
            messages.Add(message);
        }
    }
}