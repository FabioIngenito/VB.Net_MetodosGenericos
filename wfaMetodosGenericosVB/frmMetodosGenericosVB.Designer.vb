<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetodosGenericosVB
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.tabExemplo1 = New System.Windows.Forms.TabPage()
        Me.lblTexto2 = New System.Windows.Forms.Label()
        Me.lblTexto1 = New System.Windows.Forms.Label()
        Me.btnTrocaDeLugar = New System.Windows.Forms.Button()
        Me.txtTexto2 = New System.Windows.Forms.TextBox()
        Me.txtTexto1 = New System.Windows.Forms.TextBox()
        Me.lblTrocaDeLugar = New System.Windows.Forms.Label()
        Me.tabExemplo2 = New System.Windows.Forms.TabPage()
        Me.lblMaiorValorNumerico = New System.Windows.Forms.Label()
        Me.txtMaiorValorN = New System.Windows.Forms.TextBox()
        Me.btnComparaValoresNumericos = New System.Windows.Forms.Button()
        Me.lblValorN2 = New System.Windows.Forms.Label()
        Me.lblValorN1 = New System.Windows.Forms.Label()
        Me.txtValorN2 = New System.Windows.Forms.TextBox()
        Me.txtValorN1 = New System.Windows.Forms.TextBox()
        Me.lblComparaValoresNumericos = New System.Windows.Forms.Label()
        Me.lblMaiorValorAlfanumerico = New System.Windows.Forms.Label()
        Me.txtMaiorValorA = New System.Windows.Forms.TextBox()
        Me.btnComparaValoresAlfanumericos = New System.Windows.Forms.Button()
        Me.lblValorA2 = New System.Windows.Forms.Label()
        Me.lblValorA1 = New System.Windows.Forms.Label()
        Me.txtValorA2 = New System.Windows.Forms.TextBox()
        Me.txtValorA1 = New System.Windows.Forms.TextBox()
        Me.lblComparaValoresAlfanumericos = New System.Windows.Forms.Label()
        Me.tabExemplo3 = New System.Windows.Forms.TabPage()
        Me.btnCriaListaValoresNumerico = New System.Windows.Forms.Button()
        Me.btnCriaListaValoresAlfanumerico = New System.Windows.Forms.Button()
        Me.lblListaValoresAlfanumericos = New System.Windows.Forms.Label()
        Me.lvwListaValorAlfanumerico = New System.Windows.Forms.ListView()
        Me.lblListaValoresNumericos = New System.Windows.Forms.Label()
        Me.lvwListaValorNumerico = New System.Windows.Forms.ListView()
        Me.lblListaValorAlfanumerico = New System.Windows.Forms.Label()
        Me.lblListaValorNumerico = New System.Windows.Forms.Label()
        Me.txtListaValorAlfanumerico = New System.Windows.Forms.TextBox()
        Me.txtListaValorNumerico = New System.Windows.Forms.TextBox()
        Me.lblCriaLista = New System.Windows.Forms.Label()
        Me.tabControl1.SuspendLayout()
        Me.tabExemplo1.SuspendLayout()
        Me.tabExemplo2.SuspendLayout()
        Me.tabExemplo3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabControl1
        '
        Me.tabControl1.Controls.Add(Me.tabExemplo1)
        Me.tabControl1.Controls.Add(Me.tabExemplo2)
        Me.tabControl1.Controls.Add(Me.tabExemplo3)
        Me.tabControl1.Location = New System.Drawing.Point(12, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(486, 349)
        Me.tabControl1.TabIndex = 18
        '
        'tabExemplo1
        '
        Me.tabExemplo1.Controls.Add(Me.lblTexto2)
        Me.tabExemplo1.Controls.Add(Me.lblTexto1)
        Me.tabExemplo1.Controls.Add(Me.btnTrocaDeLugar)
        Me.tabExemplo1.Controls.Add(Me.txtTexto2)
        Me.tabExemplo1.Controls.Add(Me.txtTexto1)
        Me.tabExemplo1.Controls.Add(Me.lblTrocaDeLugar)
        Me.tabExemplo1.Location = New System.Drawing.Point(4, 22)
        Me.tabExemplo1.Name = "tabExemplo1"
        Me.tabExemplo1.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExemplo1.Size = New System.Drawing.Size(478, 323)
        Me.tabExemplo1.TabIndex = 0
        Me.tabExemplo1.Text = "Exemplo 1 - Sample 1"
        Me.tabExemplo1.UseVisualStyleBackColor = True
        '
        'lblTexto2
        '
        Me.lblTexto2.AutoSize = True
        Me.lblTexto2.Location = New System.Drawing.Point(3, 64)
        Me.lblTexto2.Name = "lblTexto2"
        Me.lblTexto2.Size = New System.Drawing.Size(46, 13)
        Me.lblTexto2.TabIndex = 12
        Me.lblTexto2.Text = "Texto 2:"
        '
        'lblTexto1
        '
        Me.lblTexto1.AutoSize = True
        Me.lblTexto1.Location = New System.Drawing.Point(3, 38)
        Me.lblTexto1.Name = "lblTexto1"
        Me.lblTexto1.Size = New System.Drawing.Size(46, 13)
        Me.lblTexto1.TabIndex = 11
        Me.lblTexto1.Text = "Texto 1:"
        '
        'btnTrocaDeLugar
        '
        Me.btnTrocaDeLugar.Location = New System.Drawing.Point(55, 87)
        Me.btnTrocaDeLugar.Name = "btnTrocaDeLugar"
        Me.btnTrocaDeLugar.Size = New System.Drawing.Size(216, 23)
        Me.btnTrocaDeLugar.TabIndex = 10
        Me.btnTrocaDeLugar.Text = "&Troca de Lugar - Change of Location"
        Me.btnTrocaDeLugar.UseVisualStyleBackColor = True
        '
        'txtTexto2
        '
        Me.txtTexto2.Location = New System.Drawing.Point(55, 61)
        Me.txtTexto2.Name = "txtTexto2"
        Me.txtTexto2.Size = New System.Drawing.Size(398, 20)
        Me.txtTexto2.TabIndex = 9
        Me.txtTexto2.Text = "Teste2"
        '
        'txtTexto1
        '
        Me.txtTexto1.Location = New System.Drawing.Point(55, 35)
        Me.txtTexto1.Name = "txtTexto1"
        Me.txtTexto1.Size = New System.Drawing.Size(398, 20)
        Me.txtTexto1.TabIndex = 8
        Me.txtTexto1.Text = "Teste1"
        '
        'lblTrocaDeLugar
        '
        Me.lblTrocaDeLugar.AutoSize = True
        Me.lblTrocaDeLugar.Location = New System.Drawing.Point(3, 12)
        Me.lblTrocaDeLugar.Name = "lblTrocaDeLugar"
        Me.lblTrocaDeLugar.Size = New System.Drawing.Size(188, 13)
        Me.lblTrocaDeLugar.TabIndex = 7
        Me.lblTrocaDeLugar.Text = "Troca de Lugar: - Change of Location:"
        '
        'tabExemplo2
        '
        Me.tabExemplo2.Controls.Add(Me.lblMaiorValorNumerico)
        Me.tabExemplo2.Controls.Add(Me.txtMaiorValorN)
        Me.tabExemplo2.Controls.Add(Me.btnComparaValoresNumericos)
        Me.tabExemplo2.Controls.Add(Me.lblValorN2)
        Me.tabExemplo2.Controls.Add(Me.lblValorN1)
        Me.tabExemplo2.Controls.Add(Me.txtValorN2)
        Me.tabExemplo2.Controls.Add(Me.txtValorN1)
        Me.tabExemplo2.Controls.Add(Me.lblComparaValoresNumericos)
        Me.tabExemplo2.Controls.Add(Me.lblMaiorValorAlfanumerico)
        Me.tabExemplo2.Controls.Add(Me.txtMaiorValorA)
        Me.tabExemplo2.Controls.Add(Me.btnComparaValoresAlfanumericos)
        Me.tabExemplo2.Controls.Add(Me.lblValorA2)
        Me.tabExemplo2.Controls.Add(Me.lblValorA1)
        Me.tabExemplo2.Controls.Add(Me.txtValorA2)
        Me.tabExemplo2.Controls.Add(Me.txtValorA1)
        Me.tabExemplo2.Controls.Add(Me.lblComparaValoresAlfanumericos)
        Me.tabExemplo2.Location = New System.Drawing.Point(4, 22)
        Me.tabExemplo2.Name = "tabExemplo2"
        Me.tabExemplo2.Padding = New System.Windows.Forms.Padding(3)
        Me.tabExemplo2.Size = New System.Drawing.Size(478, 323)
        Me.tabExemplo2.TabIndex = 1
        Me.tabExemplo2.Text = "Exemplo 2 - Sample 2"
        Me.tabExemplo2.UseVisualStyleBackColor = True
        '
        'lblMaiorValorNumerico
        '
        Me.lblMaiorValorNumerico.AutoSize = True
        Me.lblMaiorValorNumerico.Location = New System.Drawing.Point(9, 287)
        Me.lblMaiorValorNumerico.Name = "lblMaiorValorNumerico"
        Me.lblMaiorValorNumerico.Size = New System.Drawing.Size(47, 13)
        Me.lblMaiorValorNumerico.TabIndex = 27
        Me.lblMaiorValorNumerico.Text = "Maior N:"
        '
        'txtMaiorValorN
        '
        Me.txtMaiorValorN.Location = New System.Drawing.Point(58, 284)
        Me.txtMaiorValorN.Name = "txtMaiorValorN"
        Me.txtMaiorValorN.Size = New System.Drawing.Size(395, 20)
        Me.txtMaiorValorN.TabIndex = 26
        '
        'btnComparaValoresNumericos
        '
        Me.btnComparaValoresNumericos.Location = New System.Drawing.Point(58, 255)
        Me.btnComparaValoresNumericos.Name = "btnComparaValoresNumericos"
        Me.btnComparaValoresNumericos.Size = New System.Drawing.Size(395, 23)
        Me.btnComparaValoresNumericos.TabIndex = 25
        Me.btnComparaValoresNumericos.Text = "&Compara Valores Numéricos - Compare Numeric Values"
        Me.btnComparaValoresNumericos.UseVisualStyleBackColor = True
        '
        'lblValorN2
        '
        Me.lblValorN2.AutoSize = True
        Me.lblValorN2.Location = New System.Drawing.Point(6, 232)
        Me.lblValorN2.Name = "lblValorN2"
        Me.lblValorN2.Size = New System.Drawing.Size(51, 13)
        Me.lblValorN2.TabIndex = 24
        Me.lblValorN2.Text = "Valor N2:"
        '
        'lblValorN1
        '
        Me.lblValorN1.AutoSize = True
        Me.lblValorN1.Location = New System.Drawing.Point(6, 206)
        Me.lblValorN1.Name = "lblValorN1"
        Me.lblValorN1.Size = New System.Drawing.Size(51, 13)
        Me.lblValorN1.TabIndex = 23
        Me.lblValorN1.Text = "Valor N1:"
        '
        'txtValorN2
        '
        Me.txtValorN2.Location = New System.Drawing.Point(58, 229)
        Me.txtValorN2.Name = "txtValorN2"
        Me.txtValorN2.Size = New System.Drawing.Size(395, 20)
        Me.txtValorN2.TabIndex = 22
        Me.txtValorN2.Text = "23"
        '
        'txtValorN1
        '
        Me.txtValorN1.Location = New System.Drawing.Point(58, 203)
        Me.txtValorN1.Name = "txtValorN1"
        Me.txtValorN1.Size = New System.Drawing.Size(395, 20)
        Me.txtValorN1.TabIndex = 21
        Me.txtValorN1.Text = "199999"
        '
        'lblComparaValoresNumericos
        '
        Me.lblComparaValoresNumericos.AutoSize = True
        Me.lblComparaValoresNumericos.Location = New System.Drawing.Point(6, 180)
        Me.lblComparaValoresNumericos.Name = "lblComparaValoresNumericos"
        Me.lblComparaValoresNumericos.Size = New System.Drawing.Size(379, 13)
        Me.lblComparaValoresNumericos.TabIndex = 20
        Me.lblComparaValoresNumericos.Text = "Compara Qualquer Numérico (Valor Cheio): - Compare Any Number (Full Value):"
        '
        'lblMaiorValorAlfanumerico
        '
        Me.lblMaiorValorAlfanumerico.AutoSize = True
        Me.lblMaiorValorAlfanumerico.Location = New System.Drawing.Point(6, 139)
        Me.lblMaiorValorAlfanumerico.Name = "lblMaiorValorAlfanumerico"
        Me.lblMaiorValorAlfanumerico.Size = New System.Drawing.Size(46, 13)
        Me.lblMaiorValorAlfanumerico.TabIndex = 19
        Me.lblMaiorValorAlfanumerico.Text = "Maior A:"
        '
        'txtMaiorValorA
        '
        Me.txtMaiorValorA.Location = New System.Drawing.Point(55, 136)
        Me.txtMaiorValorA.Name = "txtMaiorValorA"
        Me.txtMaiorValorA.Size = New System.Drawing.Size(398, 20)
        Me.txtMaiorValorA.TabIndex = 18
        '
        'btnComparaValoresAlfanumericos
        '
        Me.btnComparaValoresAlfanumericos.Location = New System.Drawing.Point(55, 107)
        Me.btnComparaValoresAlfanumericos.Name = "btnComparaValoresAlfanumericos"
        Me.btnComparaValoresAlfanumericos.Size = New System.Drawing.Size(398, 23)
        Me.btnComparaValoresAlfanumericos.TabIndex = 17
        Me.btnComparaValoresAlfanumericos.Text = "&Compara Valores Alfanuméricos - Compares Alphanumeric Values"
        Me.btnComparaValoresAlfanumericos.UseVisualStyleBackColor = True
        '
        'lblValorA2
        '
        Me.lblValorA2.AutoSize = True
        Me.lblValorA2.Location = New System.Drawing.Point(3, 84)
        Me.lblValorA2.Name = "lblValorA2"
        Me.lblValorA2.Size = New System.Drawing.Size(50, 13)
        Me.lblValorA2.TabIndex = 16
        Me.lblValorA2.Text = "Valor A2:"
        '
        'lblValorA1
        '
        Me.lblValorA1.AutoSize = True
        Me.lblValorA1.Location = New System.Drawing.Point(3, 58)
        Me.lblValorA1.Name = "lblValorA1"
        Me.lblValorA1.Size = New System.Drawing.Size(50, 13)
        Me.lblValorA1.TabIndex = 15
        Me.lblValorA1.Text = "Valor A1:"
        '
        'txtValorA2
        '
        Me.txtValorA2.Location = New System.Drawing.Point(55, 81)
        Me.txtValorA2.Name = "txtValorA2"
        Me.txtValorA2.Size = New System.Drawing.Size(398, 20)
        Me.txtValorA2.TabIndex = 14
        Me.txtValorA2.Text = "Teste23"
        '
        'txtValorA1
        '
        Me.txtValorA1.Location = New System.Drawing.Point(55, 55)
        Me.txtValorA1.Name = "txtValorA1"
        Me.txtValorA1.Size = New System.Drawing.Size(398, 20)
        Me.txtValorA1.TabIndex = 13
        Me.txtValorA1.Text = "Teste199999"
        '
        'lblComparaValoresAlfanumericos
        '
        Me.lblComparaValoresAlfanumericos.Location = New System.Drawing.Point(3, 12)
        Me.lblComparaValoresAlfanumericos.Name = "lblComparaValoresAlfanumericos"
        Me.lblComparaValoresAlfanumericos.Size = New System.Drawing.Size(289, 29)
        Me.lblComparaValoresAlfanumericos.TabIndex = 12
        Me.lblComparaValoresAlfanumericos.Text = "Compara Qualquer Alfanumérico (Caracter por Caracter): Compare Any Alphanumeric (" &
    "Character by Character):"
        '
        'tabExemplo3
        '
        Me.tabExemplo3.Controls.Add(Me.btnCriaListaValoresNumerico)
        Me.tabExemplo3.Controls.Add(Me.btnCriaListaValoresAlfanumerico)
        Me.tabExemplo3.Controls.Add(Me.lblListaValoresAlfanumericos)
        Me.tabExemplo3.Controls.Add(Me.lvwListaValorAlfanumerico)
        Me.tabExemplo3.Controls.Add(Me.lblListaValoresNumericos)
        Me.tabExemplo3.Controls.Add(Me.lvwListaValorNumerico)
        Me.tabExemplo3.Controls.Add(Me.lblListaValorAlfanumerico)
        Me.tabExemplo3.Controls.Add(Me.lblListaValorNumerico)
        Me.tabExemplo3.Controls.Add(Me.txtListaValorAlfanumerico)
        Me.tabExemplo3.Controls.Add(Me.txtListaValorNumerico)
        Me.tabExemplo3.Controls.Add(Me.lblCriaLista)
        Me.tabExemplo3.Location = New System.Drawing.Point(4, 22)
        Me.tabExemplo3.Name = "tabExemplo3"
        Me.tabExemplo3.Size = New System.Drawing.Size(478, 323)
        Me.tabExemplo3.TabIndex = 2
        Me.tabExemplo3.Text = "Exemplo 3 - Sample 3"
        Me.tabExemplo3.UseVisualStyleBackColor = True
        '
        'btnCriaListaValoresNumerico
        '
        Me.btnCriaListaValoresNumerico.Location = New System.Drawing.Point(55, 292)
        Me.btnCriaListaValoresNumerico.Name = "btnCriaListaValoresNumerico"
        Me.btnCriaListaValoresNumerico.Size = New System.Drawing.Size(192, 23)
        Me.btnCriaListaValoresNumerico.TabIndex = 27
        Me.btnCriaListaValoresNumerico.Text = "&Cria Lista de Valores Numéricos"
        Me.btnCriaListaValoresNumerico.UseVisualStyleBackColor = True
        '
        'btnCriaListaValoresAlfanumerico
        '
        Me.btnCriaListaValoresAlfanumerico.Location = New System.Drawing.Point(261, 292)
        Me.btnCriaListaValoresAlfanumerico.Name = "btnCriaListaValoresAlfanumerico"
        Me.btnCriaListaValoresAlfanumerico.Size = New System.Drawing.Size(192, 23)
        Me.btnCriaListaValoresAlfanumerico.TabIndex = 26
        Me.btnCriaListaValoresAlfanumerico.Text = "&Cria Lista de Valores Alfanuméricos"
        Me.btnCriaListaValoresAlfanumerico.UseVisualStyleBackColor = True
        '
        'lblListaValoresAlfanumericos
        '
        Me.lblListaValoresAlfanumericos.AutoSize = True
        Me.lblListaValoresAlfanumericos.Location = New System.Drawing.Point(258, 103)
        Me.lblListaValoresAlfanumericos.Name = "lblListaValoresAlfanumericos"
        Me.lblListaValoresAlfanumericos.Size = New System.Drawing.Size(139, 13)
        Me.lblListaValoresAlfanumericos.TabIndex = 25
        Me.lblListaValoresAlfanumericos.Text = "Lista Valores Alfanuméricos:"
        '
        'lvwListaValorAlfanumerico
        '
        Me.lvwListaValorAlfanumerico.Location = New System.Drawing.Point(261, 119)
        Me.lvwListaValorAlfanumerico.Name = "lvwListaValorAlfanumerico"
        Me.lvwListaValorAlfanumerico.Size = New System.Drawing.Size(192, 167)
        Me.lvwListaValorAlfanumerico.TabIndex = 24
        Me.lvwListaValorAlfanumerico.UseCompatibleStateImageBehavior = False
        Me.lvwListaValorAlfanumerico.View = System.Windows.Forms.View.List
        '
        'lblListaValoresNumericos
        '
        Me.lblListaValoresNumericos.AutoSize = True
        Me.lblListaValoresNumericos.Location = New System.Drawing.Point(52, 103)
        Me.lblListaValoresNumericos.Name = "lblListaValoresNumericos"
        Me.lblListaValoresNumericos.Size = New System.Drawing.Size(123, 13)
        Me.lblListaValoresNumericos.TabIndex = 23
        Me.lblListaValoresNumericos.Text = "Lista Valores Numéricos:"
        '
        'lvwListaValorNumerico
        '
        Me.lvwListaValorNumerico.Location = New System.Drawing.Point(55, 119)
        Me.lvwListaValorNumerico.MultiSelect = False
        Me.lvwListaValorNumerico.Name = "lvwListaValorNumerico"
        Me.lvwListaValorNumerico.Size = New System.Drawing.Size(192, 167)
        Me.lvwListaValorNumerico.TabIndex = 22
        Me.lvwListaValorNumerico.UseCompatibleStateImageBehavior = False
        Me.lvwListaValorNumerico.View = System.Windows.Forms.View.List
        '
        'lblListaValorAlfanumerico
        '
        Me.lblListaValorAlfanumerico.AutoSize = True
        Me.lblListaValorAlfanumerico.Location = New System.Drawing.Point(3, 78)
        Me.lblListaValorAlfanumerico.Name = "lblListaValorAlfanumerico"
        Me.lblListaValorAlfanumerico.Size = New System.Drawing.Size(44, 13)
        Me.lblListaValorAlfanumerico.TabIndex = 21
        Me.lblListaValorAlfanumerico.Text = "Valor A:"
        '
        'lblListaValorNumerico
        '
        Me.lblListaValorNumerico.AutoSize = True
        Me.lblListaValorNumerico.Location = New System.Drawing.Point(3, 52)
        Me.lblListaValorNumerico.Name = "lblListaValorNumerico"
        Me.lblListaValorNumerico.Size = New System.Drawing.Size(45, 13)
        Me.lblListaValorNumerico.TabIndex = 20
        Me.lblListaValorNumerico.Text = "Valor N:"
        '
        'txtListaValorAlfanumerico
        '
        Me.txtListaValorAlfanumerico.Location = New System.Drawing.Point(55, 75)
        Me.txtListaValorAlfanumerico.Name = "txtListaValorAlfanumerico"
        Me.txtListaValorAlfanumerico.Size = New System.Drawing.Size(398, 20)
        Me.txtListaValorAlfanumerico.TabIndex = 19
        Me.txtListaValorAlfanumerico.Text = "Macoratti,Jefferson, Miriam ,Janice , ,   Tunusat , FoxMan, 42"
        '
        'txtListaValorNumerico
        '
        Me.txtListaValorNumerico.Location = New System.Drawing.Point(55, 49)
        Me.txtListaValorNumerico.Name = "txtListaValorNumerico"
        Me.txtListaValorNumerico.Size = New System.Drawing.Size(398, 20)
        Me.txtListaValorNumerico.TabIndex = 18
        Me.txtListaValorNumerico.Text = "1,2, 3 ,4 , , 6, 7,,, 8"
        '
        'lblCriaLista
        '
        Me.lblCriaLista.Location = New System.Drawing.Point(3, 9)
        Me.lblCriaLista.Name = "lblCriaLista"
        Me.lblCriaLista.Size = New System.Drawing.Size(436, 37)
        Me.lblCriaLista.TabIndex = 17
        Me.lblCriaLista.Text = "Cria Lista (coloque os valores separados por vírgula e não se preocupe com os esp" &
    "aços): - Create List (enter values separated by commas and do not worry about sp" &
    "aces):"
        '
        'frmMetodosGenericosVB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 373)
        Me.Controls.Add(Me.tabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMetodosGenericosVB"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Métodos Genéricos - 3 Exemplos - http://www.macoratti.net/15/04/vbn_mgen2.htm"
        Me.tabControl1.ResumeLayout(False)
        Me.tabExemplo1.ResumeLayout(False)
        Me.tabExemplo1.PerformLayout()
        Me.tabExemplo2.ResumeLayout(False)
        Me.tabExemplo2.PerformLayout()
        Me.tabExemplo3.ResumeLayout(False)
        Me.tabExemplo3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tabExemplo1 As System.Windows.Forms.TabPage
    Private WithEvents lblTexto2 As System.Windows.Forms.Label
    Private WithEvents lblTexto1 As System.Windows.Forms.Label
    Private WithEvents btnTrocaDeLugar As System.Windows.Forms.Button
    Private WithEvents txtTexto2 As System.Windows.Forms.TextBox
    Private WithEvents txtTexto1 As System.Windows.Forms.TextBox
    Private WithEvents lblTrocaDeLugar As System.Windows.Forms.Label
    Private WithEvents tabExemplo2 As System.Windows.Forms.TabPage
    Private WithEvents lblMaiorValorNumerico As System.Windows.Forms.Label
    Private WithEvents txtMaiorValorN As System.Windows.Forms.TextBox
    Private WithEvents btnComparaValoresNumericos As System.Windows.Forms.Button
    Private WithEvents lblValorN2 As System.Windows.Forms.Label
    Private WithEvents lblValorN1 As System.Windows.Forms.Label
    Private WithEvents txtValorN2 As System.Windows.Forms.TextBox
    Private WithEvents txtValorN1 As System.Windows.Forms.TextBox
    Private WithEvents lblComparaValoresNumericos As System.Windows.Forms.Label
    Private WithEvents lblMaiorValorAlfanumerico As System.Windows.Forms.Label
    Private WithEvents txtMaiorValorA As System.Windows.Forms.TextBox
    Private WithEvents btnComparaValoresAlfanumericos As System.Windows.Forms.Button
    Private WithEvents lblValorA2 As System.Windows.Forms.Label
    Private WithEvents lblValorA1 As System.Windows.Forms.Label
    Private WithEvents txtValorA2 As System.Windows.Forms.TextBox
    Private WithEvents txtValorA1 As System.Windows.Forms.TextBox
    Private WithEvents lblComparaValoresAlfanumericos As System.Windows.Forms.Label
    Private WithEvents tabExemplo3 As System.Windows.Forms.TabPage
    Private WithEvents btnCriaListaValoresNumerico As System.Windows.Forms.Button
    Private WithEvents btnCriaListaValoresAlfanumerico As System.Windows.Forms.Button
    Private WithEvents lblListaValoresAlfanumericos As System.Windows.Forms.Label
    Private WithEvents lvwListaValorAlfanumerico As System.Windows.Forms.ListView
    Private WithEvents lblListaValoresNumericos As System.Windows.Forms.Label
    Private WithEvents lvwListaValorNumerico As System.Windows.Forms.ListView
    Private WithEvents lblListaValorAlfanumerico As System.Windows.Forms.Label
    Private WithEvents lblListaValorNumerico As System.Windows.Forms.Label
    Private WithEvents txtListaValorAlfanumerico As System.Windows.Forms.TextBox
    Private WithEvents txtListaValorNumerico As System.Windows.Forms.TextBox
    Private WithEvents lblCriaLista As System.Windows.Forms.Label

End Class
