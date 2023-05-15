using Richter.DesignPattern.Memento;

namespace Richter.DesignPatterns.Strategy
{
    internal class FakeRepository
    {
        public static IList<MedicalProcedure> Procedures = new List<MedicalProcedure> { 
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 3, Max = 90 }, Gender = Gender.Male, Id = 1, Name = "Procedimento x para criança ou adulto do sexo masculino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 3, Max = 90 }, Gender = Gender.Male, Id = 2, Name = "Procedimento y para criança ou adulto do sexo masculino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 3, Max = 90 }, Pregnant = false, Gender = Gender.Female, Id = 3, Name = "Procedimento x para criança ou adulto do sexo feminino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 3, Max = 90 }, Pregnant = false, Gender = Gender.Female, Id = 4, Name = "Procedimento y para criança ou adulto do sexo feminino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 18, Max = 90 }, Gender = Gender.Male, Id = 5, Name = "Procedimento x para adulto do sexo masculino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 18, Max = 90 }, Gender = Gender.Male, Id = 6, Name = "Procedimento y para adulto do sexo masculino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 18, Max = 90 }, Pregnant = false, Gender = Gender.Female, Id = 7, Name = "Procedimento x para adulto do sexo feminino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 18, Max = 90 }, Pregnant = false, Gender = Gender.Female, Id = 8, Name = "Procedimento y para adulto do sexo feminino" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 18, Max = 90 }, Pregnant = true, Gender = Gender.Female, Id = 9, Name = "Procedimento y para adulto do sexo feminino em gestação" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 90, Max = 110 }, Pregnant = false, Gender = Gender.Female, Id = 9, Name = "Procedimento y para idoso do sexo feminino em gestação" },
            new MedicalProcedure{ AgeRange = new AgeRange{  Min = 90, Max = 110 }, Gender = Gender.Male, Id = 9, Name = "Procedimento y para idoso do sexo masculino em gestação" },
        };

        /// <summary>
        /// Feito dessa forma apenas como atalho obter os dados fictícios.
        /// </summary>
        /// <param name="fn"></param>
        /// <returns>IList<MedicalProcedure></returns>
        public static IList<MedicalProcedure> GetMedicalProcedures(Func<MedicalProcedure, bool> fn)
        {
            return Procedures.Where(fn).ToList();
        }
    }
}
