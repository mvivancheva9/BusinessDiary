namespace BusinessDiary.Services.Contracts
{
    using Models;
    using System.Linq;

    public interface ICompaniesServices
    {
        IQueryable<Company> GetAll();

        Company Update(Company business);

        Company DeleteById(int id);

        Company Create(Company company);

        Company GetById(int id);
    }
}
