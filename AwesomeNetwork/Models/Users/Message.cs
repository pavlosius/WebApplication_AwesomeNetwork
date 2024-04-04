using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeNetwork.Models.Users
{
    public class Message
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public User Sender { get; set; }

        public User Recipient { get; set; }
    }
}
