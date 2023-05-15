namespace Richter.DesignPatterns.Strategy.Strategies
{
    internal class MedicalProcedureFemaleStrategy : IMedicalProcedureStrategy
    {
        public IList<MedicalProcedure> GetOptions(Patient patient)
        {
            //Se existissem fluxos longos para fumante poderiam haver outras strategies aqui dentro
            IList<MedicalProcedure> options = FakeRepository.GetMedicalProcedures(x => x.Gender.Equals(Gender.Female)
            && patient.Age >= x.AgeRange.Min
            && patient.Age <= x.AgeRange.Max
            && patient.Pregnant.Equals(x.Pregnant));

            switch (patient.Age)
            {
                case < 18: //Just example don't put hard code / Apenas exemplo, não utilize código fixo
                    options = new AgeRangeChildStrategy().AdapteeMedicalProcedure(options);
                    break;
                case > 18 and < 80: //Just example don't put hard code / Apenas exemplo, não utilize código fixo
                    options = new AgeRangeAdultStrategy().AdapteeMedicalProcedure(options);
                    break;
                case > 80: //Just example don't put hard code / Apenas exemplo, não utilize código fixo
                    options = new AgeRangeElderlyStrategy().AdapteeMedicalProcedure(options);
                    break;
            }

            //Poderia haver outra strategy para Gestação por quantidade de meses por exemplo, caso haja exames permitidos de acordo com esse critério.
            if(patient.Pregnant)
                foreach (var item in options)
                    item.AdditionalRequirements += " Gestante de n meses.";

            return options;

        }
    }
}
