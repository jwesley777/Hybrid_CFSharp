namespace FTools
open Deedle
open MathNet.Numerics

module ExampleFunctions = 
    open System

    let Add a b = a + b
    let Multiply a b = a * b
    let Power a b = a ** b
    let AverageOfArray (array: double[]): double = 
        let mutable s = 0.0
        for x in array do
            s <- s + x
        s/double(array.Length)
    
    let AverageOfSeries (series: Series<DateTime, double>): double = 
        series.Mean()


