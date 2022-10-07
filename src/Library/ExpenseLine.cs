namespace Library;
public class ExpenseLine {
    public double Price;
    public double Quantity;
    public Product Product;

    public ExpenseLine(double price, double quantity, Product product) {
        this.Price = price;
        this.Quantity = quantity;
        this.Product = product;
    }

}
