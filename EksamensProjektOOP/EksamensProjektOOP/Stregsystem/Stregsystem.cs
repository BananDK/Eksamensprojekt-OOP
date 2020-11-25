using System;
using System.Collections.Generic;
using System.Text;

namespace EksamensProjektOOP
{
    class Stregsystem
    {
        List<User> users = new List<User>();
        List<Product> products = new List<Product>();
        List<Transaction> transactions = new List<Transaction>();

        public BuyTransaction BuyProduct(User user, Product product)
        {
            BuyTransaction buy = new BuyTransaction(user, product);
            buy.Execute();
            transactions.Add(buy);
            return buy;
        }

        public CashTransaction AddCreditsToAccount(User user, Product Amount)
        {
            // indsætter et beløb på en brugers konto, via en transaktion
            CashTransaction insertCash = new CashTransaction();
            insertCash.execute();
            transactions.Add(insertCash);
            return insertCash;

        }

        public void ExecuteTransaction(Transaction transaction)
        {
            //tilføjer en transaktioner til en liste


        }

        public string GetProductByID(Product id)
        {
            //Finder og returnerer det unikke produkt i listen over produkter ud fra et produkt id.
            return "";
        }

        public void GetUsers()
        {
            //Brugere der overholder predicate
        }

        public string GetUserByUsername(string username)
        {

            //Finder og returnerer den unikke bruger i brugerlisten ud fra brugernavn.
            return "";

        }

        public void GetTransaction(User user, int count)
        {
            //Finder et angivet (via parameter) antal transaktioner relateret til en given specifik bruger.
        }

        public string ActiveProducts(Product active)
        {
            //aktive produkter i stregsystemet på nuværende tidspunkt
            return "";
        }


    }
}
