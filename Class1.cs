using System;
// Set up value type in int variable - no boxing
int value = 10;
object one = value; // Cast to object so boxed
object two = value; // Cast again so boxed again separately
// one and two are now separate memory locations on the heap
Console.WriteLine(object.ReferenceEquals(one, two)); // false

// Set up value type in object variable which
// immediately boxes it onto the heap
object value2 = 10; // value is boxed already
object three = value2; // three points to the boxed value
object four = value2; // four also points to the same boxed value
Console.WriteLine(object.ReferenceEquals(three, four)); // true
// Set up value type in int variable - no boxing
int value = 10;
object one = value; // Cast to object so boxed
object two = value; // Cast again so boxed again separately
// one and two are now separate memory locations on the heap
Console.WriteLine(object.ReferenceEquals(one, two)); // false

// Set up value type in object variable which
// immediately boxes it onto the heap
object value2 = 10; // value is boxed already
object three = value2; // three points to the boxed value
object four = value2; // four also points to the same boxed value
Console.WriteLine(object.ReferenceEquals(three, four)); // true

Value Types and Reference Types

For reference types object.ReferenceEquals(a, b) returns true if and only if a and b have the same underlying memory address.

In general we shouldn't care whether value types occupy the same underlying memory address. It isn't relevant for anything we'd want to normally use them for. But the definition above gives us a problem when we come to value types being compared with ReferenceEquals.

The difficulty comes from the fact that ReferenceEquals expects two System.Objects as parameters.This means that our value types will get boxed onto the heap as they are passed in to this routine.Normally, because of the way the boxing process works, they will get boxed separately to different memory addresses on the heap. This of course means the call to ReferenceEquals returns false.


So for example object.ReferenceEquals(10, 10) returns false, for these reasons.

You can see it's the boxing that causes the problem in the following code: