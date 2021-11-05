<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class JanelaPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PJogo = New System.Windows.Forms.Panel()
        Me.TempoCartasAbertas = New System.Windows.Forms.Timer(Me.components)
        Me.LPares = New System.Windows.Forms.Label()
        Me.LTempo = New System.Windows.Forms.Label()
        Me.TempoJogo = New System.Windows.Forms.Timer(Me.components)
        Me.BNovo = New System.Windows.Forms.Button()
        Me.CBEscolha = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBForm2 = New System.Windows.Forms.CheckBox()
        Me.TempoPar = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CBNivel = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LTentativas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PBTrofeu = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PBTrofeu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PJogo
        '
        Me.PJogo.Location = New System.Drawing.Point(12, 12)
        Me.PJogo.Name = "PJogo"
        Me.PJogo.Size = New System.Drawing.Size(674, 674)
        Me.PJogo.TabIndex = 33
        '
        'TempoCartasAbertas
        '
        Me.TempoCartasAbertas.Interval = 1000
        '
        'LPares
        '
        Me.LPares.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LPares.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LPares.Location = New System.Drawing.Point(9, 198)
        Me.LPares.Name = "LPares"
        Me.LPares.Size = New System.Drawing.Size(173, 47)
        Me.LPares.TabIndex = 34
        Me.LPares.Text = "Pares: 0 / 32"
        Me.LPares.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LTempo
        '
        Me.LTempo.BackColor = System.Drawing.SystemColors.Control
        Me.LTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTempo.ForeColor = System.Drawing.Color.Black
        Me.LTempo.Location = New System.Drawing.Point(9, 350)
        Me.LTempo.Name = "LTempo"
        Me.LTempo.Size = New System.Drawing.Size(173, 47)
        Me.LTempo.TabIndex = 35
        Me.LTempo.Text = "00:00"
        Me.LTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TempoJogo
        '
        Me.TempoJogo.Interval = 1000
        '
        'BNovo
        '
        Me.BNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.BNovo.Location = New System.Drawing.Point(9, 9)
        Me.BNovo.Margin = New System.Windows.Forms.Padding(0)
        Me.BNovo.Name = "BNovo"
        Me.BNovo.Size = New System.Drawing.Size(173, 47)
        Me.BNovo.TabIndex = 0
        Me.BNovo.Text = "Novo Jogo"
        Me.BNovo.UseVisualStyleBackColor = True
        '
        'CBEscolha
        '
        Me.CBEscolha.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBEscolha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBEscolha.Items.AddRange(New Object() {"Aleatório", "Bandeiras de Países", "Comidas e Bebidas", "Objetos", "Times Brasileiros", "Times da NFL", "Times Europeus"})
        Me.CBEscolha.Location = New System.Drawing.Point(9, 86)
        Me.CBEscolha.Margin = New System.Windows.Forms.Padding(2)
        Me.CBEscolha.Name = "CBEscolha"
        Me.CBEscolha.Size = New System.Drawing.Size(173, 28)
        Me.CBEscolha.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 121)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Dificuldade:"
        '
        'CBForm2
        '
        Me.CBForm2.AutoSize = True
        Me.CBForm2.CheckAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CBForm2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBForm2.Location = New System.Drawing.Point(15, 688)
        Me.CBForm2.Name = "CBForm2"
        Me.CBForm2.Size = New System.Drawing.Size(285, 20)
        Me.CBForm2.TabIndex = 3
        Me.CBForm2.Text = "Mostrar nome e imagem quando formar par"
        Me.CBForm2.TextAlign = System.Drawing.ContentAlignment.TopLeft
        Me.CBForm2.UseVisualStyleBackColor = True
        '
        'TempoPar
        '
        Me.TempoPar.Interval = 1000
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 16)
        Me.Label2.TabIndex = 41
        Me.Label2.Text = "Tema:"
        '
        'CBNivel
        '
        Me.CBNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBNivel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.CBNivel.Items.AddRange(New Object() {"Fácil (4x4)", "Intermediário (6x6)", "Difícil (8x8)"})
        Me.CBNivel.Location = New System.Drawing.Point(9, 139)
        Me.CBNivel.Margin = New System.Windows.Forms.Padding(2)
        Me.CBNivel.Name = "CBNivel"
        Me.CBNivel.Size = New System.Drawing.Size(173, 28)
        Me.CBNivel.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 179)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 16)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "Progresso:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 330)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 16)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tempo:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.LTentativas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.LTempo)
        Me.Panel1.Controls.Add(Me.CBEscolha)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.CBNivel)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.LPares)
        Me.Panel1.Controls.Add(Me.BNovo)
        Me.Panel1.Location = New System.Drawing.Point(693, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(194, 409)
        Me.Panel1.TabIndex = 44
        '
        'LTentativas
        '
        Me.LTentativas.BackColor = System.Drawing.SystemColors.Control
        Me.LTentativas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LTentativas.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTentativas.ForeColor = System.Drawing.Color.Black
        Me.LTentativas.Location = New System.Drawing.Point(9, 274)
        Me.LTentativas.Name = "LTentativas"
        Me.LTentativas.Size = New System.Drawing.Size(173, 47)
        Me.LTentativas.TabIndex = 44
        Me.LTentativas.Text = "0"
        Me.LTentativas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 254)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 16)
        Me.Label6.TabIndex = 45
        Me.Label6.Text = "Número de tentativas:"
        '
        'PBTrofeu
        '
        Me.PBTrofeu.BackColor = System.Drawing.Color.LightYellow
        Me.PBTrofeu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PBTrofeu.Image = Global.Memória.My.Resources.Resources.Troféu
        Me.PBTrofeu.Location = New System.Drawing.Point(693, 431)
        Me.PBTrofeu.Name = "PBTrofeu"
        Me.PBTrofeu.Size = New System.Drawing.Size(194, 252)
        Me.PBTrofeu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PBTrofeu.TabIndex = 45
        Me.PBTrofeu.TabStop = False
        Me.PBTrofeu.Visible = False
        '
        'JanelaPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 719)
        Me.Controls.Add(Me.PBTrofeu)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CBForm2)
        Me.Controls.Add(Me.PJogo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "JanelaPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "Memória"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PBTrofeu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PJogo As Panel
    Friend WithEvents TempoCartasAbertas As Timer
    Friend WithEvents LPares As Label
    Friend WithEvents LTempo As Label
    Friend WithEvents TempoJogo As Timer
    Friend WithEvents BNovo As Button
    Friend WithEvents CBEscolha As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CBForm2 As CheckBox
    Friend WithEvents TempoPar As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents CBNivel As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LTentativas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents PBTrofeu As PictureBox
End Class
