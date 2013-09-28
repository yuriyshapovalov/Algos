using NUnit.Framework;
using AaDS.Lists;
using AaDS.Helper;

[TestFixture]
public class SelfOrganizedListTest
{
	// private SelfOrganizedList _testInstance;
	private DataProvider _provider;

	[SetUp]
	public void Init()
	{
		// this._testInstance = new SelfOrganizedList();
		this._provider = DataProvider.GetDataProvider();
	}

	// remove it after real code will be created
	[Test]
	public void AlwaysFailedTestStub()
	{
		Assert.Fail();
	}
}
