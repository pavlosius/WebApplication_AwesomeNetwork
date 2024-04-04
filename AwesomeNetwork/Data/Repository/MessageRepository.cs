using AwesomeNetwork.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeNetwork.Data.Repository
{
    public class MessageRepository : Repository<Message>
    {
        public MessageRepository(ApplicationDbContext db)
        : base(db)
        {

        }
    }
}
