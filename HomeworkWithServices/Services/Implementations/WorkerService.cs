using HomeworkWithServices.Models;
using HomeworkWithServices.Models.DataBaseModels;
using HomeworkWithServices.Services.Interfaces;

namespace HomeworkWithServices.Services.Implementations
{
    public class WorkerService : IWorkerService
    {
        private readonly ApplicationContext _context;
        public WorkerService(ApplicationContext context)
        {
            _context = context;
        }
        public void Create(Worker worker)
        {
            _context.Workers.Add(worker);
            _context.SaveChanges();
        }

        public void Delete(int Id)
        {
            var worker = _context.Workers.FirstOrDefault(w => w.Id == Id);
            if(worker == null) throw new Exception("Worker is not found.");
            _context.Workers.Remove(worker);
            _context.SaveChanges();
        }

        public Worker Get(int Id)
        {
            var worker = _context.Workers.FirstOrDefault(w => w.Id == Id);
            if (worker == null) throw new Exception("Worker is not found.");
            else return worker;
        }

        public void Update(int Id, Worker newWorker)
        {
            var worker = _context.Workers.FirstOrDefault(w => w.Id == Id);
            if (worker == null) throw new Exception("Worker is not found.");
            else
            {
                worker=newWorker;
                _context.Workers.Update(worker);
                _context.SaveChanges();
            }
        }
    }
}
