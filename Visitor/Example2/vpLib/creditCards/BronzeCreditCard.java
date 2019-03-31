package vpLib.creditCards;

import vpLib.offers.OfferVisitor;

public class BronzeCreditCard implements CreditCard {

	@Override
	public String getName() {
		// TODO Auto-generated method stub
		return "Bronze";
	}

	@Override
	public void accept(OfferVisitor visitor) {
		visitor.visitBronzeCreditCard(this);
	}
}
