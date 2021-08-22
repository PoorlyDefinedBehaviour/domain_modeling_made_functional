module OrderTaking

open System

type UnvalidCustomerInfo = exn

type UnvalidatedAddress = exn

type UnvalidatedOrder =
  { OrderID: string
    CustomerInfo: UnvalidCustomerInfo
    ShippingAddress: UnvalidatedAddress }

type CustomerInfo = exn

type Address = exn

type ValidatedOrderLine = exn

type PricedOrderLine = exn

type ValidatedOrder =
  { OrderID: string
    CustomerInfo: CustomerInfo
    ShippingAddress: Address
    BillingAddress: Address
    OrderLines: ValidatedOrderLine list }

type Command<'data> =
  { Data: 'data
    Timestamp: DateTime
    UserID: string }

type PlaceOrder = Command<UnvalidatedOrder>

type ChangeOrder = Command<ValidatedOrder>

type CancelOrder = Command<ValidatedOrder>

type OrderTakingCommand =
  | Place of PlaceOrder
  | Change of ChangeOrder
  | Cancel of CancelOrder

type Amount = exn

type PricedOrder =
  { OrderID: string
    CustomerInfo: CustomerInfo
    ShippingAddress: Address
    BillingAddress: Address
    OrderLines: PricedOrderLine list
    AmountToBill: Amount }

type Order =
  | Unvalidated of UnvalidatedOrder
  | Validated of ValidatedOrder
  | Priced of PricedOrder
