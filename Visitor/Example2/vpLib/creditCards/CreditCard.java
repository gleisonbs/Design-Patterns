package vpLib.creditCards;

import vpLib.offers.OfferVisitor;

public interface CreditCard {
	String getName();
	void accept(OfferVisitor visitor);
}
