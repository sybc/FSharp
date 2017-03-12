#r @"D:\vs2015\FConsoleApplication\packages\MathNet.Numerics.3.13.1\lib\net40\MathNet.Numerics.dll"
open System.Numerics
open System.Diagnostics
open MathNet.Numerics.Statistics

let rnd = System.Random()

let x() = rnd.NextDouble() + 1.0
let y() = rnd.NextDouble() + 2.0
let z() = rnd.NextDouble() + 3.0
let b() = rnd.NextDouble() + 4.0

// create array with 1000 element, and each element has 1000000 element
let data = seq { for i in 1 .. 1000000000 do yield i }

#time
let x1 = data |> Seq.filter (fun e -> e<=10000000) |> Array.ofSeq


let ydata = seq { for i in 0 .. 100000000 -> y()  }
let zdata = seq { for i in 0 .. 100000000 -> z()  }

#time
xdata |> Array.ofSeq
ydata |> Array.ofSeq
zdata |> Array.ofSeq
#time 


type System.Random with
    /// Generates an infinite sequence of random numbers within the given range.
    member this.GetValues(minValue, maxValue) =
        Seq.initInfinite (fun _ -> this.Next(minValue, maxValue))

let r = System.Random()
let x = r.GetValues(0,2) |> Seq.take (1000000)
let y = r.GetValues(0,2) |> Seq.take (1000000)

Seq.map (fun e -> e + 1) |> Seq.take 1000000
#time
nums |> Seq.iter (fun e -> printfn "%i" e )
#time

let x = System.Random().NextDouble() + 1.0

#time
for i=1 to 100 do
    seq [1..10..100]
    let mutable x, y =  (System.Random().NextDouble() + 1.0, System.Random().NextDouble() + 2.0)
    printfn "x=%f\ty=%f" x y
#time