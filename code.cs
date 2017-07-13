// query syntax

var query = from c in customerList
		where c.customerId == customerId
		select c;

foundCustomer = query.First();

// method syntax

foundCustomer = customerList.FirstOrDefault(
	c.customerId == customerId);

foundCustomer = customerList.FirstOrDefault(
			c=> {
				Debug.WriteLine(c.LastName);
				return c.customerId == customerId;
				});

// when we want to find the second entry that matches the
// criteria

foundCustomer = customerList.Where( c => 
		c.customerId == customerId)
		.Skip(1)
		.FirstOrDefault();