using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _06_Database.DataObjects;
using _06_Database.Facades;

namespace _06_Database
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var clients = new ClientFacade();

            Console.WriteLine("��� �������:");
            foreach (Client client in clients.All())
            {
                Console.WriteLine(client);
            }

            Console.WriteLine("������� ��� ��������:");
            foreach (Client client in clients.WithoutInvoices())
            {
                Console.WriteLine(client);
            }

            Console.WriteLine("�������, � ������� ����� �������� ������ 1500 ���:");
            foreach (Client client in clients.WithInvoicesWithSumGreaterThan(1500m))
            {
                Console.WriteLine(client);
            }

            Console.ReadLine();
        }
    }
}
