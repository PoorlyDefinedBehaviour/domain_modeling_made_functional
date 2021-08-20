module UnderstandingTypes

// A type is just the name given to the set of
// possible values that can be used as inputs
// or outputs of a function

// Types are inferred most of the time

// add1: int -> int
let add1 x = x + 1

// add: int -> int -> int
let add x y = x + y

// Functions that consist of more than one line are
// written with an indent(like Python).
// There are no curly braces.

// squarePlusOne: int -> int
let squarePlusOne x =
  let square = x * x
  square + 1

// If the function will work if any type, then the compiler
// will infer a genreic type
// areEqual: 'a -> 'a -> bool
let areEqual x y =
  // = is the equality operator in F#
  // NOTE: maybe it has something to do with matching?
  x = y

// Value vs Object vs Variable
//
// In functional programming, most things are called values.
// In an object-oriented language, most things are called
// objects.
//
// A value is just a member of a type, something that can
// be used as input or output.
// For example, 1 is a value of type int, "abc" is a value
// of type string, and so on.
// Functions can be values too. The function let add1 x = x + 1
// is a value of type int -> int
//
// Values are immutable and do not have any behaviour attached
// to them.
//
// In contranst, an object is an encapsulation of a data structure
// and its associated behaviours. In general, objects are expected
// to have state, and all operations that change the internal state
// must be provided by the object itself.
//
// ---
//
// Composition of types
//
// It is the foundation of functional design. Composition jus means
// that you can combine two things to make a bigger thing.
//
// In the functional programming world, we use composition
// to build new functions from smaller functions and new types
// from smaller types.
//
// Product types
//
// For example we might say that to make fruit salad you need
// an apple, a banana and some cherries:
type AppleVariety = string

type BananaVariety = string

type CherryVariety = string

// This kind of type is called a record.
type FruitSalad =
  { Apple: AppleVariety
    Banana: BananaVariety
    Cherries: CherryVariety }

// Coproduct types
//
// We might say that for a fruit snack you need an apple
// or a bana or some chrries:

// This is called a discriminated union in F#
type FruitSnack =
  | Apple of AppleVariety
  | Banana of BananaVariety
  | Cherries of CherryVariety

// Algebraic type systems
//
// An algebraic type system is simply one where every
// compound type is composed from smaller types and
// by using product or coproduct types together.

type Person = { First: string; Last: string }

// aPerson: Person (type is inferred)
let aPerson = { First = "John"; Last = "Doe" }

// We can pattern match to deconstruct a value of this type
// The person first name is bound to first and
// the last name is bound to last
let { First = first; Last = last } = aPerson

// With records, we can also use dot notation
let first1 = aPerson.First
let last1 = aPerson.Last

type OrderQuantity =
  | Unit of int
  | Kilogram of decimal

// A coproduct type is constructed by using one of its type constructors
// anOrderQuantityInUnits: OrderQuantity
let anOrderQuantityInUnits = Unit 10

// anOrderQuantityInKilograms: OrderQuantity
let anOrderQuantityInKilograms = Kilogram(decimal 10)

// To deconstruct a coproduct type, we must use pattern matching
// ppOrderQuantity: OrderQuantity -> string
let ppOrderQuantity quantity =
  match quantity with
  | Unit x -> sprintf "%i units" x
  | Kilogram x -> sprintf "%g kg" x
