using System;
using System.Collections.Generic;
using System.Text;

namespace TicketMachineConsole
{
    /// <summary>
    /// An object of the class ParkingMachine represents a parking machine.
    /// 
    /// Insert money first. 
    /// 
    /// Then buy a ticket or select cancel to refund.
    /// </summary>
    public class ParkingMachine
    {
        // There is two places to save money.
        // Total in the machine, from all finnished purchases.
        private int total;

        // Total for the current customer.
        private int currentTotal;

        // Cost to park.
        private int costPerHour;


        public ParkingMachine()
        {
            total = 0;
            currentTotal = 0;
            costPerHour = 20;
        }

        public ParkingMachine(int costPerHour)
        {
            this.costPerHour = costPerHour;
            total = 0;
            currentTotal = 0;

        }



        public int CurrentTotal
        {
            get
            {
                return currentTotal;
            }

        }
        public int Total

        {
            get
            {
                return total;
            }

        }

        public int CostPerHour
        {
            get
            {
                return costPerHour;
            }

        }

        public void InsertMoney(int v)
        {


            if (v >= 0)
            {

                currentTotal = currentTotal + v;

            }

        }


        public int Cancel()
        {
            int returbelopp = currentTotal;
            currentTotal = 0;
            return returbelopp;

        }

        public TimeSpan GetParkingTimeSpan()
        {
            int sparbelopp = currentTotal;
            int days = sparbelopp / (costPerHour * 24);
            int rest = sparbelopp % (costPerHour * 24);
            int hours = rest / costPerHour;
            int rest2 = rest % costPerHour;
            int minutes = rest2 * 60 / costPerHour;
            return new TimeSpan(days, hours, minutes, seconds: 0);
        }

        public DateTime GetValidTo()
        {
            DateTime date = DateTime.Now;

            TimeSpan timeSpan = GetParkingTimeSpan();

            date = date.Add(timeSpan);


            return date;
            
        }

        public string BuyTicket()
        {
            TimeSpan spantime = GetParkingTimeSpan();

            string ticketext = TimeToTicketText(spantime.Days, spantime.Hours, spantime.Minutes);
            total = total + currentTotal;
            currentTotal = 0;
            return ticketext;
        }

        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes" + Environment.NewLine + Environment.NewLine +  "Valid to: " + GetValidTo();
        }


    }
}
