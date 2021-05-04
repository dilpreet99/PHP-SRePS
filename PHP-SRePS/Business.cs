using System;
using System.Collections.Generic;

public class Business
{
	private string _name;
	private DateTime _systemInstallDate;
	//private List<Salesperson> _staff = new List<Salesperson>;
	//private List<Item> _items = new List<Item>;
	//private List<Report> _reports = new List<Report>;
	//private Report _thisMonthsReport;

	public Business(string name, DateTime installDate)
	{
		_name = name;
		_systemInstallDate = installDate;
	}
}
