using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Applications.Interfaces.MessageInterface
{
    public interface IMessageLogInterface
    {
        Task GetAllMessagesLogs();

        Task GetMessageLogByStatus(string status);

        Task GetMessagesByQueueName(string name);

        Task PostMenssageQueue();

        

    }
}
