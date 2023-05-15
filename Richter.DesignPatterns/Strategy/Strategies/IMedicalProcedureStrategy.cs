namespace Richter.DesignPatterns.Strategy.Strategies
{
    public interface IMedicalProcedureStrategy
    {
        IList<MedicalProcedure> GetOptions(Patient patient);
    }
}
