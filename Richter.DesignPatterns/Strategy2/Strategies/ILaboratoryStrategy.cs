using Newtonsoft.Json.Linq;
using Richter.DesignPatterns.Strategy2.DataTransferObjects;

namespace Richter.DesignPatterns.Strategy2.Strategies
{
    internal interface ILaboratoryStrategy
    {
        Message GetMessage(JObject jObj);
    }
}