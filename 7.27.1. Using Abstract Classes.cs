An abstract method is created by specifying the abstract type modifier.
An abstract method contains no body.
An abstract method is not implemented by the base class.
An abstract method is automatically virtual.
A derived class must override it.
The abstract modifier cannot be applied to static methods.
Properties can also be abstract.
A class containing abstract methods must be declared as abstract with the abstract specifier.
There can be no objects of an abstract class.
If a derived class doesn't implement all of the abstract methods in the base class, then the derived class must also be specified as abstract.

To declare an abstract method, use this general form:

abstract type name(parameter-list);