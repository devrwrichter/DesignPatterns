using Newtonsoft.Json.Linq;
using Richter.DesignPatterns.Strategy2.DataTransferObjects;
using Richter.DesignPatterns.Strategy2.Strategies;

namespace Richter.DesignPatterns.Strategy2.ACL
{
    public class AntiCorruptionService : IAntiCorruptionService
    {
        //Abaixo poderia ser um factory, mas teria que ser singleton por questões performance nesse caso.
        private readonly ILaboratoryStrategy _laboratoryXStrategy =  new LaboratoryXStrategy();
        private readonly ILaboratoryStrategy _laboratoryYStrategy = new LaboratoryYStrategy();
        private readonly ILaboratoryStrategy _laboratoryZStrategy = new LaboratoryZStrategy();

        public IList<Message> GetMessages(IList<JObject> medicalProcedures)
        {
            var messages = new List<Message>();

            foreach (JObject jObj in medicalProcedures)
            {
                SourceType dataId = (SourceType)Convert.ToInt32(jObj.GetValue("DataId"));

                switch(dataId)
                {
                    case SourceType.LaboratoryX:
                        messages.Add(_laboratoryXStrategy.GetMessage(jObj));
                        break;
                    case SourceType.LaboratoryY:
                        messages.Add(_laboratoryYStrategy.GetMessage(jObj));
                        break;
                    case SourceType.LaboratoryZ:
                        messages.Add(_laboratoryZStrategy.GetMessage(jObj));
                        break;
                }
            }

            return messages;
        }
    }
}
