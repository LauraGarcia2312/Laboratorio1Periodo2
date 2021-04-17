Public Class Trabajador
    Inherits Persona

    Private _afp As String
    Public salario As Boolean

    Public Function GetAfp() As String
        Return _afp
    End Function

    Public Sub SetAfp(value As String)
        _afp = value
    End Sub

    Public Function CalcularSueldo(sueldo As Decimal, desc As Decimal) As Decimal
        Return sueldo - desc
    End Function

    Public Function Contratar(trabajador As Trabajador) As Trabajador
        trabajador.Estado = True
    End Function

End Class
