using Applications.Request.MessageRequests;
using System.Threading.Tasks;

namespace Applications.Interfaces.BankInterface
{
    public interface IQueueInterface
    {
        Task GetQueueMessages(QueueMessageRequest request);
    }
}
