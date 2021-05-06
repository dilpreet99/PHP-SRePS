using System;
using System.Collections.Generic;

public class Salesperson
{
	private int _staffID;
	private string _firstName;
	private string _lastName;
	private string _password = "password";
	private List<Sale> _sales = new List<Sale>();
	private DateTime _dayStart;
	private DateTime _dayEnd;
	private TimeSpan _hoursThisWeek;
	private TimeSpan _hoursTotal;
	private string _fullName;

	public int StaffID { get { return _staffID; } }
	public string FirstName { get { return _firstName; } set { _firstName = value; } }
	public string LastName { get { return _lastName; } set { _lastName = value; } }
	public string Password { get { return _password; } set { _password = value; } }
	public DateTime DayStart { get { return _dayStart; } set { _dayStart = value; } }
	public DateTime DayEnd { get { return _dayEnd; } set { _dayEnd = value; } }
	public TimeSpan HoursThisWeek { get { return _hoursThisWeek; } }
	public TimeSpan HoursTotal { get { return _hoursTotal; } }
	public string FullName { get { return _fullName; } set { _fullName = value; } }

	public Salesperson(int id, string firstName, string lastName)
	{
		_staffID = id;
		_firstName = firstName;
		_lastName = lastName;
		_fullName = _firstName + " " + _lastName;
	}

	public void AddDayHours()
    {
		TimeSpan worked = _dayEnd.Subtract(_dayStart);
		_hoursThisWeek = _hoursThisWeek.Add(worked);
		_hoursTotal = _hoursTotal.Add(worked);
		_dayStart = DateTime.MinValue;
		_dayEnd = DateTime.MinValue;
    }

	public void ChangePassword(string newPassword)
    {
		//More checks here
		_password = newPassword;
    }
}
