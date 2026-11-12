
using System;

using NUnit.Framework;

namespace retouch
{
	[TestFixture]
	public class ProgramTests
	{
		[Test]
		public void IsTrue()
		{
			Assert.IsTrue(true);
		}
		
		[Test]
		[TestCase(1, 1)]
		[TestCase(2, 3)]
		public void IsEqual(int a, int b)
		{
			int c = Program.Add(a, b);
			Assert.AreEqual(a + b, c);
		}
	}
}
