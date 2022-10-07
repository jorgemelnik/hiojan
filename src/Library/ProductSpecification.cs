namespace Library;
public class ProductSpecification
{
    public double Price;
    public Product Product { get;}

    public ProductSpecification(double price, Product product){
        this.Price = price;
        this.Product = product;
    }

}

//José Luis Dilaxio.