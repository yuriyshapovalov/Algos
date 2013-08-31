using NUnit.Framework;
using AaDS.Sorting;
using AaDS.DataProvider;

[TestFixture]
public class UnshuffleSortTest
{
    private ISort<int> sorter;
    public DataProvider provider;

    private SortingBasicTester<int> _basicTester;
    private SortingPerformanceTester<int> _perfTester;

    [SetUp]
    public void Init()
	{
        this.sorter = new UnshuffleSort<int>();
        this.provider = DataProvider.GetDataProvider();

        this._basicTester = new SortingBasicTester<int>();
        this._perfTester = new SortingPerformanceTester<int>();
	}
    
    // basic tests
    [Test]
    public void SortTest()
    {
 
    }


    [Test]
    public void Sort_UnshuffleSortSimpleIntegerArray()
    {
        int[] temp = sorter.Sort((int[])provider.GetRandomData1K());

        for(int i = 0; i < temp.Length-1; i++)
        {
            if (temp[i] > temp[i+1])
            {
                Assert.Fail();
            }
        }

    }

    [Test]
    public void Sort_EmptyArray()
    {
    }

    [Test]
    public void Sort_OneElementArray()
    {
    }
}
