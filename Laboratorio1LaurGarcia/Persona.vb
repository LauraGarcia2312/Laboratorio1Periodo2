Public Class Persona

    Public Nombre As String
    Public apellido As String
    Public DUI As String
    Public Estado As Boolean
    'si es true esta contrado, si es false no'
    Public Fecha_inicio As Date
    Public sexo As Char 'M o F'


    Friend Function afp() As String
        Throw New NotImplementedException()
    End Function


    Public Function MostrarDatos(persona As Persona) As Persona
        Return persona
    End Function


End Class
