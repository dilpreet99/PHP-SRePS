using System;
using System.Collections.Generic;

public class Business
{
	private string _name;
	private string _password;
	private DateTime _systemInstallDate;
	private List<Salesperson> _staff = new List<Salesperson>();
	private List<Item> _items = new List<Item>();
	private List<Report> _reports = new List<Report>();
	private Report _thisMonthsReport;

	private int _nextStaffID = -1;
	private int _nextItemID = -1;
	private int _nextSaleID = -1;
	private int _nextReportID = -1;

	//Normal properties
	public string Name { get { return _name; } set { _name = value; } }
	public string Password { get { return _password; } }
	public List<Salesperson> Staff { get { return _staff; } }

	//ID properties (auto-increments when fetched)
	public int NextStaffID { get { _nextStaffID++; return _nextStaffID; } }
	public int NextItemID { get { _nextItemID++; return _nextItemID; } }
	public int NextSaleID { get { _nextSaleID++; return _nextSaleID; } }
	public int NextReportID { get { _nextReportID++; return _nextReportID; } }

	public Business(string name, string password)
	{
		_name = name;
		_password = password;
		_systemInstallDate = DateTime.Now;
	}

	public void AddStaff(string firstName, string lastName)
    {
		_staff.Add(new Salesperson(NextStaffID, firstName, lastName));
    }
	public void UpdateStaff(int index, string firstName, string lastName)
    {
		_staff[index].FirstName = firstName;
		_staff[index].LastName = lastName;
		_staff[index].ListString = firstName + " " + lastName;
	}

	public void ChangePassword(string newPassword)
    {
		//More checks needed here
		_password = newPassword;
    }
}