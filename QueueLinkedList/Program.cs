using System;

namespace QueueLinkedList
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			QueueLL qll = new QueueLL ();
			qll.Enqueue ("1");
			qll.Enqueue ("2");
			qll.Enqueue ("3");
			qll.Enqueue ("4");
			qll.Enqueue ("5");
			qll.Enqueue ("6");

			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());

			qll.Enqueue ("1");
			qll.Enqueue ("5");
			qll.Enqueue ("6");
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());
			Console.WriteLine ("Dequeue :"+qll.Dequeue());

			//Console.WriteLine ("Hello World!");
		}
	}
}
