Imports Cosmos.Kernel.System

Public Class CoreShell
    Public Sub New()
        Console.Write("> ")
        Dim input As String = Console.ReadLine()

        If String.IsNullOrEmpty(input) Then
            Return
        End If

        Select Case input.ToLower()
            Case "help"
                Console.WriteLine("Available commands:")
                Console.WriteLine("  help     - Show this help message")
                Console.WriteLine("  clear    - Clear the screen")
                Console.WriteLine("  halt     - Halt the system")

            Case "clear"
                Console.Clear()

            Case "halt"
                Console.WriteLine("Halting system...")
                While True
                    Power.Halt()
                End While
            Case Else
                Console.WriteLine($"""{input}"" is not a command")
        End Select
    End Sub

End Class
