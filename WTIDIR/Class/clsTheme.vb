Public Class clsTheme
    ' ----- Accented Color -----
    Public PrimaryFont As Color = Color.White
    Public PrimaryBackground As Color = ColorTranslator.FromHtml("#990000")

    ' ----- Complimentary/Substitute color to primary -----
    Public SecondaryFont As Color = ColorTranslator.FromHtml("#333333")
    Public SecondaryBackground As Color = ColorTranslator.FromHtml("#F8C200")

    ' ----- Window Color -----
    Public SurfaceFont As Color = Color.White
    Public SurfaceBackground As Color = ColorTranslator.FromHtml("#333333")

    Public Enum ThemeTypes
        WaffleTime
        Coffeebreak
    End Enum

    Public Property ThemeType As ThemeTypes
        Get
            Return ThemeType
        End Get
        Set(value As ThemeTypes)
            Select Case ThemeType
                Case ThemeTypes.WaffleTime
                    PrimaryFont = Color.White
                    PrimaryBackground = ColorTranslator.FromHtml("#990000")
                    SecondaryFont = ColorTranslator.FromHtml("#333333")
                    SecondaryBackground = ColorTranslator.FromHtml("#F8C200")
                    SurfaceFont = Color.White
                    SurfaceBackground = ColorTranslator.FromHtml("#333333")
                Case ThemeTypes.Coffeebreak
            End Select
        End Set
    End Property
End Class
