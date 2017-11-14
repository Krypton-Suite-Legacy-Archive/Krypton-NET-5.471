# Krypton-NET-4.7.1

## The 2017-10-18 Commit is:
* An update to Component factory's KryptonToolkit to support the .NET 4.7.1 framework.
* Add generic c# .gitignore
* Change the solution to reflect Visual Studio 2017 usage
* Change Test apps to use .Net 4.7.1 Target framework
* Add designer dll to test apps to allow visual design and testing without GAC'ing

## The 2017-11-06 to toolkit solution only:
* Add braces to if statements
* Use explicit types instead of "vars"
* Object initialization can be simplified
* Delegate invocation can be simplified.
* Use pattern matching
  * Adjust some logic to test bool before cast
  * Use of switch if necessary
* Variable declaration can be inlined
* Null check can be simplified
  * null-propogating code
* Local Variable can be const (And rename to upper case to follow the rest of the codebase.)
* ﻿Join declaration and assignment

## 2017-11-05 Commits:
* Pre-compiled binaries for use in projects

## 2017-11-13 Toolkit solution changes:
* Change Get Set functions to be inlined
* Merge Sequential Checks
* Clarify precedence with brackets
* Work out why clipping is the default for "DrawText" 
  - Applies to buttons, lLabels, Form Titles
  - Create test project - has theme selection, for type testing
* Remove Severity Code Description Project File Line Suppression State Warning CS0618 'SecurityAction.RequestMinimum' is obsolete: 'Assembly level declarative security is obsolete and is no longer enforced by the CLR by default. See http://go.microsoft.com/fwlink/?LinkID=155570 for more information.' Basic Events 2015 [Source Path]\Krypton-NET-4.7\Source\Krypton Navigator Examples\Basic Events\Properties\AssemblyInfo.cs 35 Active

## NOTE: This is a mirror of the Krypton-NET-4.7 repository, therefore it may take a day or two to update this repository with the .NET 4.7.1 framework. Thank you for your patientce. 
