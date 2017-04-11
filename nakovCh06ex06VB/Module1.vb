Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Namespace nakovCh06ex06

    Public Class Program

        Public Shared Sub Main(ByVal args As String())
            FibonacciSequence()
        End Sub

        Private Shared Sub FibonacciSequence()
            Console.WriteLine("Please enter a positive number: ")
            Dim userInp As String = Console.ReadLine()
            Dim n As ULong = 0
            Dim check As Boolean = ULong.TryParse(userInp, n)
            If check <> True Then
                Console.WriteLine("Please enter a positive number!")
            End If

            Dim firstNum As ULong = 1
            Dim secondNum As ULong = 0
            Dim thirdNum As ULong = 0
            Dim sum As ULong = 0
            For i As ULong = 1 To n
                thirdNum = firstNum + secondNum
                firstNum = secondNum
                secondNum = thirdNum
                sum += thirdNum
                Console.WriteLine("{0}:{1}", i, thirdNum)
            Next

            Console.WriteLine("The sum is: {0}", sum)
        End Sub
    End Class
End Namespace
