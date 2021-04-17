Public Class Obrero
    Inherits Persona

    Public costoHora As Decimal
    Public CostoHoraExtra As Decimal
    Public HorasExtras As Decimal
    Public Horas As Decimal

    Public Function CalculadorSueldo(sueldo As Decimal, desc As Decimal) As Decimal
        Return sueldo - desc
    End Function

    Public Function Contratar(obrero As Obrero) As Obrero
        obrero.Estado = True
    End Function
End Class
