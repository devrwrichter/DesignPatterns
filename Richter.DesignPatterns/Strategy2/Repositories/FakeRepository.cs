using Richter.DesignPatterns.Strategy2.DataTransferObjects;

namespace Richter.DesignPatterns.Strategy2.Repositories
{
    public class FakeRepository : IFakeRepository
    {
        public Patient LoadPatientByCode(int code)
        {
            return new Patient { Age = 18, Id = code, Name = "Patient Loaded by Code" };
        }

        public Patient LoadPatientByCpf(string cpf)
        {
            return new Patient { Age = 18, Id = 15, Name = "Patient Loaded by Cpf" };
        }

        public MedicalProcedure LoadMedicalProcedureById(int id)
        {
            return new MedicalProcedure { Id = id, Name = "Medical Procedure Name" };
        }
    }
}
