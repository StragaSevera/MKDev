using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Database.DataObjects;
using _06_Database.Repositories;

namespace _06_Database.Facades
{
    internal class ClientFacade
    {
        public ClientRepository _repository;

        public ClientFacade()
        {
            _repository = new ClientRepository();
        }

        public IEnumerable<Client> All()
        {
            return _repository.Where(_ => true);
        }

        public IEnumerable<Client> WithoutInvoices()
        {
            return _repository.Where(c => c.Invoices.Count == 0);
        }

        public IEnumerable<Client> WithInvoicesWithSumGreaterThan(decimal sum)
        {
            return _repository.Where(c =>
                c.Invoices.Select(i => i.Cost).Aggregate(
                    0m, (result, item) => result + item
                ) > sum
            );
        }
    }
}
