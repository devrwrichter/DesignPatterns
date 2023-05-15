namespace Richter.DesignPatterns.Strategy
{
    public record MedicalProcedure
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public bool Smoker { get; set; }
        public bool Pregnant { get; set; }
        public AgeRange AgeRange { get; set; }
        public bool CompanionRequired { get; set; }
        public string AdditionalRequirements { get; set; }
    }
}
