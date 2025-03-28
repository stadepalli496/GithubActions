using GithubActionsLab;
namespace GithubActionsLab;

[TestClass]
public class Addition
{
	[TestMethod]
	public void Add_Valid_Tadepalli()
	{
		Assert.AreEqual(3, Program.Add("1", "2"));
		Assert.AreEqual(5, Program.Add("3", "2"));
		Assert.AreEqual(12, Program.Add("5", "7"));
	}

	[TestMethod]
	public void Add_Invalid_Tadepalli()
	{
		Assert.ThrowsException<FormatException>(() => Program.Add("1", "a"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "1"));
		Assert.ThrowsException<FormatException>(() => Program.Add("a", "a"));
	}

	[TestMethod]
	public void Add_Null_Tadepalli()
	{
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add("1", null));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, "1"));
		Assert.ThrowsException<ArgumentNullException>(() => Program.Add(null, null));
	}
}

[TestClass]
public class Subtraction
{
    [TestMethod]
    public void Subtract_Valid_Tadepalli()
    {
        Assert.AreEqual(4, Program.Subtract("5", "1"));
        Assert.AreEqual(3, Program.Subtract("6", "3"));
        Assert.AreEqual(-5, Program.Subtract("3", "8"));
    }

    [TestMethod]
    public void Subtract_Invalid_Tadepalli()
    {
        Assert.ThrowsException<FormatException>(() => Program.Subtract("1", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "1"));
        Assert.ThrowsException<FormatException>(() => Program.Subtract("a", "a"));
    }

    [TestMethod]
    public void Subtract_Null_Tadepalli()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract("1", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, "1"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Subtract(null, null));
    }
}

[TestClass]
public class Multiplication
{
    [TestMethod]
    public void Multiply_Valid_Tadepalli()
    {
        Assert.AreEqual(6, Program.Multiply("2", "3"));
        Assert.AreEqual(15, Program.Multiply("5", "3"));
        Assert.AreEqual(0, Program.Multiply("0", "7"));
    }

    [TestMethod]
    public void Multiply_Invalid_Tadepalli()
    {
        Assert.ThrowsException<FormatException>(() => Program.Multiply("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "3"));
        Assert.ThrowsException<FormatException>(() => Program.Multiply("a", "a"));
    }

    [TestMethod]
    public void Multiply_Null_Tadepalli()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Multiply(null, null));
    }
}

[TestClass]
public class Division
{
    [TestMethod]
    public void Divide_Valid_Tadepalli()
    {
        Assert.AreEqual(2, Program.Divide("6", "3"));
        Assert.AreEqual(5, Program.Divide("10", "2"));
        Assert.AreEqual(1, Program.Divide("0", "5"));
    }

    [TestMethod]
    public void Divide_Invalid_Tadepalli()
    {
        Assert.ThrowsException<FormatException>(() => Program.Divide("6", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "2"));
        Assert.ThrowsException<FormatException>(() => Program.Divide("a", "a"));
    }

    [TestMethod]
    public void Divide_Null_Tadepalli()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide("6", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Divide(null, null));
    }

}

[TestClass]
public class Exponentiation
{
    [TestMethod]
    public void Power_Valid_Tadepalli()
    {
        Assert.AreEqual(8, Program.Power("2", "3"));
        Assert.AreEqual(1, Program.Power("5", "0"));
        Assert.AreEqual(16, Program.Power("4", "2"));
    }

    [TestMethod]
    public void Power_Invalid_Tadepalli()
    {
        Assert.ThrowsException<FormatException>(() => Program.Power("2", "a"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "3"));
        Assert.ThrowsException<FormatException>(() => Program.Power("a", "a"));
    }

    [TestMethod]
    public void Power_Null_Tadepalli()
    {
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power("2", null));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, "3"));
        Assert.ThrowsException<ArgumentNullException>(() => Program.Power(null, null));
    }
}



