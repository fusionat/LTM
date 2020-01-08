using Domain;

namespace DataLayer.Repositories
{
    public class ProjectRepository : RepositoryBase<Project>, IProjectRepository
    {
        public ProjectRepository(IDbFactory dataContext) : base(dataContext)
        {
        }
    }

    public interface IProjectRepository : IRepository<Project>
    {
    }
}