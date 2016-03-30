namespace BusinessDiary.Services
{
    using System;
    using System.Linq;
    using Models;
    using BusinessDiary.Services.Contracts;
    using Data.Repositories;

    public class CompaniesServices : ICompaniesServices
    {
        private IRepository<Company> companies;

        public CompaniesServices(IRepository<Company> companies)
        {
            this.companies = companies;
        }

        public Company Create(Company company)
        {
            this.companies.Add(company);
            this.companies.SaveChanges();
            return company;
        }

        public Company DeleteById(int id)
        {
            var companyToDelete = this.companies.GetById(id);
            this.companies.Delete(companyToDelete);
            return companyToDelete;
        }

        public IQueryable<Company> GetAll()
        {
            return this.companies.All();
        }

        public Company GetById(int id)
        {
            return this.companies.GetById(id);
        }

        public Company Update(Company business)
        {
            var companyToUpdate = this.companies.GetById(business.Id);
            companyToUpdate.Name = business.Name;

            this.companies.SaveChanges();

            return companyToUpdate;
        }
    }
}
