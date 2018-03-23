# MEF_examples

1. SimpleCalculator-Part3/CalculatorUI
- based on Framework4
- uses System.ComponentModel.Composition built in Framework4
- includes two parts:
  - one solution (CalculatorContract, CalculatorFactory, CalculatorUI, ExportComponents),
      ExportsComponents - empty project for plugin path simple resolving only! plugin path is hard embedded in the main app
  - two separeted projects (Add, Subtraction)
- installation:
  - build CalculatorDemoUsingMEF.sln solution
  - build Add & Subtraction projects then copy Add.dll & Subtraction.dll 
    to the ..\SimpleCalculator-Part3\CalculatorUI\ExportComponents\Components
  - run CalculatorDemoUsingMEF.sln solution
- MEF works.

2. MEF1-bug
- based on NetCore2.0 (netcoreapp2.0 + netstandard2.0)
- uses System.ComponentModel.Composition from myget.org (https://dotnet.myget.org/feed/dotnet-core/package/nuget/System.ComponentModel.Composition)
- includes two parts:
  - one solution (CalculatorContract, CompositionHelper, CalculatorConsole, ExportComponents),
      ExportsComponents - empty project for plugin path simple resolving only! plugin path is hard embedded in the main app
  - one separeted project (Add)
- installation:
  - build MEF1-bug.sln solution
  - build Add project then copy Addition.dll 
    to the ..\MEF1-bug\ExportComponents\Components
  - run MEF1-bug.sln solution
- MEF doesn't work.
- Updated on 23.03.2018: the bug was patched in 4.5.0-preview3-26323-01 System.ComponentModel.Composition
