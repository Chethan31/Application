using CompanyOrders;

Company company = new Company();
Item i1= new Item {Rate=10};
Item i2= new Item {Rate=20};        
Item i3= new Item {Rate=30}; 
Item i4= new Item {Rate=40};
Item i5= new Item {Rate=50};
Item i6= new Item {Rate=60};

company.items.Add(i1);
company.items.Add(i2);
company.items.Add(i3);
company.items.Add(i4);
company.items.Add(i5);
company.items.Add(i6);

RegCustomer c1 = new RegCustomer();
c1.Discount = 10;
company.customers.Add(c1);

Order o1 = new Order();
c1.OrderList.Add(o1);

OrderedItem ot1 = new OrderedItem { Qty=1, item=i1 };
o1.orderedItems.Add(ot1);

Console.WriteLine($"Total Worth:{company.GetTotalWorthOfOrdersPlaced()}");

