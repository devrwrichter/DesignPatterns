namespace Richter.DesignPatterns.Strategy2.DataTransferObjects
{
    public record Message
    {
        public int ExternalServiceId { get; set; }
        public MedicalProcedure MedicalProcedure { get; set; }
        public Patient Patient { get; set; }
    }
}
