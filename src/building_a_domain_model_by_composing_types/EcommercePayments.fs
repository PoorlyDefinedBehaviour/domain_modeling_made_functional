module Payments

type CheckNumber = CheckNumber of int

type CardNumber = CardNumber of string

type CardType =
  | Visa
  | Mastercard

type CreditCardInfo =
  { CardType: CardType
    CardNumber: CardNumber }

type PaymentMethod =
  | Cash
  | Check of CheckNumber
  | Card of CreditCardInfo

// NOTE: shouldn't amount be a module to enforce invariants?
type PaymentAmount = PaymentAmount of decimal

type Currency =
  | EUR
  | US

type Payment =
  { Amount: PaymentAmount
    Currency: Currency
    Method: PaymentMethod }

// not implemented
type UnpaidInvoice = string
type PaidInvoice = string

type PaymentError =
  | CardTypeNotRecognized
  | PaymentRejected
  | PaymentProviderOffline

type PayInvoice = UnpaidInvoice -> Payment -> Result<PaidInvoice, PaymentError>

type ConvertPaymentToCurrency = Payment -> Currency -> Payment
