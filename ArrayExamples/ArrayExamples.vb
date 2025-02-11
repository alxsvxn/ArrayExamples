'Header

Option Strict On
Option Explicit On
Option Compare Text
Module ArrayExamples

    Sub Main()

        MultiDimensionalArray()

    End Sub
    Sub simpleArrays()

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

    Sub MultiDimensionalArray()

        Dim students(14, 2) As Single
        Dim classes() As String = {"Math", "History", "Art"}
        Dim somethingElse(,) As Integer = {{1, 2, 3}, {4, 5, 6}, {7, 8, 9}}
        Dim threeDimensionalArray(,,) As Integer = {{{1}, {2}, {3}}, {{4}, {5}, {6}}, {{7}, {8}, {9}}}

        students(0, 0) = 75.24
        students(0, 1) = 77.91
        students(0, 2) = 99.28

        Console.WriteLine()

    End Sub
End Module
