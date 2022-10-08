namespace LibraryTests;
using Library;

public class ProductTests {
    private Product product;

    [SetUp]
    public void Setup() {
        this.product = new Product("primera",2,1);
    }

    [Test]
    public void TestProductName() {
        Assert.AreEqual("primera",this.product.Name);
    }

    [Test]
    public void TestProductCalification() {
        Assert.AreEqual(2,this.product.Calification);
    }

    [Test]
    public void TestProductCategory() {
        Assert.AreEqual(1,this.product.Category);
    }

    [Test]
    public void TestUpdateCategory() {
        //Arrange : 
        int expected = 2;
        this.product.Category = 2;
        //Act
        int obtained = this.product.Category;
        //Assert
        Assert.AreEqual(expected,obtained);
    }

    [Test]
    public void TestUpdateCalification() {
        //Arrange : 
        int expected = 3;
        this.product.Calification = 3;
        //Act
        int obtained = this.product.Calification;
        //Assert
        Assert.AreEqual(expected,obtained);
    }
}