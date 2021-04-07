Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO
Imports System.Net

Module Module1
    Private Function clt()
        Console.ResetColor()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("@@@@@@@   @@@@@@@    @@@@@@   @@@  @@@  @@@ @@@   @@@@@@    @@@@@@@  @@@@@@@    @@@@@@   @@@@@@@   @@@@@@@@  
@@@@@@@@  @@@@@@@@  @@@@@@@@  @@@  @@@  @@@ @@@  @@@@@@@   @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  
@@!  @@@  @@!  @@@  @@!  @@@  @@!  !@@  @@! !@@  !@@       !@@       @@!  @@@  @@!  @@@  @@!  @@@  @@!       
!@!  @!@  !@!  @!@  !@!  @!@  !@!  @!!  !@! @!!  !@!       !@!       !@!  @!@  !@!  @!@  !@!  @!@  !@!       
@!@@!@!   @!@!!@!   @!@  !@!   !@@!@!    !@!@!   !!@@!!    !@!       @!@!!@!   @!@!@!@!  @!@@!@!   @!!!:!    
!!@!!!    !!@!@!    !@!  !!!    @!!!      @!!!    !!@!!!   !!!       !!@!@!    !!!@!!!!  !!@!!!    !!!!!:    
!!:       !!: :!!   !!:  !!!   !: :!!     !!:         !:!  :!!       !!: :!!   !!:  !!!  !!:       !!:       
:!:       :!:  !:!  :!:  !:!  :!:  !:!    :!:        !:!   :!:       :!:  !:!  :!:  !:!  :!:       :!:       
 ::       ::   :::  ::::: ::   ::  :::     ::    :::: ::    ::: :::  ::   :::  ::   :::   ::        :: ::::  
 :         :   : :   : :  :    :   ::      :     :: : :     :: :: :   :   : :   :   : :   :        : :: ::   ")
        Console.WriteLine("Command Line Tool by JPN")
        Dim savedialog As New SaveFileDialog
        savedialog.Filter = "Text File | *.txt"
        savedialog.Title = "Save proxies"
        Console.ResetColor()
        Console.WriteLine("====================================================================================================")
        Dim args = Environment.GetCommandLineArgs()
        If args(1) = "help" Then
            Console.WriteLine("HELP:")
            Console.WriteLine("First Argument is the proxy type: http, socks4, socks5, any")
            Console.WriteLine("Second Argument is how many proxies you want: e.g. 7000")
            Console.WriteLine("Stay tuned for more clt options")
            ElseIf args(1) = "http" Then
                If Not args(2) = "" Then
                    Console.Write("Fetching {1} {0} proxies, please wait... ", args(1), args(2))
                    Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=http" + "&limit=" + args(2)
                    Dim wc As New WebClient
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Console.Write("Saving file... ")
                    savedialog.ShowDialog()
                    Dim file As FileStream = IO.File.Create(savedialog.FileName)
                    file.Close()
                    Dim filewrite As StreamWriter
                    filewrite = New StreamWriter(savedialog.FileName)
                    filewrite.WriteLine(wc.DownloadString(url))
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Else 
                        Console.Write("Fetching {0} proxies, please wait... ", args(1))
                        Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=http"
                        Dim wc As New WebClient
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                        Console.Write("Saving file... ")
                        savedialog.ShowDialog()
                        Dim file As FileStream = IO.File.Create(savedialog.FileName)
                        file.Close()
                        Dim filewrite As StreamWriter
                        filewrite = New StreamWriter(savedialog.FileName)
                        filewrite.WriteLine(wc.DownloadString(url))
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                End If
                ElseIf args(1) = "socks4" Then
                    If Not args(2) = "" Then
                    Console.Write("Fetching {1} {0} proxies, please wait... ", args(1), args(2))
                    Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks4" + "&limit=" + args(2)
                    Dim wc As New WebClient
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Console.Write("Saving file... ")
                    savedialog.ShowDialog()
                    Dim file As FileStream = IO.File.Create(savedialog.FileName)
                    file.Close()
                    Dim filewrite As StreamWriter
                    filewrite = New StreamWriter(savedialog.FileName)
                    filewrite.WriteLine(wc.DownloadString(url))
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Else 
                        Console.Write("Fetching {0} proxies, please wait... ", args(1))
                        Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks4"
                        Dim wc As New WebClient
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                        Console.Write("Saving file... ")
                        savedialog.ShowDialog()
                        Dim file As FileStream = IO.File.Create(savedialog.FileName)
                        file.Close()
                        Dim filewrite As StreamWriter
                        filewrite = New StreamWriter(savedialog.FileName)
                        filewrite.WriteLine(wc.DownloadString(url))
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                End If
                ElseIf args(1) = "socks5" Then
                    If Not args(2) = "" Then
                    Console.Write("Fetching {1} {0} proxies, please wait... ", args(1), args(2))
                    Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks5" + "&limit=" + args(2)
                    Dim wc As New WebClient
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Console.Write("Saving file... ")
                    savedialog.ShowDialog()
                    Dim file As FileStream = IO.File.Create(savedialog.FileName)
                    file.Close()
                    Dim filewrite As StreamWriter
                    filewrite = New StreamWriter(savedialog.FileName)
                    filewrite.WriteLine(wc.DownloadString(url))
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Else 
                        Console.Write("Fetching {0} proxies, please wait... ", args(1))
                        Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=socks5"
                        Dim wc As New WebClient
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                        Console.Write("Saving file... ")
                        savedialog.ShowDialog()
                        Dim file As FileStream = IO.File.Create(savedialog.FileName)
                        file.Close()
                        Dim filewrite As StreamWriter
                        filewrite = New StreamWriter(savedialog.FileName)
                        filewrite.WriteLine(wc.DownloadString(url))
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                End If
                ElseIf args(1) = "any" Then
                    If Not args(2) = "" Then
                    Console.Write("Fetching {0} proxies, please wait... ", args(2))
                    Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=all" + "&limit=" + args(2)
                    Dim wc As New WebClient
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Console.Write("Saving file... ")
                    savedialog.ShowDialog()
                    Dim file As FileStream = IO.File.Create(savedialog.FileName)
                    file.Close()
                    Dim filewrite As StreamWriter
                    filewrite = New StreamWriter(savedialog.FileName)
                    filewrite.WriteLine(wc.DownloadString(url))
                    Console.ForegroundColor = ConsoleColor.Green
                    Console.WriteLine("Done!")
                    Console.ResetColor()
                    Else 
                        Console.Write("Fetching {0} proxies, please wait... ", args(1))
                        Dim url As String = "https://api.proxyscrape.com/?request=displayproxies&proxytype=all"
                        Dim wc As New WebClient
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                        Console.Write("Saving file... ")
                        savedialog.ShowDialog()
                        Dim file As FileStream = IO.File.Create(savedialog.FileName)
                        file.Close()
                        Dim filewrite As StreamWriter
                        filewrite = New StreamWriter(savedialog.FileName)
                        filewrite.WriteLine(wc.DownloadString(url))
                        Console.ForegroundColor = ConsoleColor.Green
                        Console.WriteLine("Done!")
                        Console.ResetColor()
                End If
                    Else
                        Console.WriteLine("Invalid arguments!")
        End If
        Return True
    End Function
    Sub Main()
        ' If you have compiled this yourself, you should add the folder where the executable is to PATH
        Console.ForegroundColor = ConsoleColor.Blue
        Dim args = Environment.GetCommandLineArgs()
        If Not args.Length = 0 Then
            IF clt() = True Then
                Console.ReadKey()
                Environment.Exit(1)
            End If
        End If
        Console.WriteLine("@@@@@@@   @@@@@@@    @@@@@@   @@@  @@@  @@@ @@@   @@@@@@    @@@@@@@  @@@@@@@    @@@@@@   @@@@@@@   @@@@@@@@  
@@@@@@@@  @@@@@@@@  @@@@@@@@  @@@  @@@  @@@ @@@  @@@@@@@   @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  
@@!  @@@  @@!  @@@  @@!  @@@  @@!  !@@  @@! !@@  !@@       !@@       @@!  @@@  @@!  @@@  @@!  @@@  @@!       
!@!  @!@  !@!  @!@  !@!  @!@  !@!  @!!  !@! @!!  !@!       !@!       !@!  @!@  !@!  @!@  !@!  @!@  !@!       
@!@@!@!   @!@!!@!   @!@  !@!   !@@!@!    !@!@!   !!@@!!    !@!       @!@!!@!   @!@!@!@!  @!@@!@!   @!!!:!    
!!@!!!    !!@!@!    !@!  !!!    @!!!      @!!!    !!@!!!   !!!       !!@!@!    !!!@!!!!  !!@!!!    !!!!!:    
!!:       !!: :!!   !!:  !!!   !: :!!     !!:         !:!  :!!       !!: :!!   !!:  !!!  !!:       !!:       
:!:       :!:  !:!  :!:  !:!  :!:  !:!    :!:        !:!   :!:       :!:  !:!  :!:  !:!  :!:       :!:       
 ::       ::   :::  ::::: ::   ::  :::     ::    :::: ::    ::: :::  ::   :::  ::   :::   ::        :: ::::  
 :         :   : :   : :  :    :   ::      :     :: : :     :: :: :   :   : :   :   : :   :        : :: ::   ")
        Console.WriteLine("Command Line Tool by JPN")
        Console.ResetColor()
        Console.WriteLine("========================================================================================================================")
        Console.WriteLine("Time: {0}", Now)
        Console.WriteLine("------ MENU ------")
        Console.WriteLine("[1] Generate Proxies")
        Console.WriteLine("[2] Info")
        Console.WriteLine("[3] Exit")
    End Sub
End Module
