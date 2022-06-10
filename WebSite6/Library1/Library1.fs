namespace Library1
module Calcu =
    let tribonormal n =
     let mutable a=(-1)
     let mutable b=1
     let mutable c=0
     let mutable d=0
     for i in 1..n do
        printf "%d, " d
        a<-b
        b<-c
        c<-d
        d<-a+b+c
                 
    

    let rec triboRecursivo n =
        match n with
        | 0 -> 0
        | 1 ->0
        | 2 ->1
        | n ->triboRecursivo(n-1) + triboRecursivo(n-2)+triboRecursivo(n-3)

    let triborec n=
         for i in 1..n do
            printf "%d, " (triboRecursivo i)

type Class1() = 
    member this.X = "F#"
