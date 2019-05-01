Module Module1
    Public Num1 As Integer
    Public Num2 As Integer
    Public Sign As String
    Public Sum As Integer
    Sub Main()
        Console.WriteLine("Enter The Sign Of Which You Would Like To Use This Calculater For. (+ For Add, - For Take, / For Divide And * For Times.) (If You Would Like To Double Or Half Enter: *2 For Double. And /2 For Half)")
        Sign = Console.ReadLine()
        If (Sign = "+") Then
            Console.WriteLine("Enter A Number To Add")
            Num1 = Console.ReadLine()
            Console.WriteLine("Enter Another Number To Add")
            Num2 = Console.ReadLine()
            Sum = Num1 + Num2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If
        If (Sign = "-") Then
            Console.WriteLine("Enter A Number To Minus")
            Num1 = Console.ReadLine()
            Console.WriteLine("Enter Another Number To Minus")
            Num2 = Console.ReadLine()
            Sum = Num1 - Num2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If
        If (Sign = "/") Then
            Console.WriteLine("Enter A Number To Divide")
            Num1 = Console.ReadLine()
            Console.WriteLine("Enter Another Number To Divide")
            Num2 = Console.ReadLine()
            Sum = Num1 / Num2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If
        If (Sign = "*") Then
            Console.WriteLine("Enter A Number To Times")
            Num1 = Console.ReadLine()
            Console.WriteLine("Enter Another Number To Times")
            Num2 = Console.ReadLine()
            Sum = Num1 * Num2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If
        If (Sign = "*2") Then
            Console.WriteLine("Enter A Number To Double")
            Num1 = Console.ReadLine()
            Sum = Num1 * 2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If
        If (Sign = "/2") Then
            Console.WriteLine("Enter A Number To Half")
            Num1 = Console.ReadLine()
            Sum = Num1 / 2
            Console.WriteLine("The Answer Is " & Sum)
            Console.WriteLine()
            Console.WriteLine("Press The Enter Key To Terminate The Program.")
            Console.ReadLine()
        End If

    End Sub

End Module
