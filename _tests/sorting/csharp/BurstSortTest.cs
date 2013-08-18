using NUnit.Framework;
using AaDS.Sorting;
using AaDS.DataProvider;

[TestFixture]
public class BurstSortTest
{
    private ISort<int> sorter;
    public DataProvider provider;

    [SetUp]
    public void Init()
    {
        this.sorter = new BurstSort<int>();
        this.provider = DataProvider.GetDataProvider();
    }

    [Test]
    public void Sort_BurstSortSimpleIntegerArray()
    {
        int[] temp = sorter.Sort((int[])provider.GetRandomData1K());

        for (int i = 0; i < temp.Length - 1; i++)
        {
            if (temp[i] > temp[i + 1])
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