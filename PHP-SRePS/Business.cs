using System;
using System.Collections.Generic;

public class Business
{
	private string _name;
	private DateTime _systemInstallDate;
	private List<Salesperson> _staff = new List<Salesperson>();
	private List<Item> _items = new List<Item>();
	private List<Report> _reports = new List<Report>();
	private Report _thisMonthsReport;

	private int _nextStaffID = -1;
	private int _nextItemID = -1;
	private int _nextSaleID = -1;
	private int _nextReportID = -1;

	//ID properties (auto-increments when fetched)
	public int NextStaffID { get { _nextStaffID++; return _nextStaffID; } }
	public int NextItemID { get { _nextItemID++; return _nextItemID; } }
	public int NextSaleID { get { _nextSaleID++; return _nextSaleID; } }
	public int NextReportID { get { _nextReportID++; return _nextReportID; } }

	public Business(string name, DateTime installDate)
	{
		_name = name;
		_systemInstallDate = installDate;
	}

	public void AddStaff(string firstName, string lastName)
    {
		_staff.Add(new Salesperson(firstName, lastName));
    }
}