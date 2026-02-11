Module Module1

    Sub Main()
		Console.Clear()
		Console.WriteLine("Input coefficients of lineal equation")
		Dim a As Single
		Single.TryParse(Console.ReadLine(), a)
		Dim b As Single
		Single.TryParse(Console.ReadLine(), b)
		Dim c As Single
		Single.TryParse(Console.ReadLine(), c)
		Console.WriteLine("Trying to solve the equation:{0} * x ^ 2 + {1} * x + {2} = 0", a, b, c)
		If a = 0 Then
			If (b = 0) AndAlso (c = 0) Then
				Console.WriteLine("The answer is any number")
			ElseIf (b = 0) AndAlso (c <> 0) Then
				Console.WriteLine("The equation has no roots")
			Else
				Console.WriteLine("The equation has the following root:{0}", -c / b)
			End If
		Else
			Dim d = b * b - 4 * a * c
			Dim nRoots = Math.Sign(d) + 1
			If nRoots > 0 Then
				Dim x1 = (-b - Math.Sqrt(d)) / (2 * a)
				Dim x2 = (-b + Math.Sqrt(d)) / (2 * a)
				Console.WriteLine("The equation has the following roots:")
				Console.WriteLine("x1 = {0}", x1)
				Console.WriteLine("x2 = {0}", x2)
			Else
				Console.WriteLine("The equation has no roots")
			End If
		End If
		Console.Read()
	End Sub

End Module
