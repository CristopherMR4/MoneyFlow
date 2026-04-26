namespace MoneyFlow.Entities;

public class Transactions
{

    public int TransactionID { get; set; }

    public string Comment { get; set; }

    public DateOnly Date { get; set; }

    public decimal TotalAmount { get; set; }
    

    //Funcion de llave foreanas.
    public int Userid { get; set; }

    public int Serviceid { get; set; }
    //objetos
    public Users ObjUser { get; set; }
    public Services Objservice { get; set; }
}
