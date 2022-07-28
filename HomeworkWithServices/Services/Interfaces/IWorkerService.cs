using HomeworkWithServices.Models.DataBaseModels;

namespace HomeworkWithServices.Services.Interfaces
{
    public interface IWorkerService
    {
        Worker Get(int Id);
        void Create(Worker worker);
        void Update(int Id, Worker worker);
        void Delete(int Id);

    }
}
