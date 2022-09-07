namespace TestDateFormat;

[TestFixture]
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void DateFormatOK()
    {
        string expected = DateFormatter.ChangeFormat("30/12/2003");
        string actual = "2003-12-30";
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void DateFormatNotOK()
    {
        string expected = DateFormatter.ChangeFormat("30122003");
        string actual = "2003-12-30";
        Assert.AreNotEqual(expected, actual);
    }
    
    [Test]
    public void DateBlank()
    {
        string expected = DateFormatter.ChangeFormat("");
        Assert.IsEmpty(expected);
    }
}