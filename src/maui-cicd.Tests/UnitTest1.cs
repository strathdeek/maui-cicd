using NUnit.Framework;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Graphics;
using Tests;

namespace maui_cicd.Tests;

public class Tests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestsWorkingSuccessfully()
    {
        Assert.Pass();
    }

    [Test]
    public void TestCounterFromMauiProject()
    {
        var counter = new CounterService(0);
        Assert.AreEqual(0,counter.Count);
        counter.Increment();
        Assert.AreEqual(1,counter.Count);
        counter.Increment();
        Assert.AreEqual(2,counter.Count);
        counter.Decrement();
        Assert.AreEqual(1,counter.Count);
    }
}