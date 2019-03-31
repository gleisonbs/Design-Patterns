package vpLib.offers;

import vpLib.creditCards.BronzeCreditCard;
import vpLib.creditCards.GoldCreditCard;
import vpLib.creditCards.SilverCreditCard;

public class HotelOfferVisitor implements OfferVisitor {

	@Override
	public void visitBronzeCreditCard(BronzeCreditCard bronzeCreditCard) {
		System.out.println("Bronze buying hotel");
	}

	@Override
	public void visitSilverCreditCard(SilverCreditCard silverCreditCard) {
		System.out.println("Silver buying hotel");
	}

	@Override
	public void visitGoldCreditCard(GoldCreditCard goldCreditCard) {
		System.out.println("Gold buying hotel");
	}
}
