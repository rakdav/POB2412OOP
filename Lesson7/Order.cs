using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    internal class Order
    {
        public Passanger? Passanger { get; set; }
        public Train? Train { get; set; }
        public Cashier? Cashier { get; set; }
        public Reciept? Reciept { get; set; }
        public DateTime? Created { get; set; }
        public Order(Passanger? passanger, Train? train, 
            Cashier? cashier, Reciept? reciept,
            DateTime? created)
        {
            Passanger = passanger;
            Train = train;
            Cashier = cashier;
            Reciept = reciept;
            Created = created;
        }
        public override string? ToString()
        {
            return Passanger!.FIO + "\n" +
                   Train!.Number + "\n" +
                   Train.Destination + "\n" +
                   Train.TimeDeparture + "\n" +
                   Reciept!.Amount + "\n" +
                   Cashier!.FIO;
        }
    }
}
