<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JanelaPar
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LNome = New System.Windows.Forms.Label()
        Me.PBImagem = New System.Windows.Forms.PictureBox()
        Me.Tempo = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PBImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LNome
        '
        Me.LNome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LNome.BackColor = System.Drawing.Color.White
        Me.LNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LNome.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNome.Location = New System.Drawing.Point(13, 9)
        Me.LNome.Name = "LNome"
        Me.LNome.Size = New System.Drawing.Size(552, 69)
        Me.LNome.TabIndex = 0
        Me.LNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PBImagem
        '
        Me.PBImagem.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PBImagem.BackColor = System.Drawing.Color.White
        Me.PBImagem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PBImagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBImagem.Location = New System.Drawing.Point(13, 81)
        Me.PBImagem.Name = "PBImagem"
        Me.PBImagem.Size = New System.Drawing.Size(552, 552)
        Me.PBImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBImagem.TabIndex = 1
        Me.PBImagem.TabStop = False
        '
        'Tempo
        '
        Me.Tempo.Interval = 3000
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(577, 645)
        Me.ControlBox = False
        Me.Controls.Add(Me.PBImagem)
        Me.Controls.Add(Me.LNome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        CType(Me.PBImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LNome As Label
    Friend WithEvents PBImagem As PictureBox
    Friend WithEvents Tempo As Timer
End Class
