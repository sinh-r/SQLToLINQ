using SQLToLINQ;

var customers = CustomerProcessor.FetchAllCustomers();

CustomerProcessor.PrintAllCustomers(customers);
Console.WriteLine("-----------------------------------------------------------------------");
CustomerProcessor.PrintCustomerName(customers);
Console.WriteLine("-----------------------------------------------------------------------");
CustomerProcessor.PrintCustomerNameAndAddress(customers);
Console.WriteLine("-----------------------------------------------------------------------");
CustomerProcessor.PrintCustomer(customers, 3);
Console.WriteLine("-----------------------------------------------------------------------");
CustomerProcessor.PrintTopNCustomers(customers, 3);
Console.WriteLine("-----------------------------------------------------------------------");
CustomerProcessor.PrintDistinctAddressCustomers(customers);