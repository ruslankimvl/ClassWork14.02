using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KKB.BLL.model
{
    public class ServiceAccount
    {
        public List<Account> GetAccounts()
        {
            List<Account> accounts = new List<Account>;
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(1, 3); i++)
            {
                Account account = new Account;
                account.AcсountNumber ="KZT" +rnd.Next();
                account.Balance=rnd.Next(1000, 2000);
                account.CreateDate = DateTime.Now.AddMonth(20, 100);

            }
        } }
}
