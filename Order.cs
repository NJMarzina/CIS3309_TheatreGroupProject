using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS3309_TheatreGroupProject
{
    public class Order
    {
        //ticket
        //price
        Ticket ticket;
        double total;



        public Order()
        {

        }

        public Order(double tot)
        {
            this.total = tot;
        }

        public Order(Ticket t, double tot)
        {
            this.ticket = t;
            this.total = tot;
        }

        public double Total
        {
            get
            {
                return this.total;
            }
            set
            {
                this.total = value;
            }
        }

        public double Calculate(int quantity)
        {
            double subtotal = 0;

            subtotal += 10;
            subtotal *= quantity;
            subtotal *= 1.07;

            return subtotal;
        }
    }
}
