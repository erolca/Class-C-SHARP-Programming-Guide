/*
 * An access specifier determines how other parts of a program can access a class member.
 Member access is controled by four access specifiers:
 public,
private,
protected,
internal.
public member can be accessed by any other code in your program.
Main() is declared as public because it will be called by code outside of its class (the operating system).
private member can be accessed only by other members of its class.
A protected member is public within a class hierarchy, but private outside that hierarchy.
A protected member is created by using the protected access modifier.
The internal modifier declares that a member is known throughout all files in an assembly, but unknown outside that assembly.
The protected internal access level can be given only to class members.
A member declared with protected internal access is accessible within its own assembly or to derived types.

*/