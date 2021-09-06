using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;


namespace LogicalPrograms
{
	class CustomPrograms
	{
		List<int> notes = new List<int>{1000, 500, 100, 50, 10, 5, 2, 1};
		int i = 0;
       public void vendingMachine()
        {
			int money = int.Parse(Console.ReadLine());
			int rem;
			while (money != 0)
			{
				if (money >= this.notes[this.i])
				{
					int calNotes = money / this.notes[this.i];
					rem = money % this.notes[this.i];
					money = rem;
					Console.WriteLine($"{this.notes[this.i]} Notes ::::: {calNotes} ");
				}
				i++;
			}
		}
    }
}
