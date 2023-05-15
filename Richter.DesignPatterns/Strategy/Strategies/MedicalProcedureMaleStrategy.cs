using System.Diagnostics.CodeAnalysis;

namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal class MedicalProcedureMaleStrategy : IMedicalProcedureStrategy
    {
        public IList<MedicalProcedure> GetOptions(Patient patient)
        {
            //Se existissem fluxos longos para fumante poderiam haver outras strategies aqui dentro
            IList<MedicalProcedure> options = FakeRepository.GetMedicalProcedures(x => x.Gender.Equals(Gender.Male) 
            && patient.Age >= x.AgeRange.Min 
            && patient.Age <= x.AgeRange.Max);

            switch (patient.Age) {
                case < 18: //Just example don't put hard code
                    options = new AgeRangeChildStrategy().AdapteeMedicalProcedure(options);
                    break;
                case > 18 and < 80: //Just example don't put hard code
                    options = new AgeRangeAdultStrategy().AdapteeMedicalProcedure(options);
                    break;
                case > 80: //Just example don't put hard code
                    options = new AgeRangeElderlyStrategy().AdapteeMedicalProcedure(options);
                    break;

            }

            return options;

        }
    }
}
