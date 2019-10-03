Module Module1

    Sub Main()

        Dim Str1, Str2, Str3, FirstWord, LastWord As String
        Dim Space As Integer

        Str1 = ""
        Str2 = ""
        Str3 = ""
        FirstWord = ""
        LastWord = ""
        Space = 0

        Console.Write("Enter 1st String of 2 Words: ")
        Str1 = Console.ReadLine

        Console.Write("Enter 2nd string of 2 words: ")
        Str2 = Console.ReadLine

        Space = InStr(Str1, " ")
        FirstWord = Left(Str1, Space - 1)

        Space = InStr(Str2, " ")
        LastWord = Right(Str2, Len(Str2) - Space)

        Str3 = FirstWord & " " & LastWord
        Console.WriteLine(Str3)

        Console.ReadKey()

    End Sub

End Module
