package VPLib;

public class Necessity implements IVisitableItem {
	private double price;
	
	public double getPrice() {
		return price;
	}

	public Necessity(double price) {
		this.price = price;
	}

	public double accept(ITaxVisitor visitor) {
		return visitor.visit(this);
	}
}
