using MoneyFlow.Entities;

namespace MoneyFlow.DTOs
{
    public class TransactionDTO
    {

        //Funcion de llave foreanas.
        public int Userid { get; set; }

        public int Serviceid { get; set; }

            //Funciones primarias para el DTOs
        public string Comment { get; set; }

        public DateOnly Date { get; set; }

        public decimal TotalAmount { get; set; }




    }
}
