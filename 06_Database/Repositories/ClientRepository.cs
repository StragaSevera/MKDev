using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Database.DataObjects;

namespace _06_Database.Repositories
{
    internal class ClientRepository
    {
        private List<Client> _clients = new List<Client>();

        public ClientRepository()
        {
            var tariff = new Tariff {Name = "100 мб/с", MonthlyCost = 1000m};
            var client = new Client
            {
                Name = "Иван",
                Patronymic = "Сидорович",
                Surname = "Петров",
                Tariff = tariff
            };
            client.Invoices.Add(new Invoice
            {
                BillingDate = new DateTime(2018, 01, 01),
                Cost = tariff.MonthlyCost
            });
            client.Invoices.Add(new Invoice
            {
                BillingDate = new DateTime(2018, 02, 01),
                Cost = tariff.MonthlyCost
            });
            _clients.Add(client);

            client = new Client
            {
                Name = "Лев",
                Patronymic = "Игоревич",
                Surname = "Кузнецов",
                Tariff = tariff
            };
            client.Invoices.Add(new Invoice
            {
                BillingDate = new DateTime(2018, 05, 01),
                Cost = tariff.MonthlyCost
            });
            _clients.Add(client);

            tariff = new Tariff { Name = "50 мб/с", MonthlyCost = 500m };
            client = new Client
            {
                Name = "Гильгамеш",
                Patronymic = "Кулабович",
                Surname = "Урук",
                Tariff = tariff
            };
            _clients.Add(client);
        }

        public IEnumerable<Client> Where(Func<Client, bool> predicate)
        {
            return _clients.Where(predicate);
        }
    }
}
