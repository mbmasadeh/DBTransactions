using DBTransactions.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBTransactions.Services
{
    public class ServiceManager
    {
        private readonly Context _context;
        public ServiceManager(Context context)
        {
            _context = context;
        }
        public T NewSerivce<T>()
        {
            var serviceType = (T)Activator.CreateInstance(typeof(T),_context);
            return serviceType;
        }
        public T NewService<T>(params object[] objects)
        {
            var serviceType = (T)Activator.CreateInstance(typeof(T), objects);
            return serviceType;
        }
        public async System.Threading.Tasks.Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
