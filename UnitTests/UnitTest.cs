global using Microsoft.VisualStudio.TestTools.UnitTesting;

using Test;

[TestClass]
public class TestInit
{
	[AssemblyInitialize]
	public static void ClassInitialize( TestContext context )
	{
		Sandbox.Application.InitUnitTest<ExampleTests>();
	}
}
