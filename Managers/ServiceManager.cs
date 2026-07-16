//librerias

using MoneyFlow.Context;
using MoneyFlow.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
using MoneyFlow.Models;
namespace MoneyFlow.Managers
{
    public class ServiceManager(AppDbContext _dbContext)
    {

        public List<ServiceVM>GetAll(int userid)
        {
            var list = _dbContext.Services.Where(item => item.Userid == userid)
            .Select(item => new ServiceVM{
              Userid = item.Userid,
              ServiceID = item.ServiceID,
              Type = item.Type,
              Name = item.Name,
            })
            .ToList();
            return list;

        }
        public int NewService(ServiceVM serviceVM) {

            var entity = new Services
            {
                Name = serviceVM.Name,
                Type = serviceVM.Type,
                Userid = serviceVM.Userid
            };
        
            _dbContext.Services.Add(entity);
            var rowsAffected =  _dbContext.SaveChanges();

            return rowsAffected;
        }

        public ServiceVM GetById(int id)
        {
            var entity = _dbContext.Services.Find(id);

            var model = new ServiceVM
            {
                ServiceID = id,
                Name = entity.Name,
                Type = entity.Type,
            };

            return model;
        }

    }
}
