namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal interface IAgeRangeStrategy
    {
        IList<MedicalProcedure> AdapteeMedicalProcedure(IList<MedicalProcedure> medicalProcedures);
    }
}