package VPLib;

public interface ITaxVisitor {
	public double visit(Liquor liquorItem);
	public double visit(Tobacco tobaccoItem);
	public double visit(Necessity necessityItem);
}
