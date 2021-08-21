module Widgets

[<Struct>]
type WidgetCode = WidgetCode of string

[<Struct>]
type GizmoCode = GizmoCode of string

type OrderQuantity =
  | Unit of int
  | Kilogram of decimal

type CustomerInfo = exn

type ShippingAddress = exn

type BillingAddress = exn

type OrderLine = exn

type BillingAmount = exn

type Order =
  { CustomerInfo: CustomerInfo
    ShippingAddress: ShippingAddress
    BillingAddress: BillingAddress
    OrderLines: OrderLine list
    BillingAmount: BillingAmount }

type ProductCode =
  | Widget of WidgetCode
  | Gizmo of GizmoCode

type AcknowledgmentSent = exn

type OrderPlaced = exn

type BillableOrderPlaced = exn

type PlaceOrderEvents =
  { AcknowledgmentSent: AcknowledgmentSent
    OrderPlaced: OrderPlaced
    BillableOrderPlaced: BillableOrderPlaced }

type UnvalidatedOrder = exn

type ValidatedOrder = exn

type ValidationError = { Field: string; Message: string }

type ValidateOrder = UnvalidatedOrder -> Async<Result<ValidatedOrder, ValidationError list>>

type PlaceOrder = UnvalidatedOrder -> PlaceOrderEvents

type QuoteForm = exn

type OrderForm = exn

type CategorizedMail =
  | Quote of QuoteForm
  | Order of OrderForm

type EnvelopeContents = exn

type CategorizeInboundMail = EnvelopeContents -> CategorizedMail

type ProductCatalog = exn

type PricedOrder = exn

type CalculatePrices = OrderForm -> ProductCatalog -> PricedOrder
