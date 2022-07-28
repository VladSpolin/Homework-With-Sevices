namespace HomeworkWithServices.Models.DataBaseModels
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public uint Number { get; set; }
        public int? CompanyId { get; set; }
        public Company ItsCompany { get; set; }
    }
}
