namespace Richter.DesignPatterns.Strategy2.DataTransferObjects
{
    internal record LaboratoryZDto
    {
        public int DataId { get; set; }
        public int Cd { get; set; }
        public int ProcedureId { get; set; }
        public string Cpf { get; set; }
        public DateTime DtProcedure { get; set; }
    }
}
