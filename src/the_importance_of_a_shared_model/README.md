The point of domain driven design is to make it
easier to understand a problem, share understanding
e iterate.

We do that by making the people who know what the
software should close to the people who develop it,
because we want to create a shared model of the problem
we want to solve.

A domain is an area of knowledge associated with the
problem we are trying to solve. Alternatively a domain
is that which a domain expert is expert in.

A domain model is a set of simplifications that
represent those aspects of a domain that are elevant
to a particular problem. The domain model is part
of the solution space, while the domain that it represents
is part of the problem space.

The ubiquitous language is a set of concepts and vocabulary
associated with the domain, shared by both the team members
and the source code.

A bounded context is a subsystem in the solution space
with clear boundaries that distinguish it from other
subsystems. A bounded context often corresponds to
a subdomain in the problem space. A bounded context
also has its own set of concepts and vocabulary,
its own dialect of the ubiquitous language.

A context map is a high-level diagram showing a collection
of bounded contexts and the relationships between them.

A domain event is a record of something that happened
in the system. It is always described in the past tense.
An event often triggers additional activity.

A command is a request for some process to happen,
triggered by a person, system or another event.
If the process succeeds, the state of the system changes
and one or more domain events are recorded.
