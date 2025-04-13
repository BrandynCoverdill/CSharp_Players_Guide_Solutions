# Chapter 3

## Creating a project in Visual Studio

When creating a new C# project, it is a combination of two things:

- **source code** - Instructions you write in C# for the computer to run.
- **configuration** - Instructions for the computer to know how to compile or translate code to binary instructions.

## Building and compilation of a project

When you build your project, the compiler will translate your code into an **Intermediate Language (IL)**. Once this has been compiled, this code will be saved into a file - called an **assembly** This assembly will either be a .dll or .exe file.

Using the assembly, the **Common Language Runtime (CLR)**, brain of .NET, will:

- Compiles the IL code to machine code using **just-in-time (JIT)** compiler
- Run the machine code
- Collects garbage (unused memory)
- Handles errors (exceptions)
- Manages threads and processes

## Base Class Library (BCL)

The BCL is a set of libraries that comprise of the `System.*` namespace.

# Chapter 4

## Comments

Here are some suggestings for making good use of comments:

- Do not let TODO or reminder comments or commented-out code last long.
- Don't add comments to code that can quickly be understand by gleaning over it quickly.
- Write comments roughly at the same time as you write the code.
- Find a balance in how much you comment. Not too little and not too much.
- Don't use comments to excuse hard code.
	- Make the code easy to understand, then add just enough comments to claify any important but unobvious details. 