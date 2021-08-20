Summary:

Don't do database-driven design
Keep things pure
Add side effects at the end of workflows if necessary
Onion/hexagonal/clean architecture are options
Layered architecture is usually bad because things are all over the place

A domain object is an object design for use only within the
boundaries of a context, as opposed to a data transfer object.

A data transfer object is ian object designed to be serialized
and shared between contexts.

Shared kernel, customer/supplier, and conformist are different
kinds of relationships between bounded contexts.

Shared kernel: Contexts share a model

Customer/supplier: Customer defines the model

Conformist: Consumer just accepts whatever model the system in
question has.

An anti-corruption layer is a component that translates
concepts from one domain to another, in order to reduce
coupling and allow domains to evolve indepently --
shows up at the edges of the system and does some validation.

Persistence ignorance means that the domain model should be
based only on the concepts in the domain itself, and should
not contain any awareness of databases or other persistence
mechanisms.
