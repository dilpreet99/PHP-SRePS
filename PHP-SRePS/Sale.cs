using System;
using System.Collections.Generic;

public class Sale
{
	private int _saleID;
	private DateTime _time;
	private List<Item> _items = new List<Item>();
	private double _total;
	private Salesperson _salesperson;
	private string notes;

	public Sale(Salesperson salesperson)
	{
		_salesperson = salesperson;
	}
}
