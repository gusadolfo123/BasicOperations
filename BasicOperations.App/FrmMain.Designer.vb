<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AxMedia = New AxWMPLib.AxWindowsMediaPlayer()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnPlay = New System.Windows.Forms.Button()
        Me.btnPause = New System.Windows.Forms.Button()
        Me.btnContinuous = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rtxbox = New System.Windows.Forms.RichTextBox()
        Me.picLogic = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.AxMedia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.picLogic, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblTitle.Size = New System.Drawing.Size(928, 82)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Operaciones básicas de programación"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnContinuous)
        Me.Panel1.Controls.Add(Me.btnPause)
        Me.Panel1.Controls.Add(Me.btnPlay)
        Me.Panel1.Controls.Add(Me.btnStop)
        Me.Panel1.Controls.Add(Me.AxMedia)
        Me.Panel1.Location = New System.Drawing.Point(21, 108)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(435, 397)
        Me.Panel1.TabIndex = 3
        '
        'AxMedia
        '
        Me.AxMedia.Enabled = True
        Me.AxMedia.Location = New System.Drawing.Point(17, 73)
        Me.AxMedia.Name = "AxMedia"
        Me.AxMedia.OcxState = CType(resources.GetObject("AxMedia.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMedia.Size = New System.Drawing.Size(398, 302)
        Me.AxMedia.TabIndex = 0
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(219, 17)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(95, 50)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Parar"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnPlay
        '
        Me.btnPlay.Location = New System.Drawing.Point(17, 17)
        Me.btnPlay.Name = "btnPlay"
        Me.btnPlay.Size = New System.Drawing.Size(95, 50)
        Me.btnPlay.TabIndex = 2
        Me.btnPlay.Text = "Iniciar"
        Me.btnPlay.UseVisualStyleBackColor = True
        '
        'btnPause
        '
        Me.btnPause.Location = New System.Drawing.Point(118, 17)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Size = New System.Drawing.Size(95, 50)
        Me.btnPause.TabIndex = 3
        Me.btnPause.Text = "Pausar"
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnContinuous
        '
        Me.btnContinuous.Location = New System.Drawing.Point(320, 17)
        Me.btnContinuous.Name = "btnContinuous"
        Me.btnContinuous.Size = New System.Drawing.Size(95, 50)
        Me.btnContinuous.TabIndex = 4
        Me.btnContinuous.Text = "Continuar"
        Me.btnContinuous.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.picLogic)
        Me.Panel2.Controls.Add(Me.rtxbox)
        Me.Panel2.Location = New System.Drawing.Point(471, 108)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(432, 397)
        Me.Panel2.TabIndex = 4
        '
        'rtxbox
        '
        Me.rtxbox.Location = New System.Drawing.Point(16, 223)
        Me.rtxbox.Name = "rtxbox"
        Me.rtxbox.Size = New System.Drawing.Size(401, 152)
        Me.rtxbox.TabIndex = 0
        Me.rtxbox.Text = ""
        '
        'picLogic
        '
        Me.picLogic.Image = Global.BasicOperations.App.My.Resources.Resources.operadores
        Me.picLogic.Location = New System.Drawing.Point(16, 17)
        Me.picLogic.Name = "picLogic"
        Me.picLogic.Size = New System.Drawing.Size(401, 200)
        Me.picLogic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogic.TabIndex = 1
        Me.picLogic.TabStop = False
        '
        'FrmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(928, 567)
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
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents lblTitle As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AxMedia As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents btnStop As Button
    Friend WithEvents btnPlay As Button
    Friend WithEvents btnPause As Button
    Friend WithEvents btnContinuous As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents rtxbox As RichTextBox
    Friend WithEvents picLogic As PictureBox
End Class
