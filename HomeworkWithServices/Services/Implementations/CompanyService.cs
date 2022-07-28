using HomeworkWithServices.Services.Interfaces;
using HomeworkWithServices.Models;
using HomeworkWithServices.Models.DataBaseModels;
using Microsoft.EntityFrameworkCore;

namespace HomeworkWithServices.Services.Implementations
{
    public class CompanyService: ICompanyService
    {
        private readonly ApplicationContext _context;
        public CompanyService(ApplicationContext context)
        {
            _context = context;
        }

        public void Create(Company company)
        {
            _context.Companies.Add(company);
            _context.SaveChanges();
        }

        public Company Get(int Id)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Id == Id);
            if (company == null) throw new Exception("Company is not found.");
            else return company;
        }

        public List<Company> GetAll()
        {
            return _context.Companies.AsNoTracking().ToList();
        }

        public void Update(int Id, Company newCompany)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Id == Id);
            if (company == null) throw new Exception("Company is not found.");
            else
            {
                company = newCompany;
                _context.Companies.Update(company);
                _context.SaveChanges();
            }
        }
    }
}
