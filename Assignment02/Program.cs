/*
 * Author: Yifen Lin
 * 
 * Purpose: Assignment 1
 * Date: 2022-02-11
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Assignment02
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Rectangle rectangle = new Rectangle();

			int l = inputLength();
			rectangle.SetLength(l);

			int w = inputWidth();
			rectangle.SetWidth(w);

			menu: Console.WriteLine("=======================");
			Console.WriteLine("1. Get Rectangle Length \n2.Change Rectangle Length \n3.Get Rectangle Width \n4.Change Rectangle Width \n5.Get Rectangle Perimeter \n6.Get Rectangle Area \n7.Exit");
			Console.WriteLine("=======================");

			int i = Convert.ToInt32(Console.ReadLine());
			switch (i)
			{
				case 1:
					l = rectangle.GetLength();
					Console.WriteLine("Rectangle Length: " + l);
					Console.WriteLine("=======================");
					goto menu;
					
				case 2:
					 l = inputLength();
					rectangle.SetLength(l);
					Console.WriteLine("=======================");
					goto menu;

				case 3:
					w = rectangle.GetWidth();
					Console.WriteLine("Rectangle Width: " + w);
					Console.WriteLine("=======================");
					goto menu;

				case 4:
					 w = inputWidth();
					rectangle.SetWidth(w);
					Console.WriteLine("=======================");
					goto menu;

				case 5:
					int p = rectangle.GetPerimeter();
					Console.WriteLine("Rectangle Perimeter: " + p);
					Console.WriteLine("=======================");
					goto menu;

				case 6:
					int a = rectangle.GetArea();
					Console.WriteLine("Rectangle Area: " + a);
					Console.WriteLine("=======================");
					goto menu;

				case 7:
					Environment.Exit(0);
					break;

				default:
					goto menu;
						
			}

			Console.ReadLine();
		}

		public static int inputLength()
		{
			
			Console.WriteLine("Please enter the length of rectangle: ");
			string inLength = Console.ReadLine();
			int l = 0;
			try
			{
				 l= Convert.ToInt32(inLength);
				if (l > 0)
				{
					return l;
				}
				else
				{
					Console.WriteLine("please enter a value again");
					return inputLength();
				}
			}
			catch(Exception ex)
			{
				Console.WriteLine( "please enter a value again");
				return inputLength();
			}
		}

		public static int inputWidth()
		{
			Rectangle rectangle = new Rectangle();

			Console.WriteLine("Please enter the width of rectangle: ");
			string inWidth = Console.ReadLine();
			int w = 0;
			try
			{
				w = Convert.ToInt32(inWidth);
				if (w > 0)
				{
					return w;
				}
				else
				{
					Console.WriteLine("please enter a value again");
					return inputWidth();
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine("please enter a value again");
				return inputWidth();
			}
		}


	}
}
