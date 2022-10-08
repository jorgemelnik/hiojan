namespace Library;
public class Expense {
    public DateTime Date;
    public Place Place {get;}
    public List<ExpenseLine> lines;

    public Expense (DateTime date, Place place) {
        this.Date = date;
        this.lines = new List<ExpenseLine>();
        this.Place = place;
    }

    public void addLine(double price, double quantity, Product product) {
        this.lines.Add(new ExpenseLine(price,quantity,product));
    }

}
