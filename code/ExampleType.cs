namespace Test;
public class ExampleTypeMain
{
	public string HelloWorld { get; set; }
}

public static class Example<T> where T : new()
{
	public static int PropertyCount()
	{
		var example = new T();
		return TypeLibrary.GetPropertyDescriptions( example ).Length;
	}
}
