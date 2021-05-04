using System;

public class Item
{
	private int _itemID;
	private string _name;
	private Category _category;
	private double _RRP;
	private double _discount;
	private double _price;

	public Item(string name, Category category, double RRP)
	{
		_name = name;
		_category = category;
		_RRP = RRP;
	}
}

public enum Category
{
	Makeup,
	HairCare,
	SkinCare,
	PrescriptionDrugs,
	NonPrescriptionDrugs,
	Apparel,
	Novelty
}