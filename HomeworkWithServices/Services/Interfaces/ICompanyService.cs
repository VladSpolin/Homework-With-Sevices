using HomeworkWithServices.Models.DataBaseModels;

namespace HomeworkWithServices.Services.Interfaces
{
    public interface ICompanyService
    {
        List<Company> GetAll();
        Company Get(int Id);
        void Create(Company company);
        void Update(int Id, Company company);
    }
}
