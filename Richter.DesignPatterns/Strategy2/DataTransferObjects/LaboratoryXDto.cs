namespace Richter.DesignPatterns.Strategy2.DataTransferObjects
{
    internal record LaboratoryXDto
    {
        public int DataId { get; set; }
        public int Code { get; set; }
        public int MedicalProcedureCode { get; set; }
        public int PatientCode { get; set; }
        public DateTime Date { get; set; }
    }
}
