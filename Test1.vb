Module Module1

    Sub Main()
        Dim str1, str2, str3, nextchar, nchar As String
        Dim count, length, den As Integer
        Dim valBinaryNum As Boolean

        str1 = "23456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ"
        str2 = ""
        str3 = ""
        nextChar = ""
        count = 0
        length = 0
        valBinaryNum = True
        den = 0
        nchar = ""

        Console.Write("enter a binary string: ")
        str2 = Console.ReadLine

        length = Len(str2)

        If length < 1 Or length > 8 Then
            Console.WriteLine("Not a valid binary number")
        Else
            For count = 1 To length
                nextChar = Mid(str2, count, 1)
                If InStr(str1, nextChar) <> 0 Then
                    valBinaryNum = False
                    Console.WriteLine("Not a valid binary number")
                    Exit For
                End If
            Next


            For count = length To 1 Step -1
                nchar = Mid(str2, count, 1)
                str3 = str3 & nchar
            Next

            For count = length To 1 Step -1
                nextchar = Mid(str3, count, 1)
                den = den + (2 ^ count * nextchar) / 2

            Next
            Console.WriteLine(den)
        End If

        Console.ReadKey()



    End Sub

End Module
