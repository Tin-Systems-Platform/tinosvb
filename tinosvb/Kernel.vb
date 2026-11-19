Imports Sys = Cosmos.Kernel.System
Imports tinosvb.shell

''' <summary>
''' Main kernel class - inherits from Cosmos.Kernel.System.Kernel.
''' </summary>
Public Class Kernel
    Inherits Sys.Kernel

    Protected Overrides Sub BeforeRun()
        Console.WriteLine("Welcome to the TinosVB! The exciting journey begins with VB here.")
        Console.WriteLine("Type 'help' for a list of available commands.")
    End Sub

    Protected Overrides Sub Run()
        Dim shell As New CoreShell()
    End Sub
End Class
