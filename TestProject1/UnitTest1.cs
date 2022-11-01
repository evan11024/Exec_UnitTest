using ClassTaiwanStockUtility;
using System.Transactions;

namespace TestProject1
{
	public class Tests
	{
		
		[SetUp]
		public void Setup()
		{
			
		}
		

		[Test]
		public void IsTradingTime_�P������()
		{
			var dt = new TaiwanStockUtility();
			DateTime dateTime = new DateTime(2022,10,29);
			bool answer = dt.IsTradingTime(dateTime);
			Assert.AreEqual(answer,false);
		}
		[Test]
		

		public void IsTradingTime_�w�L����ɶ�()
		{
			DateTime dt1 = new DateTime(2022, 10, 27, 15, 31, 00);
			var date = new TaiwanStockUtility();
			bool result = date.IsTradingTime(dt1);
			Assert.AreEqual(result, false);
		}
		[Test]
		public void IsTradingTime_�w�L����ɶ�2()
		{
			DateTime dt2 = new DateTime(2022, 10, 27, 08, 30, 00);
			var date = new TaiwanStockUtility();
			bool result = date.IsTradingTime(dt2);
			Assert.AreEqual(result, false);
		}
		[Test]
		public void IsTradingTime_����ɶ���()
		{
			DateTime dt3 = new DateTime(2022, 10, 27, 09, 18, 00);
			var date = new TaiwanStockUtility();
			bool result = date.IsTradingTime(dt3);
			Assert.AreEqual(result, true);
		}
	}
	
}