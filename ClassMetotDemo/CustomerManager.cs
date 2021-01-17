using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void CustomerAdd(CustomerProp custmerprop)
        {

            Console.WriteLine(custmerprop.Name + " " + custmerprop.Age + " - " + "Customer added ");
        
        }


        public void CustomerList(params CustomerProp[] props)
        {

            for (int i = 0; i < props.Length; i++)
            {
                Console.WriteLine(props[i].Name + " " + props[i].Age + " - " + "Customers listed");

            }
           
        }
        public void CustomerDelete(CustomerProp customerprop)
        {

            Console.WriteLine(customerprop.Name + " " + customerprop.Age +" - "+ "Deleted");
        
        }
        

        









    }
}
        

