'ChristopherZ
'Spring 2025
'RCET2265
'Operators Example
'https://github.com/Christopher-isu/SayMyName.git
Module SayMyName

    Sub Main()
        ' Prompt the user to enter their name
        Console.Write("Enter your name: ")

        ' Save user input as a variable
        Dim userName As String = Console.ReadLine()

        ' Display a hello message with the user's name
        Console.WriteLine("Hello, " & userName & "!")

        ' Keep console open untill button pressed
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

End Module

