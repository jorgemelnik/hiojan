namespace LibraryTests;
using Library;

public class ProductSpecificationTests {
    private ProductSpecification productSpec;
    private Product product;

    [SetUp]
    public void Setup() {
        this.product = new Product("primera",2,1);
        this.productSpec = new ProductSpecification(50.5,this.product);
    }

    [Test]
    public void TestPrice(){
        Assert.AreEqual(50.5,this.productSpec.Price);
    }

    [Test]
    public void TestProduct() {
        Assert.AreEqual(this.product,this.productSpec.Product);
    }

    [Test]
    public void TestUpdatePrice()
    {
        //Arrange. 
        double expected = 60.28;
        this.productSpec.Price = 60.28;
        //Act
        double obtained = this.productSpec.Price;
        //Assert
        Assert.AreEqual(expected,obtained);
    }

}