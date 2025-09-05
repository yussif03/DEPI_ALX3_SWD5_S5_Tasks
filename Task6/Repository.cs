using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task6.Models;

namespace Task6
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly EmployeeDbContext _employeeDbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
            _dbSet = _employeeDbContext.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dbSet.AsNoTracking().ToList();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Update(T entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var SelectedEntity = _dbSet.Find(id);
            if (SelectedEntity != null)
                _dbSet.Remove(SelectedEntity);
        }

        public int RowCount()
        {
            try
            {
                return _dbSet.AsNoTracking().Count();
            }
            catch (SqlException)
            {
                return -1;
            }
            catch (Exception)
            {
                return -1;
            }
        }

        internal void Save()
        {
            throw new NotImplementedException();
        }
    }
}
