module IntegrityAndCosistency

(*
Integrity means that a piece of data follows the correct
business rules.

Consistency means that different parts of the domain model
agree about facts.

It is very rare to have a unbounded integer or string
in a real-world domain. Almost always, these values are
constrained in some way.

We can use the smart constructor approach to enforce constraints.

Onde a type is constructed, we know for sure it is valid.
*)
type ValidationError = { Field: string; Message: string }

module UnitQuantity =
  // the private keyword makes the constructor not callable
  // from outside the module
  type T = private UnitQuantity of int

  let create (quantity: int) : Result<T, ValidationError> =
    if quantity < 1 then
      Error
        { Field = "quantity"
          Message = "quantity must be positive" }
    else if quantity > 1000 then
      Error
        { Field = "quantity"
          Message = "quantity can not be greater than 1000" }
    else
      Ok(UnitQuantity quantity)

(*
Units of measure

For numeric values, another way of documenting the requiments
while ensuring type-safety is to use units of measure.

The compiler will enforce compability between units of measure.
*)
[<Measure>]
type kg

[<Measure>]
type meter

let fiveKilos = 5.0<kg>

let fimeMeters = 5.0<meter>

// fiveKilos = fiveMeters -- compile error

(*
Enforcing invariants with the type system

An invariant is a condition that stays true no matter
what else happens.
For example, saying that a UnitQuantity must always be
between 1 and 1000.

Example:

The non empty list
*)
type NonEmptyList<'a> = { First: 'a; Rest: 'a list }
