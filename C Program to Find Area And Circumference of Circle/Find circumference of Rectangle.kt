//Find circumference of Rectangle


fun main()
{
    println("Enter value of length : ")
    var l = readLine()!!.toInt()

    println("Enter value of width : ")
    var w = readLine()!!.toInt()


    var c = 2*(l+w)

    println("circumference of Rectangle = $c")
}