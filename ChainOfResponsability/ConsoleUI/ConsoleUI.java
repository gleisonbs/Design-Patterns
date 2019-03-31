package ConsoleUI;

import CRLib.AddNumbers;
import CRLib.CalculationWanted;
import CRLib.MultiplyNumbers;
import CRLib.Numbers;
import CRLib.SubtractNumbers;

public class ConsoleUI {
	public static void main(String [] args) {
		Numbers numbers = new Numbers(2, 3, CalculationWanted.MULTIPLICATION);
		
		AddNumbers add = new AddNumbers();
		SubtractNumbers subtract = new SubtractNumbers();
		MultiplyNumbers multiply = new MultiplyNumbers();
		
		add.setNextChain(subtract);
		subtract.setNextChain(multiply);
		
		add.calculate(numbers);
	}
}
