namespace HomeworkWithServices.Models.DataBaseModels
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public List<Worker> WorkerList { get; set; }
    }
}
