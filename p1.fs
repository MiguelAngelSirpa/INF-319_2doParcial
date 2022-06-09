open System
let tribonormal n =
  let mutable a=(-1)
  let mutable b=1
  let mutable c=0
  let mutable d=0
  for i in 1..(n-1) do
    a<-b
    b<-c
    c<-d
    d<-a+b+c        
  d            
    

let rec triboRecursivo n =
    match n with
    | 0 -> 0
    | 1 ->0
    | 2 ->1
    | n ->triboRecursivo(n-1) + triboRecursivo(n-2)+triboRecursivo(n-3)

let tribRecursivo n=
     for i in 1..n do
        printf "%d, " (triboRecursivo i)

let tribNormal n=
     for i in 1..n do
        printf "%d, " (tribonormal i)


[<EntryPoint>]
let main argv = 
    //printfn "%A" argv

    // TRIBONACCI NORMAL
  Console.WriteLine("Introduzca un numero n:")
  let num1=Console.ReadLine()
  let n=Convert.ToInt32(num1)
    
  Console.WriteLine(tribNormal n)


    // TRIBONACCI RECURSIVO
  Console.WriteLine("Introduzca un numero n: ")
  let num1=Console.ReadLine()
  let n=Convert.ToInt32(num1)
  Console.WriteLine(tribRecursivo n)

  let tecla= Console.ReadKey()
  0 // devolver un código de salida entero
