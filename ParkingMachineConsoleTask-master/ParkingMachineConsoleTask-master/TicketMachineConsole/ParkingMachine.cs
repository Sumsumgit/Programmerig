using System;
using System.Collections.Generic;
using System.Text;

namespace ParkingMachineConsole
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

        public void InsertMoney(int v)
        {


            if(v >= 0)
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

        public string BuyTicket()
        {
            int sparbelopp = currentTotal;
            currentTotal = 0;
            total = total + sparbelopp;
            int days = sparbelopp / (costPerHour * 24);
            int rest = sparbelopp % (costPerHour * 24);
            int hours = rest / costPerHour;
            int rest2 = rest % costPerHour;
            int minutes = rest2 * 60 / costPerHour;
                      
            return TimeToTicketText(days, hours, minutes);
        }

        private string TimeToTicketText(int days, int hours, int minutes)
        {
            return "Parking ticket valid for:" + Environment.NewLine +
                days + " days" + Environment.NewLine +
                hours + " hours" + Environment.NewLine +
                minutes + " minutes";
        }
    }
}
