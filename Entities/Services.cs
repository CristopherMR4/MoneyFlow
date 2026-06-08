using System.ComponentModel.DataAnnotations;

namespace MoneyFlow.Entities;

public class Services
{
    public int ServiceID { get; set; }

    [Required]
    public string Name { get; set; }
    [Required]
    public string Type { get; set; }

    //llave foranea
    public int Userid { get; set; }

    //objeto User
    public Users ObjUser { get; set; }

}
