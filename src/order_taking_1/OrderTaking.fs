module OrderTaking

type WidgetCode = WidgetCode of string

type GizmoCode = GizmoCode of string

type ProductCode =
  | Widget of WidgetCode
  | Gizmo of GizmoCode

type OrderQuantity =
  | Unit of int
  | Kilos of decimal

type OrderID = exn

type OrderLineID = exn

type CustomerID = exn

type CustomerInfo = exn

type ShippingAddress = exn

type BillingAddress = exn

type Price = exn

type BillingAmount = exn

type OrderLine =
  { ID: OrderLineID
    OrderID: OrderID
    ProductCode: ProductCode
    Quantity: OrderQuantity
    Price: Price }

type Order =
  { ID: OrderID
    CustomerID: CustomerID
    ShippingAddress: ShippingAddress
    BillingAddress: BillingAddress
    OrderLines: OrderLine list }
