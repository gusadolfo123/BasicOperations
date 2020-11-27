Imports System.Media

Public Class FrmMain

    Dim backmusic As New Media.SoundPlayer("Audios/Operadores_Logicos.wav")

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AxMedia.URL = "Videos/Operadores_Logicos.mp4"
        AxMedia.Ctlcontrols.stop()
    End Sub

    Private Sub btnPlayVideo_Click(sender As Object, e As EventArgs) Handles btnPlayVideo.Click
        AxMedia.Ctlcontrols.play()
    End Sub

    Private Sub btnPauseVideo_Click(sender As Object, e As EventArgs) Handles btnPauseVideo.Click
        AxMedia.Ctlcontrols.pause()
    End Sub

    Private Sub btnStopVideo_Click(sender As Object, e As EventArgs) Handles btnStopVideo.Click
        AxMedia.Ctlcontrols.stop()
    End Sub

    Private Sub btnContinuousVideo_Click(sender As Object, e As EventArgs) Handles btnContinuousVideo.Click
        AxMedia.Ctlcontrols.play()
    End Sub

    Private Sub btnPLayAudio_Click(sender As Object, e As EventArgs) Handles btnPLayAudio.Click
        backmusic.Play()
    End Sub

    Private Sub btnStopAudio_Click(sender As Object, e As EventArgs) Handles btnStopAudio.Click
        backmusic.Stop()
    End Sub

End Class