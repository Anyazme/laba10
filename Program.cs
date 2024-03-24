﻿using System;
using System.Numerics;
using laba10.Program;

namespace laba10.Program
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Воздушное судно без параметров");
			Aircraft a1 = new Aircraft();
			a1.Show();
			Console.WriteLine();
			
			Console.WriteLine("Воздушное судно с параметрами");
			Aircraft a2 = new Aircraft("Boeing 737", 2015, "GMF-67", 15);
			a2.Show();
			Console.WriteLine();

			Console.WriteLine("Выберите способ создания объекта Aircraft:");
			Console.WriteLine("1. Ввести данные вручную, 2. Инициализировать случайными значениями ");

			int answer = int.Parse(Console.ReadLine());
			Aircraft aircraft = new Aircraft();

			switch (answer)
			{
				case 1:
				{
					aircraft.Init(); break;
				}
				case 2:
				{
						aircraft.RandomInit(); break;
				}
			}
			aircraft.Show();
			Console.WriteLine();

			Console.WriteLine("Самолёт без параметров");
			Plane p1 = new Plane();
			p1.Show();
			Console.WriteLine();

			Console.WriteLine("Самолёт с параметрами");
			Plane p2 = new Plane("Boeing 666", 2021, "ZHFBR  - 234", 9, 230, 1500);
			p2.Show();
			Console.WriteLine();

			Console.WriteLine("Выберите способ создания объекта Plane:");
			Console.WriteLine("1. Ввести данные вручную, 2. Инициализировать случайными значениями ");

			int choice = int.Parse(Console.ReadLine());
			Plane plane = new Plane();

			switch (choice)
			{
				case 1:
					{
						plane.Init(); break;
					}
				case 2:
					{
						plane.RandomInit(); break;
					}
			}
			plane.Show();
			Console.WriteLine();

			Console.WriteLine("Вертолёт без параметров");
			Helicopter h1 = new Helicopter();
			h1.Show();
			Console.WriteLine();
			
			Console.WriteLine("Вертолёт с параметрами");
			Helicopter h2 = new Helicopter("Модель 456", 2001, "JUFC - 7", 15, 7);
			h2.Show();
			Console.WriteLine();

			Console.WriteLine("Выберите способ создания объекта Helicopter:");
			Console.WriteLine("1. Ввести данные вручную, 2. Инициализировать случайными значениями ");

			int ans = int.Parse(Console.ReadLine());
			Helicopter helicopter = new Helicopter();

			switch (ans)
			{
				case 1:
					{
						helicopter.Init(); break;
					}
				case 2:
					{
						helicopter.RandomInit(); break;
					}
			}
			helicopter.Show();
			Console.WriteLine();


			Console.WriteLine("Истребитель без параметров");
			Fighter f1 = new Fighter();
			f1.Show();
			Console.WriteLine();

			Console.WriteLine("Истребитель с параметрами");
			Fighter f2 = new Fighter("Модель 595", 1947, "Smash", 3, 200, 4000, "Мегамощный");
			f2.Show();
			Console.WriteLine();

			Console.WriteLine("Выберите способ создания объекта Fighter:");
			Console.WriteLine("1. Ввести данные вручную, 2. Инициализировать случайными значениями ");

			int reply = int.Parse(Console.ReadLine());
			Fighter fighter = new Fighter();

			switch (reply)
			{
				case 1:
					{
						fighter.Init(); break;
					}
				case 2:
					{
						fighter.RandomInit(); break;
					}
			}
			fighter.Show();
			Console.WriteLine();

			Console.WriteLine("Библиотека классов:");
			Aircraft[] arr = new Aircraft[20];
			Random random = new Random();

			for (int i = 0; i < 5; i++)
			{
				arr[i] = new Aircraft();
				arr[i].RandomInit();
			}

			for (int i = 5; i < 10; i++)
			{
				arr[i] = new Plane();
				arr[i].RandomInit();
			}

			for (int i = 10; i < 15; i++)
			{
				arr[i] = new Helicopter();
				arr[i].RandomInit();
			}

			for (int i = 15; i < 20; i++)
			{
				arr[i] = new Fighter();
				arr[i].RandomInit();
			}
			foreach (Aircraft item in arr) 
			{
				item.Show();
				Console.WriteLine();
			}

		}
	}
}
