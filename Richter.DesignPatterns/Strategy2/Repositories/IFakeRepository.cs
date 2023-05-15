using Richter.DesignPatterns.Strategy2.DataTransferObjects;

namespace Richter.DesignPatterns.Strategy2.Repositories
{
    public interface IFakeRepository
    {
        MedicalProcedure LoadMedicalProcedureById(int id);
        Patient LoadPatientByCode(int code);
        Patient LoadPatientByCpf(string cpf);
    }
}