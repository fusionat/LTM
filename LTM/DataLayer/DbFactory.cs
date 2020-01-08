using System;
using Microsoft.Extensions.DependencyInjection;

namespace DataLayer
{
    public class DbFactory : IDbFactory
    {
        private readonly LtmDataContext _dataContext;

        public DbFactory(IServiceProvider serviceProvider)
        {
            _dataContext = serviceProvider.GetService<ILtmDataContext>() as LtmDataContext;
        }

        public LtmDataContext Get()
        {
            return _dataContext;
        }
    }
}