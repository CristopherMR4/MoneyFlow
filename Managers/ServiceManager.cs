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




    }
}
