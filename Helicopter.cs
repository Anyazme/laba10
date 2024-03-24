using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba10.Program
{
	public class Helicopter : Aircraft
	{
		protected int bladesNumber;

		public int BladesNumber
		{
			get { return bladesNumber; }
			set
			{
				if (value < 0)
				{
					bladesNumber = 0;
				}
				else
				{
					bladesNumber = value;
				}
			}
		}

		public Helicopter() : base()
		{
			bladesNumber = 0;
		}

		public Helicopter(string model, int year, string type, int number, int bladesNumber) : base(model, year, type, number)
		{
			BladesNumber = bladesNumber;
		}

		public override void Show()
		{
			Console.WriteLine($"Helicopter: \nМодель = {Model}, \nГод производства = {Year}, \nТип двигателя = {Type}, \nКоличество людей экипажа = {Number}, \nКоличество лопастей = {BladesNumber}");
		}

		public override void Init()
		{
			base.Init();

			Console.WriteLine("Введите, пожалуйста, количество лопастей:");
			BladesNumber = int.Parse(Console.ReadLine());
		}

		public override void RandomInit()
		{   
			base.RandomInit();
			Random rnd = new Random();
			BladesNumber = rnd.Next(1, 500);
		}

		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
				return false;

			Helicopter otherHelicopter = (Helicopter)obj;
			return Model == otherHelicopter.Model && Year == otherHelicopter.Year && Type == otherHelicopter.Type && Number == otherHelicopter.Number && BladesNumber == otherHelicopter.BladesNumber;
		}
	}
}
