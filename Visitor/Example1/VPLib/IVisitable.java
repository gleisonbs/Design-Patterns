package VPLib;

public interface IVisitable {
	public double getPrice();
	public double accept(ITaxVisitor visitor);
}
