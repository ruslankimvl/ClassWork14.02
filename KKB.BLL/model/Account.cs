using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.model
{
   public class Account
    {
        public string AccountNumber { get; set; }   
        private double Balance_
        {
            get { return Balance_;   }
            set
            {
                if (value<0)
                {
                    throw new Exception("Balans ne mozhet byt menshe nulya ");
                }
                else
                {

                }
            }
        }
        public double Balance { get; set; }
    }
}
