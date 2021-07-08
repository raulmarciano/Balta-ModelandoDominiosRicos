using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class CreditCardPayment : Payment
    {
        public CreditCardPayment(int cardHolderName, string cardNumber, string lastTreansactionNumber, DateTime paidDate, DateTime expireDate, decimal total, decimal totalPaid, string payer, Document document, Address address, Email email)
            : base (paidDate, expireDate, total, totalPaid, payer, document, address, email)
        {
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTreansactionNumber = lastTreansactionNumber;
        }

        public int CardHolderName { get; private set; }
        public string CardNumber { get; private set; }
        public string LastTreansactionNumber { get; private set; }
    }
}