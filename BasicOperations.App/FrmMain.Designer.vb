﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnContinuousVideo = New System.Windows.Forms.Button()
        Me.btnPauseVideo = New System.Windows.Forms.Button()
        Me.btnPlayVideo = New System.Windows.Forms.Button()
        Me.btnStopVideo = New System.Windows.Forms.Button()
        Me.AxMedia = New AxWMPLib.AxWindowsMediaPlayer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.picLogic = New System.Windows.Forms.PictureBox()
        Me.rtxbox = New System.Windows.Forms.RichTextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnPLayAudio = New System.Windows.Forms.Button()
        Me.btnStopAudio = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.lblTitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.lblTitle.ForeColor = System.Drawing.Color.White
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(1112, 82)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Operaciones básicas de programación"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnContinuousVideo)
        Me.Panel1.Controls.Add(Me.btnPauseVideo)
        Me.Panel1.Controls.Add(Me.btnPlayVideo)
        Me.Panel1.Controls.Add(Me.btnStopVideo)
        Me.Panel1.Controls.Add(Me.AxMedia)
        Me.Panel1.Location = New System.Drawing.Point(21, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(516, 394)
        Me.Panel1.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(516, 42)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Video"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnContinuousVideo
        '
        Me.btnContinuousVideo.Location = New System.Drawing.Point(395, 47)
        Me.btnContinuousVideo.Name = "btnContinuousVideo"
        Me.btnContinuousVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnContinuousVideo.TabIndex = 4
        Me.btnContinuousVideo.Text = "Continuar"
        Me.btnContinuousVideo.UseVisualStyleBackColor = True
        '
        'btnPauseVideo
        '
        Me.btnPauseVideo.Location = New System.Drawing.Point(135, 47)
        Me.btnPauseVideo.Name = "btnPauseVideo"
        Me.btnPauseVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnPauseVideo.TabIndex = 3
        Me.btnPauseVideo.Text = "Pausar"
        Me.btnPauseVideo.UseVisualStyleBackColor = True
        '
        'btnPlayVideo
        '
        Me.btnPlayVideo.Location = New System.Drawing.Point(4, 47)
        Me.btnPlayVideo.Name = "btnPlayVideo"
        Me.btnPlayVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnPlayVideo.TabIndex = 2
        Me.btnPlayVideo.Text = "Iniciar"
        Me.btnPlayVideo.UseVisualStyleBackColor = True
        '
        'btnStopVideo
        '
        Me.btnStopVideo.Location = New System.Drawing.Point(266, 47)
        Me.btnStopVideo.Name = "btnStopVideo"
        Me.btnStopVideo.Size = New System.Drawing.Size(118, 50)
        Me.btnStopVideo.TabIndex = 1
        Me.btnStopVideo.Text = "Parar"
        Me.btnStopVideo.UseVisualStyleBackColor = True
        '
        'AxMedia
        '
        Me.AxMedia.Enabled = True
        Me.AxMedia.Location = New System.Drawing.Point(2, 101)
        Me.AxMedia.Name = "AxMedia"
        Me.AxMedia.OcxState = CType(resources.GetObject("AxMedia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMedia.Size = New System.Drawing.Size(510, 322)
        Me.AxMedia.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.picLogic)
        Me.Panel2.Controls.Add(Me.rtxbox)
        Me.Panel2.Location = New System.Drawing.Point(543, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 621)
        Me.Panel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(547, 42)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Imagenes y Texto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picLogic
        '
        Me.picLogic.Image = Global.BasicOperations.App.My.Resources.Resources.operadores
        Me.picLogic.Location = New System.Drawing.Point(15, 47)
        Me.picLogic.Name = "picLogic"
        Me.picLogic.Size = New System.Drawing.Size(514, 298)
        Me.picLogic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogic.TabIndex = 1
        Me.picLogic.TabStop = False
        '
        'rtxbox
        '
        Me.rtxbox.Location = New System.Drawing.Point(15, 351)
        Me.rtxbox.Name = "rtxbox"
        Me.rtxbox.Size = New System.Drawing.Size(514, 258)
        Me.rtxbox.TabIndex = 0
        Me.rtxbox.Text = resources.GetString("rtxbox.Text")
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnPLayAudio)
        Me.Panel3.Controls.Add(Me.btnStopAudio)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(25, 516)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(509, 213)
        Me.Panel3.TabIndex = 5
        '
        'btnPLayAudio
        '
        Me.btnPLayAudio.Location = New System.Drawing.Point(2, 48)
        Me.btnPLayAudio.Name = "btnPLayAudio"
        Me.btnPLayAudio.Size = New System.Drawing.Size(253, 50)
        Me.btnPLayAudio.TabIndex = 8
        Me.btnPLayAudio.Text = "Iniciar"
        Me.btnPLayAudio.UseVisualStyleBackColor = True
        '
        'btnStopAudio
        '
        Me.btnStopAudio.Location = New System.Drawing.Point(261, 48)
        Me.btnStopAudio.Name = "btnStopAudio"
        Me.btnStopAudio.Size = New System.Drawing.Size(245, 50)
        Me.btnStopAudio.TabIndex = 7
        Me.btnStopAudio.Text = "Parar"
        Me.btnStopAudio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(74, Byte), Integer), CType(CType(107, Byte), Integer))
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(509, 42)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Audio"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1112, 742)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMain"
        Me.Panel1.ResumeLayout(False)
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AxMedia As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnStopVideo As Button
    Friend WithEvents btnPlayVideo As Button
    Friend WithEvents btnPauseVideo As Button
    Friend WithEvents btnContinuousVideo As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtxbox As RichTextBox
    Friend WithEvents picLogic As PictureBox
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Private WithEvents Label3 As Label
    Friend WithEvents btnPLayAudio As Button
    Friend WithEvents btnStopAudio As Button
End Class
