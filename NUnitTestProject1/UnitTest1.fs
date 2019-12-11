module Tests1

open System
open NUnit.Framework

open MathService 

module MyMath =
    let private square x = x * x
    let private isOdd x = x % 2 <> 0

    let squaresOfOdds xs = 
        xs 
        |> Seq.filter isOdd 
        |> Seq.map square


[<Test>]
let ``My test`` () =
    Assert.True(true)

//[<Test>]
//let ``Fail every time`` () = Assert.True(false)


[<Test>]
let ``Sequence of Evens returns empty collection`` () =
    let expected = Seq.empty<int>
    let actual = MyMath.squaresOfOdds [1; 3; 5; 7; 9]
    Assert.That(actual, Is.EqualTo(expected))

[<Test>]
let ``Sequence of Ones and Evens return Ones`` () =
    let expected = [1; 1; 1; 1]
    let actual = MyMath.squaresOfOdds [2; 1; 4; 1; 6; 1; 8; 1; 10]
    Assert.That(actual, Is.EqualTo(expected))

[<Test>]
let ``SquaresOfOdds works`` () =
    let expected = [1; 9; 25; 49; 81]
    let actual = MyMath.squaresOfOdds [1; 2; 3; 4; 5; 6; 7; 8; 9; 10]
    Assert.That(actual, Is.EqualTo(expected))