package VPLib;

import java.text.DecimalFormat;

public class TaxHolidayVisitor implements ITaxVisitor {
	DecimalFormat decimalFormat = new DecimalFormat("#.##");

	public double visit(Liquor liquorItem) {
		System.out.println("Liquor item");
		return Double.parseDouble(decimalFormat.format(liquorItem.getPrice() * .10));
	}

	@Override
	public double visit(Tobacco tobaccoItem) {
		System.out.println("Tobacco item");
		return Double.parseDouble(decimalFormat.format(tobaccoItem.getPrice() * .10));
	}

	@Override
	public double visit(Necessity necessityItem) {
		System.out.println("Necessity item");
		return Double.parseDouble(decimalFormat.format(necessityItem.getPrice() * .02));
	}
}
