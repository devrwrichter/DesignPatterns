using Newtonsoft.Json.Linq;
using Richter.DesignPatterns.Strategy2.DataTransferObjects;

namespace Richter.DesignPatterns.Strategy2.ACL
{
    public interface IAntiCorruptionService
    {
        IList<Message> GetMessages(IList<JObject> medicalProcedures);
    }
}