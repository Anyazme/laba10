using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba10.Program;

namespace laba10.Program
{
	public class Aircraft
	{
		//инициализация атрибутов
		protected string model;
		protected int year;
		protected string type;
		protected int number;

		//свойство модели (для хранения)
		public string Model { get; set; }

		//свойство для года производства
		public int Year
		{
			get { return year; }
			set
			{
				if (value >= 1900 && value <= DateTime.Now.Year)
				{
					year = value;
				}
				else
				{
					year = 0;
				}
			}
		}
		//свойство типа двигателя (для хранения)
		public string Type { get; set; }

		//свойство для количества членов экипажа
		public int Number
		{
			get { return number; }
			set
			{
				if (value < 0)
				{
					number = 0;
				}
				else
				{
					number = value;
				}
			}
		}

		//конструктор (без параметров)
		public Aircraft()
		{
			Model = "Нет";
			Year = 0;
			Type = "Нет";
			Number = 0;
		}

		//конструктор (с параметрами)
		public Aircraft(string model, int year, string type, int number)
		{
			Model = model;
			Year = year;
			Type = type;
			Number = number;
		}

		public virtual void Show()
		{
			Console.WriteLine($"Aircraft: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number}");
		}

		public virtual void Init()
		{
			Console.WriteLine("Введите, пожалуйста, модель:");
			Model = Console.ReadLine();

			Console.WriteLine("Введите, пожалуйста, год производства:");
			Year = int.Parse(Console.ReadLine());

			Console.WriteLine("Введите, пожалуйста, тип двигателя:");
			Type = Console.ReadLine();

			Console.WriteLine("Введите, пожалуйста, количество членов экипажа:");
			Number = int.Parse(Console.ReadLine());
		}

		public virtual void RandomInit()
		{
			Random rnd = new Random();
			Model = "Модель" + rnd.Next(1000);
			Year = rnd.Next(1900, DateTime.Now.Year + 1);
			Type = "Двигатель" + rnd.Next(100);
			Number = rnd.Next(1, 100);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Aircraft other = (Aircraft)obj;
			return Model == other.Model && Year == other.Year && Type == other.Type && Number == other.Number;
		}
	}
}

