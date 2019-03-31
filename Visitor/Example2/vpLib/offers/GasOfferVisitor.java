package vpLib.offers;

import vpLib.creditCards.BronzeCreditCard;
import vpLib.creditCards.GoldCreditCard;
import vpLib.creditCards.SilverCreditCard;

public class GasOfferVisitor implements OfferVisitor {

	@Override
	public void visitBronzeCreditCard(BronzeCreditCard bronzeCreditCard) {
		System.out.println("Bronze buying gas");
	}

	@Override
	public void visitSilverCreditCard(SilverCreditCard silverCreditCard) {
		System.out.println("Silver buying gas");
	}

	@Override
	public void visitGoldCreditCard(GoldCreditCard goldCreditCard) {
		System.out.println("Gold buying gas");
	}
}
