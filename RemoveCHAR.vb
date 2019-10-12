 
Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, nextChar As String
        Dim Counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        nextChar = ""
        Counter = 0

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        Console.Write("Enter character to be removed: ")
        Char1 = Console.ReadLine

        For Counter = 1 To Len(Str1)
            nextChar = Mid(Str1, Counter, 1)
            If nextChar <> Char1 Then
                Str2 = Str2 & nextChar
            End If

        Next
        Console.WriteLine("Final string is = " & Str2)

        Console.ReadKey()


    End Sub

End Module