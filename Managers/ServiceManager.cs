//librerias

using MoneyFlow.Context;
using MoneyFlow.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;
namespace MoneyFlow.Managers
{
    public class ServiceManager(AppDbContext _dbContext)
    {

        public List<Services>GetAll(int userid)
        {
            var list = _dbContext.Services.Where(item => item.Userid == userid).ToList();
            return list;

        }




    }
}
