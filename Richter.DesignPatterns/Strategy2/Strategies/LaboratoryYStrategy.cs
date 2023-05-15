﻿using Newtonsoft.Json.Linq;
using Richter.DesignPatterns.Strategy2.DataTransferObjects;
using Richter.DesignPatterns.Strategy2.Repositories;

namespace Richter.DesignPatterns.Strategy2.Strategies
{
    internal class LaboratoryYStrategy : ILaboratoryStrategy
    {
        private readonly IFakeRepository _repository = new FakeRepository();//Seria correto utilizar DI num caso real.

        public Message GetMessage(JObject jObj)
        {
            var dto = jObj.ToObject<LaboratoryYDto>();

            var proc = _repository.LoadMedicalProcedureById(dto.MPCode);
            proc.ExecutionDate = Convert.ToDateTime(dto.Dt);
            proc.Name += $"| Generated by Strategy class {this.GetType().Name}";


            var patient = _repository.LoadPatientByCpf(dto.Cpf);

            return new Message
            {
                ExternalServiceId = (int)SourceType.LaboratoryX,
                MedicalProcedure = proc,
                Patient = patient
            };
        }
    }
}