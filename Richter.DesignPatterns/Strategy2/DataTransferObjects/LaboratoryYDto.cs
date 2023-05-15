namespace Richter.DesignPatterns.Strategy2.DataTransferObjects
{
    internal record LaboratoryYDto
    {
        public int DataId { get; set; }
        public int Cd { get; set; }
        public int MPCode { get; set; }
        public string Cpf { get; set; }
        public DateTime Dt { get; set; }
    }
}
