Option Explicit On
Option Strict On
'Rudy Earnest
'RCET2265
'Spring 2025
'Say My Name
'https://github.com/rc-earnest/sayMyName_again.git
Imports System.Data.Common

Module sayMyName_again

    Sub Main()
        Dim Name As String
        Console.WriteLine("What is your name?")
        Console.WriteLine()
        Name = Console.ReadLine 'gets user input
        Console.WriteLine()
        If Name = "Emily" Then
            Console.WriteLine("Hello Emily, What a joy it is to see you again!")
        ElseIf Name = "Joe" Then
            Console.WriteLine("Hey Joe, I hope you have been well!")
        ElseIf Name = "Rudy" Then
            Console.WriteLine("Hello Rudy, did you finish your lab?")
        Else
            Console.WriteLine("I do not know you, please leave.")
        End If
    End Sub

End Module
