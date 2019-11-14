Module Module1

    Sub Main()
        Dim Str1, Str2, nextCHAR, HighestCHAR As String
        Dim Counter, High, Count As Integer
        Dim AnyRepChar As Boolean

        Str1 = ""
        Str2 = ""
        Counter = 0
        High = 0
        Count = 0
        nextCHAR = ""
        HighestCHAR = ""
        AnyRepChar = False

        Console.Write("Enter a String = ")
        Str1 = Console.ReadLine

        Str1 = UCase(Str1)

        If Len(Str1) <> 0 Then
            For Count = 1 To Len(Str1)
                nextCHAR = Mid(Str1, Count, 1)
                Str2 = Str1

                While InStr(Str2, nextCHAR) <> 0
                    Counter = Counter + 1
                    Str2 = Left(Str2, InStr(Str2, nextCHAR) - 1) & Right(Str2, Len(Str2) - InStr(Str2, nextCHAR))
                End While

                If Counter > High Then
                    HighestCHAR = nextCHAR
                    AnyRepChar = True
                End If
                High = Counter
                Counter = 0
            Next

            If AnyRepChar = True Then
                Console.WriteLine("Highest Repeated Character = " & HighestCHAR)
            End If
        Else
            Console.WriteLine("Not a Valid String")
        End If

        Console.ReadKey()

    End Sub

End Module
