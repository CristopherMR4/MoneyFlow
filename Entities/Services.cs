namespace MoneyFlow.Entities;

public class Services
{
    public int ServiceID { get; set; }

    public string Name { get; set; }

    public string Type { get; set; }

    //llave foranea
    public int Userid { get; set; }

    //objeto User
    public Users ObjUser { get; set; }

}
