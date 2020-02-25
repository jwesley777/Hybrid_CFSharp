# Hybrid_CFSharp
Simple project to experiment with C#-F# interoperability

*Hybrid_CFSharp/Program.cs* - C# code. By default, consumes path to CSV-file, its dates' column number and values' column number as args. Prints average of this time-series to stdout. 

*FTools/Library1.fs* - F# code.

Contains 2 implementations: based on Deedle.Series and arrays. Default is Deedle.Series-based. Alternative is array-based and doesn't need indexing (dates) column. 
