namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal class AgeRangeElderlyStrategy : IAgeRangeStrategy
    {
        public IList<MedicalProcedure> AdapteeMedicalProcedure(IList<MedicalProcedure> medicalProcedures)
        {
            foreach (var item in medicalProcedures)
            {
                item.AdditionalRequirements = "Necessário acompanhante. Necessário preenchimento de questionário.";
                item.CompanionRequired = true;
            }

            return medicalProcedures;
        }
    }
}
