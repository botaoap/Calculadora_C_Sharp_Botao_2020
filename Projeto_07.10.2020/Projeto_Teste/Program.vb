Imports System

Module Program

    Sub Main(args As String())

        CalcularListaString()

        CalcularListaDouble()

        CalcularListaInteger()

        'TODO Pesquisar outros tipos


        Console.ReadKey()
    End Sub

    Private Sub CalcularListaString()


        Dim _lista_string As List(Of String)


        _lista_string = New List(Of String)

        Dim _string As String

        _string = "João"

        _lista_string.Add(_string)

        _string = "Maria"

        _lista_string.Add(_string)

        _string = "Gabriel" & " Lorde "

        _lista_string.Add(_string)


        'TODO - Tentar o mesmo em c#
        For i = 0 To _lista_string.Count - 1
            Console.WriteLine(_lista_string(i))
        Next

        Dim _count As Integer = 0


        Do While _count < 3

            Console.WriteLine(_lista_string(_count))

            _count += 1
        Loop

        _count = 0


        While _count <= 2
            Console.WriteLine(_lista_string(_count))
            _count = _count + 1
        End While

        _count = 0

        Do Until _count > 2

            Console.WriteLine(_lista_string(_count))

            _count += 1
        Loop
    End Sub

    Private Sub CalcularListaDouble()
        Dim _double As Double

        Dim _lista_double As List(Of Double)

        _lista_double = New List(Of Double)

        _double = 1.1

        _lista_double.Add(_double)

        _double = 1.2

        _lista_double.Add(_double)

        _double = 1.3

        _lista_double.Add(_double)



        For i = 0 To 2

            Console.WriteLine(_lista_double(i))

        Next


    End Sub

    Private Sub CalcularListaInteger()
        Dim _integer As Integer

        Dim _lista_integer As List(Of Integer)

        _lista_integer = New List(Of Integer)

        _integer = 1

        _lista_integer.Add(_integer)

        _integer = 2

        _lista_integer.Add(_integer)

        _integer = 3

        _lista_integer.Add(_integer)


        For i = 0 To 2
            Console.WriteLine(_lista_integer(i))
        Next
    End Sub

End Module
