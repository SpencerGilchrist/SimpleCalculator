'Spencer Gilchrist
'RCET0265
'Spring 2021
'Simple Calculator

Module SimpleCalculator

    Sub Main()

        Dim FirstNumber As String
        Dim SecondNumber As String
        Dim UserInput As String
        Dim Problem As Boolean
Line1:

        Console.WriteLine("Enter a Number!")


        Try
            UserInput = Console.ReadLine
            FirstNumber = CInt(UserInput)
            Problem = False

        Catch e As Exception
            Console.WriteLine("You Entered a Letter in a calculator?")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Try a number this time")
            System.Threading.Thread.Sleep(2500)
            Console.Clear()
            GoTo Line1
        End Try

        Console.WriteLine("Enter another number!")

        Try
            UserInput = Console.ReadLine
            SecondNumber = CInt(UserInput)
            Problem = False

        Catch e As Exception
            Console.WriteLine("You Entered a Letter in a calculator?")
            System.Threading.Thread.Sleep(1500)
            Console.WriteLine("Try a number this time")
            System.Threading.Thread.Sleep(2500)
            Console.Clear()
            GoTo Line1
        End Try

        Console.WriteLine("Please Choose a funtion.")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("Q for add. W for subtract. E for divide. R for multiply.")

        Select Case Console.ReadKey.Key
            Case ConsoleKey.Q
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) + Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.W
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) - Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.E
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) / Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

            Case ConsoleKey.R
                Console.Clear()
                Console.WriteLine(Int(FirstNumber) * Int(SecondNumber))
                System.Threading.Thread.Sleep(1500)
                Console.WriteLine("Press enter")
                Console.ReadLine()

        End Select

        Console.WriteLine("Would you Like to keep using the calculator or Exit?")
        System.Threading.Thread.Sleep(1500)
        Console.WriteLine("Press Y for Yes or N for No.")

        Select Case Console.ReadKey.Key

            Case ConsoleKey.Y
                Console.Clear()
                GoTo Line1

            Case ConsoleKey.N
                Console.Clear()
        End Select

    End Sub

End Module
