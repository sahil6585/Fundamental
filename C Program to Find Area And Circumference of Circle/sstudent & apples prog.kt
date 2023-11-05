/*Accept number of students from user. I need to give 5 apples to each
student. How many apples are required?*/


fun main()
{
    println("Enter a number of students : ")
    var student = readLine()!!.toInt()

    var apples = student * 5

    println("You need to $apples apples...")

}