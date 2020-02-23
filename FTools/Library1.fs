namespace FTools

module ExampleFunctions = 
    let Add a b = a + b
    let Multiply a b = a * b
    let Power a b = a ** b
    let Average (array: double[]): double = 
        let mutable s = 0.0
        for x in array do
            s <- s + x
        s/double(array.Length)


