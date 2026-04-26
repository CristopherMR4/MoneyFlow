namespace MoneyFlow.Entities;

public class Users
{
    public int UserID { get; set; }

    public string UserName { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public ICollection<Services> IServices {  get; set; }

    public ICollection<Transactions> ITransactions { get; set; }
}
