package VPLib;

import java.text.DecimalFormat;

public class TaxVisitor implements ITaxVisitor {
	DecimalFormat decimalFormat = new DecimalFormat("#.##");

	public double visit(Liquor liquorItem) {
		System.out.println("Liquor item");
		return Double.parseDouble(decimalFormat.format(liquorItem.getPrice() * .20));
	}

	@Override
	public double visit(Tobacco tobaccoItem) {
		System.out.println("Tobacco item");
		return Double.parseDouble(decimalFormat.format(tobaccoItem.getPrice() * .30));
	}

	@Override
	public double visit(Necessity necessityItem) {
		System.out.println("Necessity item");
		return Double.parseDouble(decimalFormat.format(necessityItem.getPrice() * .05));
	}
}
