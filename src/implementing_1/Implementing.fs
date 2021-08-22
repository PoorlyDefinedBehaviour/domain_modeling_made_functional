module Implementing

type ValidationError = { Field: string; Message: string }

type OrderID = private OrderID of string

module OrderID =
  open System

  let from id =
    if String.IsNullOrEmpty id then
      Error
        { Field = "OrderID"
          Message = "OrderID cannot be empty" }

    else if id.Length > 50 then
      Error
        { Field = "OrderID"
          Message = "OrderID cannot have more than 50 characters" }
    else
      Ok(OrderID id)

  let value (OrderID id) = id

type UnvalidatedAddress = exn

type CheckedAddress = exn

type CheckAddressExists = UnvalidatedAddress -> CheckedAddress

type CheckProductCodeExists = exn

type UnvalidatedOrder = exn

type ValidatedOrder = exn

type ValidateOrder = CheckProductCodeExists -> CheckAddressExists -> UnvalidatedOrder -> ValidatedOrder
