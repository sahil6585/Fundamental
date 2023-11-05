//Find area of Triangle

fun main()
{
    println("Enter the BASE(b) value : ")
    var b= readLine()!!.toInt()

    println("Enter the HEIGHT(h) value : ")
    var h= readLine()!!.toInt()

    var triangle = 0.5*b*h

    println("Area of Triangle = $triangle")
}