# Claudia
"Claudia" will be an experiment and a "learning by doing" project. I want to try to develop some kind of a static C code analyzer, which should help me to find weak points in terms of potential null pointers, potential memory leaks, potential race conditions with threads and "ugly" inconsistent function/procedure calls.

Maybe, all this should be visualized through nice graphs and, in general, should have a graphical user interface.

## What's the motivation?
Well, there are some reasons for that:
1. I could really need such a tool for my (embedded) C projects at work. ;-)
2. I want to apply and practice **pure OOP style**!

## Pure OOP style? What does that mean?
"Pure OOP style" means, that I want to do OOP in that way, how [Yegor](https://www.yegor256.com/) promotes, how it should be done right.
He may be a bit extreme by that subject, but I share his opinions about Object Oriented Programming and it's best practices.

Especially, because he has [several projects](https://github.com/yegor256) here on Github, where he is applying his own suggestions.

Since he is primarily a Java developer, I think there should also exist some projects based on C# and with some graphical user interfaces. Yeah, I think graphical user interfaces are a necessary topic to cover. Stuff for the console is relatively easy to accomplish, even with the strangest programming languages and practices/suggestions. ;-)

### What are the main principles?
- **OOP is about behaviour, not data!** This can not be stressed enough. Objects do not "encapsulate *data*". They are no data bags. Instead, they encapsulate other objects, with whom they do interact. "Data", in that sense, are just an illusion ... a side effect ... which seems to be real, just in result of the interaction between the objects.
- **Objects are always trustworthy!** Objects do ever the right thing in relation to their public interface. That's why the encapsulating object must never assume or know anything about the internal behaviour of it's partner objects. The public interface is enough to know about the other object.
- **Composition is the true power of OOP!** That means, objects should be small as possible and experts within their scope. If that is the case, then they provide endless possibilities in terms of their composability. The objects are then more than the sum of it's parts.
- **Embrace the `new` keyword!** That means, use and love, what the language already provides. Do not hide this godlike act of instantiating a `new` and fresh object behind a dependency injection framework. (Seriously: I would say, that dependency injection frameworks make your code very hard to understand, because the creation of `new` objects is a key element in doing correct OOP! You seriously have to see the big instantiation hierarchy, if you want to understand, how all the small objects work together! To hide all that necessary stuff is like obfuscating your source code for strangers.)
- **Use almost no Inheritance!** I'm sure, that you can accomplish the DRY principle without any Inheritance and with strictly finalized/sealed classes. Inheritance, by it's nature, is the worst coupling between classes/objects which you can get.

  My personal rule of thumb:
  1. Try to solve your problem with composition of already existing objects.
  2. No solution found? Create a completely new interface/class/object, which can use other objects (interfaces) to solve the problem (or reduce code duplication).
  3. No solution found? Rethink your current design, so that you can solve your problem with composition! Or ask other developers.
  4. Still no proper solution found? Or you want to instrumentalize some kind of a framework to reduce code duplication? Then, and only then(!!!), should you think about inheriting from a base class.

  I remember, when I was an apprentice, the very first thing we were told about OOP was "Inheritance" and how "powerful" it is. *"Imagine, you have a basic Shape class. And when you want to create a Circle, you simply inherit from that Shape class and have automatically all the features of that Shape class. Cool, huh?"*

  No! That is really stupid! They should have taught us proper object composition and loose coupling to accomplish the same and have much more power and flexibility in the end. There is also no headache when you think about the famous circle/ellipse problem, when you just use composition instead inheritance.
- **Give your objects real names and no job descriptions!** That means, do not decorate them with pointless descriptions, like "Manager", "Controller", "Processor", "Provider", and so on. All these names are yelling at you, that there are some anemic and dump objects around, which do nothing but holding plain data. Find these useless objects and give them usefulness. Maybe, you have to change your whole design to accomplish that. Otherwise, throw these useless objects away, because they do absolutely nothing!

That should it be for now. I try to follow all these principles as good as I can. ;-)