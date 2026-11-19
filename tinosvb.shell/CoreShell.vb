Imports Cosmos.Kernel.System
Imports tinosvb.shell.Commands

Public Class CoreShell
    Public Sub New()
        Console.Write("> ")
        Dim input As String = Console.ReadLine()

        If String.IsNullOrEmpty(input) Then
            Return
        End If

        Select Case input.ToLower()
            Case "help"
                Dim help As New Help()
                help.HelpCmd()

            Case "clear"
                Console.Clear()

            Case "halt"
                Console.WriteLine("Halting system...")
                While True
                    Power.Halt()
                End While
            Case "ver"
                Dim about As New About()
                about.VerCmd()
            Case "credit"
                Dim about As New About()
                about.CreditCmd()
            Case Else
                Console.WriteLine($"""{input}"" is not a command")
        End Select
    End Sub

End Class
