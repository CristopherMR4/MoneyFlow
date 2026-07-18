using MoneyFlow.Context;
using MoneyFlow.DTOs;
using MoneyFlow.Entities;
using System.Transactions;

namespace MoneyFlow.Managers
{
    public class TransactionManager(AppDbContext _dbContext)
    {
        public int New(TransactionDTO modelDTO)
        {
            var entity = new Transactions
            {
               
                Date = modelDTO.Date,
                TotalAmount = modelDTO.TotalAmount,
                Comment = modelDTO.Comment,
                Serviceid = modelDTO.Serviceid,
                Userid = modelDTO.Userid

            };
            _dbContext.Transactions.Add(entity);
            var rowsAffected = _dbContext.SaveChanges();

            return rowsAffected;
    }   }
}
