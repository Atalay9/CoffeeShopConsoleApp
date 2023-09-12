using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concrete;
using System;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace InterfaceAbstractDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            BaseCustomerService customerService = new StarbucksCustomerService(new MernisServiceAdapter());
            customerService.Save(new Entities.Customer
            {
                DateOfBirth = new DateTime(1999, 05, 24),
                FirstName = "Atalay",
                LastName = "Yılmazşimşek",
                NationalityId = "15427240656"
            });
            Console.ReadLine();
        }
    }
}