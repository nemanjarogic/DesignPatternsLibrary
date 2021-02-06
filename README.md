<h1 align="center">Design Patterns Library</h1>
<p align="center">
 32 Design Patterns + 65 moderately realistic examples
</p>

## What are Design Patterns?
In software engineering, a design pattern is a general repeatable solution to a commonly occurring problem in software design.
A design pattern isn't a finished design that can be transformed directly into code.
It is a description or template for how to solve a problem that can be used in many different situations.
In addition, design patterns allow developers to communicate using well-known, well understood names for software interactions.

Know when to use a certain design pattern, and when not to.
No design pattern is a 42 – the answer to life, the universe and everything. There are situations in which every design pattern easily becomes an antipattern.

## Design Pattern Types
Design patterns can be separatated into three main categories:
* Creational
> Creational design patterns are design patterns that deal with object creation mechanisms, trying to create objects in a manner suitable to the situation. The basic form of object creation could result in design problems or added complexity to the design. Creational design patterns solve this problem by somehow controlling this object creation.

* Structural
> Structural design patterns are design patterns that ease the design by identifying a simple way to realize relationships among entities. Structural patterns are concerned with how classes and objects are composed to form larger structures.

* Behavioral
> Behavioral patterns are concerted with algorithms and the assignment of responsibilities between objects. Behavioral patterns describe not just the patterns of objects or classes but also the patterns of communication between them.

## What this repository contains?
This repository contains a comprehensive design patterns library implemented in C#, which covers various design patterns from the most commonly used ones to the lesser-known ones. It enables you to get familiar with and learn design patterns through moderately realistic examples.

| Design Pattern        | Type           | Description  |
| ------------- |:-------------:| -----|
| [Abstract Factory](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/CreationalPatterns/AbstractFactory) | Creational | Provides an interface for creating families of related or dependent objects without specifying their concrete classes.|
| [Builder](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/CreationalPatterns/Builder/CustomSandwichBuilder) | Creational | Lets you construct complex objects step by step. The pattern allows you to produce different types and representations of an object using the same construction code.|
| [Factory Method](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/CreationalPatterns/FactoryMethod/RestaurantManagement) | Creational | Provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.|
| [Prototype](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/CreationalPatterns/Prototype/PrototypeLibrary) | Creational | Lets you copy existing objects without making your code dependent on their classes.|
| [Singleton](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/CreationalPatterns/Singleton/Greeter) | Creational | Ensures that a class has only one instance, while providing a global access point to this instance.|
| [Adapter](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Adapter/AdapterLibrary) | Structural | Allows objects with incompatible interfaces to collaborate.|
| [Bridge](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Bridge/BridgeLibrary) | Structural | Lets you split a large class or a set of closely related classes into two separate hierarchies—abstraction and implementation—which can be developed independently of each other.|
| [Composite](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Composite/CompositeLibrary) | Structural | Lets you compose objects into tree structures and then work with these structures as if they were individual objects. Treat individual objects and compositions of objects uniformly.|
| [Decorator](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Decorator/DecoratorLibrary) | Structural | Lets you attach new behaviors to objects by placing these objects inside special wrapper objects that contain the behaviors. Extend or alter the functionality of objects at runtime.|
| [Facade](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Facade/FacadeLibrary) | Structural | Provides a simplified interface to a library, a framework, or any other complex set of classes. This makes a complex body of code simpler to use and consume.|
| [Flyweight](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Flyweight/FlyweightLibrary) | Structural | Lets you fit more objects into the available amount of RAM by sharing common parts of state between multiple objects instead of keeping all of the data in each object. It reduces storage costs for a large number of objects.|
| [Proxy](https://github.com/nemanjarogic/DesignPatternsLibrary/tree/main/src/StructuralPatterns/Proxy/ProxyLibrary) | Structural | Lets you provide a substitute or placeholder for another object. A proxy controls access to the original object, allowing you to perform something either before or after the request gets through to the original object. |



![alt text](https://github.com/nemanjarogic/DesignPatternsLibrary/blob/main/assets/images/design-patterns-types.png "Design Patterns")
