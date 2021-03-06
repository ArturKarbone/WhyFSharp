﻿namespace Factorial.FSharp

module Factorial =
    let rec calculate(n:int):bigint =
        if n<=1 then bigint(1)
        else bigint(n) * calculate(n-1)

    let rec calcuateWithPatternMatching(n:int):bigint=
        match n with 
        |0|1-> 1I
        |n->calcuateWithPatternMatching(n-1)*bigint(n)

    let rec calcuateWithPatternMatching2 = function 
        |0|1-> 1I
        |n-> calcuateWithPatternMatching2(n-1) * bigint(n)

    let rec calcuateWithLambda = fun n->
        match n with
        |0|1->1I
        |n-> calcuateWithLambda(n-1) * bigint(n)

//    let rec calcuateWithLambda2 = fun n ->
//        function
//            |0|1->1I
//            |n-> calcuateWithLambda2(n-1) * bigint(n)