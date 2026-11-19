Imports Sys = Cosmos.Kernel.System
Imports tinosvb.shell

''' <summary>
''' Main kernel class - inherits from Cosmos.Kernel.System.Kernel.
''' </summary>
Public Class Kernel
    Inherits Sys.Kernel

    Protected Overrides Sub BeforeRun()
        Console.WriteLine("Cosmos booted successfully!")
        Console.WriteLine("Type a command to get it executed.")
    End Sub

    Protected Overrides Sub Run()
        Dim shell As New CoreShell()
    End Sub
End Class
