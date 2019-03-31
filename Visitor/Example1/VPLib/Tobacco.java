package VPLib;

public class Tobacco implements IVisitableItem {
	private double price;
	
	public double getPrice() {
		return price;
	}

	public Tobacco(double price) {
		this.price = price;
	}

	public double accept(ITaxVisitor visitor) {
		return visitor.visit(this);
	}
}
