using Richter.DesignPatterns.Strategy.Strategies;

namespace Richter.DesignPatterns.Strategy
{
    public class MedicalProcedureService
    {
        public IList<MedicalProcedure> GetOptions(Patient patient)
        {
            IMedicalProcedureStrategy strategy;

            if (patient.Gender.Equals(Gender.Male))
                strategy = new MedicalProcedureMaleStrategy();
            else
                strategy = new MedicalProcedureFemaleStrategy();

            return strategy.GetOptions(patient);
        }
    }
}
