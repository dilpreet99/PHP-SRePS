using System;
using System.Collections.Generic;

public class BusinessDay
{
	private List<Salesperson> _staff = new List<Salesperson>();
	private List<Sale> _sales = new List<Sale>();
	private DateTime _openTime;
	private DateTime _closeTime;

	public BusinessDay(DateTime openTime)
	{
		_openTime = openTime;
	}
}
