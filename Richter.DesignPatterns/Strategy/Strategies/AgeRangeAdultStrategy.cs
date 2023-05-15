namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal class AgeRangeAdultStrategy : IAgeRangeStrategy
    {
        public IList<MedicalProcedure> AdapteeMedicalProcedure(IList<MedicalProcedure> medicalProcedures)
        {
            foreach (var item in medicalProcedures)
            {
                item.AdditionalRequirements = "Necessário preenchimento de questionário.";
                item.CompanionRequired = false;
            }

            return medicalProcedures;
        }
    }
}
