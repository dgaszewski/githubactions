// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!" + (new MockedDataProvider()).GenerateNumber(0));


public class MockedDataProvider : IDataProvider
{
    public int GenerateNumber(int startNumber)
    {
        return 5 + startNumber;
    }
}

public interface IDataProvider
{
    int GenerateNumber(int startNumber);
}