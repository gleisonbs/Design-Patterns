package vpLib.offers;

import vpLib.creditCards.BronzeCreditCard;
import vpLib.creditCards.SilverCreditCard;
import vpLib.creditCards.GoldCreditCard;

public interface OfferVisitor {
	void visitBronzeCreditCard(BronzeCreditCard bronzeCreditCard);
	void visitSilverCreditCard(SilverCreditCard silverCreditCard);
	void visitGoldCreditCard(GoldCreditCard goldCreditCard);
}
