Module Module1

    Sub Main()
        Dim Str1, Str2, nextChar As String
        Dim isPangram As Boolean
        Dim Count As Integer

        Str1 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Str2 = ""
        nextChar = ""
        isPangram = False
        Count = 0

        Console.Write("Enter a pangram: ")
        Str2 = Console.ReadLine

        If Len(Str2) < 26 Then
            Console.WriteLine("Sentence is not a pangram")
        Else
            Str2 = UCase(Str2)
            For Count = 65 To 90
                nextChar = Mid(Str1, Count, 1)
                If InStr(Str2, nextChar) <> 0 Then
                    isPangram = True
                Else
                    isPangram = False
                    Exit For
                End If
            Next
        If isPangram = True Then
            Console.WriteLine("Sentence is a pangram")
        Else
            Console.WriteLine("Sentence is not a Pangram")
            End If
        End If

        Console.ReadKey()


    End Sub

End Module
