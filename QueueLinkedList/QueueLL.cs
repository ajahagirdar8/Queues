using System;

namespace QueueLinkedList
{
	public class QueueLL
	{
		Node firstNode ,lastNode;

		public int nodeCount{ get; set; }

		public QueueLL()
		{
			//firstNode = lastNode = new Node ();
		}

		public class Node
		{
			public string data { get; set;}
			public Node node{ get; set;}
		}


		public void Enqueue(string item)
		{
			Node newNode = new Node ();
			newNode.data = item;

			if (nodeCount == 0) {
				firstNode = lastNode = newNode;
				newNode.node = null;

			} else {
				Node oldLastnode = lastNode;

				oldLastnode.node = newNode;

				lastNode = newNode;
			}
			nodeCount++;
		}

		public string Dequeue()
		{
			string item;

			if (nodeCount == 0) {
				item = null;

			}
			else {

				Node oldFirst = firstNode;
				item = oldFirst.data;

				firstNode = oldFirst.node;

				oldFirst = null;
				nodeCount--;
			}

			return item;
		}

	}
}

