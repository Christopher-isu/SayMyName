Module SayMyName

    Sub Main()
        ' Prompt the user to enter their name
        Console.Write("Please enter your name: ")

        ' Save the user input to a variable
        Dim userName As String = Console.ReadLine()

        ' Display a hello message with the user's name
        Console.WriteLine("Hello, " & userName & "!")

        ' Prevent the console window from closing immediately
        Console.WriteLine("Press any key to exit.")
        Console.ReadKey()
    End Sub

End Module

