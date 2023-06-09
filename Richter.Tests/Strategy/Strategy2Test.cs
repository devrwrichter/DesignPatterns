﻿using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
using Xunit;
using Newtonsoft.Json;
using Richter.DesignPatterns.Strategy2.ACL;
using FluentAssertions;

namespace Richter.Tests.Strategy
{
    public class Strategy2Test
    {

        [Fact]
        public void GetMedicalProcedure()
        {
            //Arrange
            var list = GetList();
            IAntiCorruptionService acs = new AntiCorruptionService();

            //Action
            var result = acs.GetMessages(list);

            //Assert
            result.Should().SatisfyRespectively(
                m =>
                {
                    m.MedicalProcedure.Name.Should().Be("Medical Procedure Name| Generated by Strategy class LaboratoryXStrategy");
                },
                m =>
                {
                    m.MedicalProcedure.Name.Should().Be("Medical Procedure Name| Generated by Strategy class LaboratoryYStrategy");
                },
                m =>
                {
                    m.MedicalProcedure.Name.Should().Be("Medical Procedure Name| Generated by Strategy class LaboratoryZStrategy");
                });
        }


        
        private static List<JObject> GetList()
        {
            var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "../../../Strategy/rabbitMQList.json");
            var json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<List<JObject>>(json) ?? Enumerable.Empty<JObject>().ToList();
        }

    }
}
