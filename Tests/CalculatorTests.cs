using NUnit.Framework;
using BridgeLabzApp.Calculators;
namespace BridgeLabzApp.Tests;

public class CalculatorTests
{
    private Calculator _calculator;
    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [TestCase(1,2,'+',3)]
    [TestCase(4,2,'/',2)]
    public void Add_ReturnCorrectSum(int a,int b ,char ch,int result)
    {
        int res = _calculator.Calculate(a,ch,b);
        Assert.That(result,Is.EqualTo(res));
    }
}