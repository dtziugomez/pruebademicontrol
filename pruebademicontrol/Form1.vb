Public Class Form1

    Private Sub ColorMixer1_Cambiar(ByVal sender As System.Object, ByVal args As controlpersonalizado.ColorMixer.ColorMixerConEventos) Handles ColorMixer1.Cambiar
        Label1.BackColor = Color.FromArgb(args.Rojo, args.Verde, args.Azul)
    End Sub
End Class
