namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal class AgeRangeChildStrategy : IAgeRangeStrategy
    {
        public IList<MedicalProcedure> AdapteeMedicalProcedure(IList<MedicalProcedure> medicalProcedures)
        {
            foreach (var item in medicalProcedures)
            {
                item.AdditionalRequirements = "Necessário acompanhante maior de idade para assinar papéis.";
                item.CompanionRequired = true;
            }

            return medicalProcedures;
        }
    }
}
