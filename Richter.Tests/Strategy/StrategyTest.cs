using FluentAssertions;
using Richter.DesignPatterns.Strategy;
using Xunit;

namespace Richter.Tests.Strategy
{
    public class StrategyTest
    {
        [Fact]
        public void GetOptions_Male_Child_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 11, Gender = Gender.Male, Smoker = true };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                    {
                        m.CompanionRequired.Should().Be(true);
                        m.Gender.Should().Be(Gender.Male);
                        m.AdditionalRequirements.Should().Be("Necessário acompanhante maior de idade para assinar papéis.");
                    }, 
                m =>
                    {
                        m.CompanionRequired.Should().Be(true);
                        m.Gender.Should().Be(Gender.Male);
                        m.AdditionalRequirements.Should().Be("Necessário acompanhante maior de idade para assinar papéis.");
                    });
        }

        [Fact]
        public void GetOptions_Female_Child_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 11, Gender = Gender.Female, Smoker = true };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(true);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário acompanhante maior de idade para assinar papéis.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(true);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário acompanhante maior de idade para assinar papéis.");
                });
        }

        [Fact]
        public void GetOptions_Female_Adult_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 25, Gender = Gender.Female, Smoker = true };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                });
        }

        [Fact]
        public void GetOptions_FemalePregnant_Adult_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 25, Gender = Gender.Female, Pregnant = true };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Pregnant.Should().Be(true);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário. Gestante de n meses.");
                });
        }

        [Fact]
        public void GetOptions_Female_Elderly_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 95, Gender = Gender.Female, Pregnant = false };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(true);
                    m.Gender.Should().Be(Gender.Female);
                    m.AdditionalRequirements.Should().Be("Necessário acompanhante. Necessário preenchimento de questionário.");
                });
        }

        [Fact]
        public void GetOptions_Male_Elderly_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 95, Gender = Gender.Male };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(true);
                    m.Gender.Should().Be(Gender.Male);
                    m.AdditionalRequirements.Should().Be("Necessário acompanhante. Necessário preenchimento de questionário.");
                });
        }

        [Fact]
        public void GetOptions_Male_Adult_ShouldBeOk()
        {
            //Arrange
            Patient patient = new() { Age = 25, Gender = Gender.Male, Smoker = true };

            //Action
            var results = new MedicalProcedureService().GetOptions(patient);

            //Assert
            results.Should().SatisfyRespectively(
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Male);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Male);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Male);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                },
                m =>
                {
                    m.CompanionRequired.Should().Be(false);
                    m.Gender.Should().Be(Gender.Male);
                    m.AdditionalRequirements.Should().Be("Necessário preenchimento de questionário.");
                });
        }
    }
}
