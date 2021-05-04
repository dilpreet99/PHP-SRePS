using System;
using System.Collections.Generic;

public class Salesperson
{
	private int _staffID;
	private string _firstName;
	private string _lastName;
	//private List<Sale> _sales = new List<Sale>;
	private DateTime _hoursThisWeek;
	private DateTime _hoursTotal;

	public Salesperson(string firstName, string lastName)
	{
		_firstName = firstName;
		_lastName = lastName;
	}
}
