using System.Threading.Tasks;

namespace Applications.Interfaces.MessageInterface
{
    public interface IMesasageInterface
    {
        Task GetMessages();
        Task GetMessagesByStatus(string status);
        Task GetMessagesByContent(string content);


    }
}
