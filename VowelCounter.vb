Module Module1

    Sub Main()
        Dim vowel, str1, nextChar As String
        Dim totalv, count As Integer

        vowel = "AEIOUaeiou"
        str1 = ""
        totalv = 0
        count = 0
        nextChar = ""

        Console.Write("Enter a string: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextChar = Mid(str1, count, 1)
            If InStr(vowel, nextChar) Then
                totalv = totalv + 1
            End If
        Next

        Console.WriteLine(totalv)

        Console.ReadKey()





    End Sub

End Module
