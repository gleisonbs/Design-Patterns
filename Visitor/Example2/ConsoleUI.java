import vpLib.creditCards.BronzeCreditCard;
import vpLib.creditCards.CreditCard;
import vpLib.offers.GasOfferVisitor;
import vpLib.offers.HotelOfferVisitor;

public class ConsoleUI {
	public static void main(String [ ] args)
	{
		CreditCard creditCard = new BronzeCreditCard();
		creditCard.accept(new GasOfferVisitor());
	}
}
