# Abstract Pricing Model for .NET
## High-level abstract model for calculating price of subscriptions and/or other products and services

![Console output](https://raw.githubusercontent.com/shturm/abstract-pricing/master/output.png)
![Class Diagram](https://raw.githubusercontent.com/shturm/abstract-pricing/master/AbstractPricingModel.png)

Each Tariff is composed by a list of Fees. Tariff contains minimal logic and provides unified interface for calculating Fees. Tariff implements Fascade pattern to operate list of Fee objects.

### Terminology and main classes

*  *Tariff* is a class representing the main entity the model is going to compare. Tariff, product, service and subscription are hereby considered the same thing. Tariff aggregates a set of fees. Tariff classes are designed to be reused when same pricing model is required, only with different values.
* _Fee_ is is a class that comprises a Tariff - a Tariff has many Fees. Each Fee implement it's own '`Calculate(...)`. E.g. some fees are based on consumption, while others on fixed periods of time.
* _Applying a fee_ is the process of calculation of cost - really done in `IFee.Calculate(...)`. When `Calculate(...)` is called on *Tariff* object it calls `Calculate(...)` on each Fee and aggregates the result

### Common actions 

#### Add a Tariff
To add a new Tariff extend the abstract `Tariff` class.

#### Add a Fee
Extend and implement from `IFee` interface. Use the Fee within a `Tariff` class.

#### Change calculation algorithm
Override `Calculate(...)` from the base abstract *Tariff* class.

#### Add features to the model
To add features to the model, like add more unit types or change calculation algorithm, re-implement the `ITariff` and `IFee` interfaces. `Consumption` class is also meant to be extended as needed
