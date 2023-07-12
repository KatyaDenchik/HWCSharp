using System;
using System.Collections.Generic;

public class Product
{
	public string Name { get; set; }
	private decimal price;
	public decimal Price 
	{ 
		get => price; 
		set 
		{ 
			if (value > 0) 
			{
				price = value; 
			} 
		} 
	}
	private float weight;
	public float Weight
	{ 
		get => weight;
		set
		{
			if (value > 0)
			{
				weight = value;
			}
		}
	}

	public Product(string name, decimal price, float weight)
	{
		Name = name;
		Price = price;
		Weight = weight;
	}
}

public class Buy : Product
{
	private int quantity;
	public int Quantity
	{ 
		get => quantity;
		set
		{
			if (value > 0)
			{
				quantity = value;
			}
		}
	}
	private decimal totalPrice;
	public decimal TotalPrice
	{
		get
		{
			return CalculateTotalPrice();
		}
		set
		{
			if (value > 0)
			{
				totalPrice = value;
			}
		}
	}

	private float totalWeight;
	public float TotalWeight
	{
		get
		{
			return CalculateTotalWeight();
		}
		set
		{
			if (value > 0)
			{
				totalWeight = value;
			}
		}
	}

	public Buy(string name, decimal price, float weight, int quantity)
		: base(name, price, weight)
	{
		Quantity = quantity;
	}

	private decimal CalculateTotalPrice()
	{
		return Price * quantity;
	}

	private float CalculateTotalWeight()
	{
		return Weight * quantity;
	}
}

public class Check
{
	private List<Buy> buyItems;

	public Check(List<Buy> buyItems)
	{
		this.buyItems = buyItems;
	}

	public void DisplayInformation()
	{
		foreach (Buy item in buyItems)
		{
			Console.WriteLine("Iм'я продукту: " + item.Name);
			Console.WriteLine("Кiлькiсть: " + item.Quantity);
			Console.WriteLine("Загальна сума: " + item.TotalPrice);
			Console.WriteLine("Загальна вага: " + item.TotalWeight);
			Console.WriteLine();
		}
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Product product1 = new Product("Морква", 23, 5);
		Product product2 = new Product("Картопля", 54, 7);

		Buy buy1 = new Buy("Морква", 23, 5, 8);
		Buy buy2 = new Buy("Картопля", 54, 7, 10);

		List<Buy> buyItems = new List<Buy>
		{
			buy1,
			buy2
		};
		Check check = new Check(buyItems);
		check.DisplayInformation();

		// Приклад використання set-методів для оновлення значень полів
		// Оновлення значення кількості товару
		buy1.Quantity = 5;
		buy2.Price = 25;

		// Виведення оновленої інформації на екран
		Console.WriteLine("Оновлена Iнформацiя:");
		Console.WriteLine();
		check.DisplayInformation();

		Console.ReadLine();
	}
}
