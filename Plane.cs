using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using laba10.Program;

namespace laba10.Program
{
	public class Plane : Aircraft
	{
		protected int passengersNumber;
		protected int range;

		public int PassengersNumber
		{
			get { return passengersNumber; }
			set
			{
				if (value < 0)
				{
					passengersNumber = 0;
				}
				else
				{
					passengersNumber = value;
				}
			}
		}
		public int Range
		{
			get { return range; }
			set
			{
				if (value < 0)
				{
					range = 0;
				}
				else
				{
					range = value;
				}
			}
		}

		public Plane() : base() 
		{ 
			passengersNumber = 0;
			range = 0;
		}

		public Plane(string model, int year, string type, int number, int passengersNumber, int range) : base(model, year, type, number)
		{
			PassengersNumber = passengersNumber;
			Range = range;
		}

		public override void Show()
		{
			Console.WriteLine($"Plane: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number}, \nКоличество пассажиров {PassengersNumber}, \nДальность полета = {Range}");
		}


		public override void Init()
		{
			base.Init();

			Console.WriteLine("Введите, пожалуйста, год производства:");
			PassengersNumber = int.Parse(Console.ReadLine());

			Console.WriteLine("Введите, пожалуйста, количество членов экипажа:");
			Range = int.Parse(Console.ReadLine());
		}

		public override void RandomInit()
		{
			base.RandomInit();

			Random rnd = new Random();
			PassengersNumber = rnd.Next(1, 500);
			Range = rnd.Next(1, 10000);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Plane otherPlane = (Plane)obj;
			return Model == otherPlane.Model && Year == otherPlane.Year && Type == otherPlane.Type && Number == otherPlane.Number && PassengersNumber == otherPlane.PassengersNumber && Range == otherPlane.Range;
		}
	}
}


