'Header

Option Strict On
Option Explicit On
Option Compare Text
Module ArrayExamples

    Sub Main()
        'Arrays are cool

        Dim fruits(5) As String
        Dim names() As String = {"John", "Paul", "Jeff", "Franklin"}
        Dim beanCounts = New Integer() {123, 321, 432, 958}

        fruits(0) = "banana"

        fruits(3) = "grape"


        Console.WriteLine(names(3))
        Console.WriteLine(beanCounts(2))

        'For i = 0 To 10
        '    Console.WriteLine(names(i))
        'Next

        For i = LBound(names) To UBound(names)
            Console.WriteLine(names(i))
        Next


    End Sub

End Module
