using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerProp customerProp1 = new CustomerProp();
            customerProp1.Id = 1;
            customerProp1.Name = "Mesut Özil";
            customerProp1.Age = 32;
           

            CustomerProp customerProp2 = new CustomerProp();
            customerProp2.Id = 2;
            customerProp2.Name = "Alexsandro de Souza";
            customerProp2.Age = 43;
            

            CustomerProp customerProp3 = new CustomerProp();
            customerProp3.Id = 3;
            customerProp3.Name = "Luiz Gustavo";
            customerProp3.Age = 33;

            CustomerManager customer = new CustomerManager();
            customer.CustomerAdd(customerProp1);
            customer.CustomerAdd(customerProp2);
            customer.CustomerAdd(customerProp3);

            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^");

            customer.CustomerList(customerProp1, customerProp2, customerProp3);

            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^");

            customer.CustomerDelete(customerProp1);




        }
    }
}
