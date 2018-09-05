using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPong;

namespace PingPong.Tests
{
	[TestClass]
	public class PingPongTest
	{
		[TestMethod]
		public void IsPingPong_InputGreaterThanZero_False()
		{
			PingPong testPingPong = new PingPong();
			Assert.AreEqual(false, testPingPong.IsPingPong(0));
		}
	}
}