ßusing System;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Open / Closes Princible:
             * 
             * An object must be OPEN for development and CLOSED for change.
             * 
             * If you have to change an existing object when you want to add a new feature to an application, you are violating this principle.
             */

            Customer customer = new Customer { Card = new PremiumCard() };
            OrderManagement orderManagement = new OrderManagement { Orderer = customer };
            var discountTotal = orderManagement.Pay(1000);
            Console.WriteLine(discountTotal.ToString("C2"));

        }

        public abstract class CardType
        {
            public abstract decimal DiscountRate(decimal total);
           
        }

        public class StandartCard : CardType
        {
            public override decimal DiscountRate(decimal total)
            {
                return total * 0.95M;
            }
        }

        public class SilverCard : CardType
        {
            public override decimal DiscountRate(decimal total)
            {
               return total * 0.90M;
            }
        }
        public class GoldCard : CardType
        {
            public override decimal DiscountRate(decimal total)
            {
                return total * 0.85M;
            }
        }
        public class PremiumCard : CardType
        {
            public override decimal DiscountRate(decimal total)
            {
                return total * 0.80M;
            }
        }

        public class Customer
        {
            public CardType Card { get; set; }
        }

        public class OrderManagement
        {
            public Customer Orderer { get; set; }
            public decimal Pay(decimal total)
            {
                return Orderer.Card.DiscountRate(total);
            }
        }
    }
}
