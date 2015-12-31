using Catom.Sky.Component.Data;
using Catom.Sky.Component.Data.Repo;
using Catom.Sky.Services.Entity;


namespace Catom.Sky.Services.HrM
{
    public class EmployeeRepo : BaseRepository<Employee>
    {
        public EmployeeRepo(IUnitOfWork uw) : base(uw) { }

        // Extend crud methods here.
    }
}
