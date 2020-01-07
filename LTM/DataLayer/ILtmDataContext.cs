using Domain;
using Microsoft.EntityFrameworkCore;

namespace DataLayer
{
    public interface ILtmDataContext
    {
        DbSet<Project> Projects {get;set;}
        void Save();
    }
}