# Legacy code refactoring

## Description

You need to refactor the `UserService` class, specifically the `AddUser` method. Assume that the code is sound in terms of business logic and only focus on applying our [design principles](https://dev.azure.com/microsoft/WebDefense/_wiki/wikis/Main/67247/design-principles). 

- Use tests as leverage. 
- Keep in mind acronyms such as SOLID, KISS, DRY, and YAGNI.
- Start with _patterns_ in the _problem_, then relate them in _context_.
- Be intentional.

## Limitations

The `Program.cs` in the `Console` application SHALL NOT change _at all_. This includes using statements. Assume that the codebase is part of a greater system, and any non-backwards compatible change will break the system.

You can change anything in the `App` project except the `UserDataAccess` class and its `AddUser` method MUST NOT change. The type and the method MUST remain `static`.
