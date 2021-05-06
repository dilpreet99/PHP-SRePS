using System;
using System.Collections.Generic;

public class Salesperson
{
	private int _staffID;
	private string _firstName;
	private string _lastName;
	private List<Sale> _sales = new List<Sale>();
	private DateTime _hoursThisWeek;
	private DateTime _hoursTotal;
	private string _listString;

	public int StaffID { get { return _staffID; } }
	public string FirstName { get { return _firstName; } set { _firstName = value; } }
	public string LastName { get { return _lastName; } set { _lastName = value; } }
	public string ListString { get { return _listString; } set { _listString = value; } }

	public Salesperson(int id, string firstName, string lastName)
	{
		_staffID = id;
		_firstName = firstName;
		_lastName = lastName;
		_listString = _firstName + " " + _lastName;
	}
}
