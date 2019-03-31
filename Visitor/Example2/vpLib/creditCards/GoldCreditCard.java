package vpLib.creditCards;

import vpLib.offers.OfferVisitor;

public class GoldCreditCard implements CreditCard {

	@Override
	public String getName() {
		// TODO Auto-generated method stub
		return "Gold";
	}

	@Override
	public void accept(OfferVisitor visitor) {
		visitor.visitGoldCreditCard(this);
	}
}
