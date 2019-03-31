package VPLib;

public class Liquor implements IVisitableItem {
	private double price;
	
	public double getPrice() {
		return price;
	}

	public Liquor(double price) {
		this.price = price;
	}
	
	public double accept(ITaxVisitor visitor) {
		return visitor.visit(this);
	}
}
