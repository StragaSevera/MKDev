using System.Collections.Generic;
using System.Text;

namespace _06_Database.DataObjects
{
    internal class Client
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }

        public Tariff Tariff { get; set; }
        public List<Invoice> Invoices { get; set; } = new List<Invoice>();

        public override string ToString()
        {
            var stringBuilder = new StringBuilder($"{Name} {Patronymic} {Surname}: {Tariff}\n");
            Invoices.ForEach(i => stringBuilder.AppendLine(i.ToString()));
            return stringBuilder.ToString();
        }
    }
}
