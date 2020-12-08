Module Module1

    Sub Main()
        Dim n, ns As Integer

        Do While True
            n = InputBox("dammi il numero <150")
            If n < 0 And n > 0 And n < 151 Then
                Exit Do
            End If
        Loop


        Dim vet_1(n), vet_2(n), vet3(n) As Integer

        For x = 0 To UBound(vet_1) - 1
            vet_1(x) = InputBox("dammi il numero <150")
            If x Mod 2 = 0 Then
                vet_2(x) = vet_1(x)
                ns += 1
            Else
                vet3(x) = vet_1(x)
            End If
        Next

        ReDim Preserve vet_2(ns)
        ReDim Preserve vet3(n - ns)


        MsgBox("vet pari")
        For x = 0 To UBound(vet_2)
            Console.Write(x & " ")
        Next
        MsgBox("vet dispari")
        For x = 0 To UBound(vet3)
            Console.Write(x & " ")
        Next

    End Sub

End Module
