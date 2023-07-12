using System;
using System.Collections.Generic;

public class Product
{
	private string name;
	private decimal price;
	private float weight;

	public Product(string name, decimal price, float weight)
	{
		this.name = name;
		this.price = price;
		this.weight = weight;
	}

	public string GetName()
	{
		return name;
	}

	public void SetName(string name)
	{
		this.name = name;
	}

	public decimal GetPrice()
	{
		return price;
	}

	public void SetPrice(decimal price)
	{
		this.price = price;
	}

	public float GetWeight()
	{
		return weight;
	}

	public void SetWeight(float weight)
	{
		this.weight = weight;
	}
}

public class Buy : Product
{
	private int quantity;
	private decimal totalPrice;
	private float totalWeight;

	public Buy(string name, decimal price, float weight, int quantity)
		: base(name, price, weight)
	{
		this.quantity = quantity;
		this.totalPrice = CalculateTotalPrice();
		this.totalWeight = CalculateTotalWeight();
	}

	public int GetQuantity()
	{
		return quantity;
	}

	public void SetQuantity(int quantity)
	{
		this.quantity = quantity;
		this.totalPrice = CalculateTotalPrice(); // Оновлюємо значення загальної вартості після зміни кількості
		this.totalWeight = CalculateTotalWeight(); // Оновлюємо значення загальної ваги після зміни кількості
	}

	public decimal GetTotalPrice()
	{
		return totalPrice;
	}

	public float GetTotalWeight()
	{
		return totalWeight;
	}

	private decimal CalculateTotalPrice()
	{
		return GetPrice() * quantity;
	}

	private float CalculateTotalWeight()
	{
		return GetWeight() * quantity;
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
			Console.WriteLine("Iм'я продукту: " + item.GetName());
			Console.WriteLine("Кiлькiсть: " + item.GetQuantity());
			Console.WriteLine("Загальна сума: " + item.GetTotalPrice());
			Console.WriteLine("Загальна вага: " + item.GetTotalWeight());
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

		List<Buy> buyItems = new List<Buy>();
		buyItems.Add(buy1);
		buyItems.Add(buy2);

		Check check = new Check(buyItems);
		check.DisplayInformation();

		// Приклад використання set-методів для оновлення значень полів
		// Оновлення значення кількості товару
		buy1.SetQuantity(5);
		buy2.SetPrice(25);

		// Виведення оновленої інформації на екран
		Console.WriteLine("Оновлена Iнформацiя:");
		Console.WriteLine();
		check.DisplayInformation();

		Console.ReadLine();
	}
}
