import scala.math.sqrt
import scala.math.pow

object Tribonacci extends App{

  def TriboRecursive(n: Int): Int = {
    if      (n == 0) 0
    if      (n == 1) 0
    if      (n == 2) 1
    else    TriboRecursive(n-1) + TriboRecursive(n-2)+TriboRecursive(n-3)
  }

  def TriboNormal(n: Int): Int = {
    var a = -1
    var b = 1
    var c = 0
    var d = 0
    for (i <- 0 to n){
      var buffer = a
      a = b
      b = c
      c = d
      d = buffer +d
    }
    d
  } 

}