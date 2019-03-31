package vpLib.creditCards;

import vpLib.offers.OfferVisitor;

public class SilverCreditCard implements CreditCard {

	@Override
	public String getName() {
		// TODO Auto-generated method stub
		return "Silver";
	}

	@Override
	public void accept(OfferVisitor visitor) {
		visitor.visitSilverCreditCard(this);
	}
}
