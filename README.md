# Unconventional Direct Access of Private Fields in C#

This example demonstrates a common yet subtle error in C#: Directly accessing private fields outside of their associated properties. While it might seem convenient at times, this practice has significant drawbacks in terms of maintainability and potential for errors.

The `bug.cs` file contains the problematic code.  The solution, provided in `bugSolution.cs`, showcases the correct approach using properties.