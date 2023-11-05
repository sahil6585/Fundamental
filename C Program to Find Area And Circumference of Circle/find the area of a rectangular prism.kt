//find the area of a rectangular prism


fun main()
{
    println("Enter value of Width  : ")
    var w= readLine()!!.toInt()

    println("Enter value of Length  : ")
    var l= readLine()!!.toInt()

    println("Enter value of Height  : ")
    var h= readLine()!!.toInt()

    var A= 2*((w*l)+(w*h)+(h*l))

    println("area of a rectangular prism = $A")

}