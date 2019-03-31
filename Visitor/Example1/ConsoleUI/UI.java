package ConsoleUI;

import VPLib.*;

public class UI {
	public static void main(String[] args)
	{
		System.out.println("Visitor Design Pattern");
		IVisitableItem item = new Necessity(4);
		ITaxVisitor taxVisitor = new TaxVisitor();
		ITaxVisitor taxHolidayVisitor = new TaxHolidayVisitor();
		
		System.out.print(String.valueOf(item.getPrice()) + " + " + item.accept(taxVisitor) + " + " + item.accept(taxHolidayVisitor));
	}
}
