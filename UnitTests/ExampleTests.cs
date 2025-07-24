namespace Test;

public class ExampleTypeUnitTest
{
	public string HelloWorld { get; set; }
}

[TestClass]
public partial class ExampleTests
{
	[TestMethod]
	public void MainType()
	{
		Assert.AreEqual( Example<ExampleTypeMain>.PropertyCount(), 1 );
	}

	[TestMethod]
	public void UnitTestType()
	{
		Assert.AreEqual( Example<ExampleTypeUnitTest>.PropertyCount(), 1 );
	}
}
