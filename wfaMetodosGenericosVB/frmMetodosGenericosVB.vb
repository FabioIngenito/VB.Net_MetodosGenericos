Public Class frmMetodosGenericosVB
    'Classe de Métodos Genéricos
    Dim clsMetGen As New clsMetodosGenericosVB

#Region "Trocar Valores de Lugar - Swap Place Values"

    Private Sub btnTrocaDeLugar_Click(sender As Object, e As EventArgs) Handles btnTrocaDeLugar.Click
        Dim strTexto1 As String = txtTexto1.Text
        Dim strTexto2 As String = txtTexto2.Text

        clsMetGen.Trocar(Of String)(strTexto1, strTexto2)

        txtTexto1.Text = strTexto1
        txtTexto2.Text = strTexto2
    End Sub

#End Region

#Region "Compara Qualquer - Compare Any"

    Private Sub btnComparaValoresAlfanumericos_Click(sender As Object, e As EventArgs) Handles btnComparaValoresAlfanumericos.Click
        Dim strValorA1 As String = txtValorA1.Text
        Dim strValorA2 As String = txtValorA2.Text

        txtMaiorValorA.Text = clsMetGen.Maximo(Of String)(strValorA1, strValorA2)
    End Sub

    Private Sub btnComparaValoresNumericos_Click(sender As Object, e As EventArgs) Handles btnComparaValoresNumericos.Click
        Dim lngValorN1 As Long = Convert.ToDouble(txtValorN1.Text)
        Dim lngValorN2 As Long = Convert.ToDouble(txtValorN2.Text)

        txtMaiorValorN.Text = Convert.ToString(clsMetGen.Maximo(Of Long)(lngValorN1, lngValorN2))
    End Sub

    ''' <summary>
    ''' Só permite números - Only allows numbers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks>VEJA AQUI o "HANDLES" (atua em cima dos dois campos: "txtValorN1" e "txtValorN2"</remarks>
    Private Sub txtValorN1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtValorN1.KeyPress, txtValorN2.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back Then e.Handled = True
    End Sub

#End Region

#Region "Cria Lista - Create List"
    Private Sub txtListaValorNumerico_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtListaValorNumerico.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not Convert.ToInt32(e.KeyChar) = Keys.Back AndAlso Convert.ToInt32(e.KeyChar) <> Keys.Space AndAlso Convert.ToInt32(e.KeyChar) <> 44 Then e.Handled = True
    End Sub

    ''' <summary>
    ''' Botão para Criar uma lista de valores.
    ''' Existe também um método do "Array" chamado "Copy" (Array.Copy), é outra forma de fazer.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCriaListaValoresNumerico_Click(sender As Object, e As EventArgs) Handles btnCriaListaValoresNumerico.Click
        Dim strListaValorNumerico As String = txtListaValorNumerico.Text
        Dim arrstrListaValorNumerico As String() = strListaValorNumerico.Split(","c)
        Dim arrIntListaValorNumerico As Integer() = New Integer() {}
        Dim intTamanho As Integer = arrstrListaValorNumerico.GetLength(0)
        Dim i As Integer = 0
        Dim strNumeros As List(Of String) = clsMetGen.CriaLista(Of String)(arrstrListaValorNumerico)

        Array.Resize(arrIntListaValorNumerico, intTamanho)

        For Each strNumero As String In strNumeros
            If strNumero.Trim() <> "" Then
                arrIntListaValorNumerico(i) = Convert.ToInt32(strNumero.Trim())
            End If

            i += 1
        Next

        'Dim numeros As List(Of Integer) = clsMetGen.CriaLista(Of Integer)(1, 2, 3, 4, 6, 7)
        Dim numeros As List(Of Integer) = clsMetGen.CriaLista(Of Integer)(arrIntListaValorNumerico)

        lvwListaValorNumerico.Items.Clear()

        For Each numero As Integer In numeros
            lvwListaValorNumerico.Items.Add(Convert.ToString(numero).Trim())
        Next

    End Sub

    Private Sub btnCriaListaValoresAlfanumerico_Click(sender As Object, e As EventArgs) Handles btnCriaListaValoresAlfanumerico.Click

        Dim strListaValorAlfanumerico As String = txtListaValorAlfanumerico.Text
        Dim arrstrListaValorAlfanumerico As String() = strListaValorAlfanumerico.Split(","c)

        Dim nomes As List(Of String) = clsMetGen.CriaLista(Of String)(arrstrListaValorAlfanumerico)

        lvwListaValorAlfanumerico.Items.Clear()

        For Each nome As String In nomes
            lvwListaValorAlfanumerico.Items.Add(nome.Trim())
        Next

    End Sub

#End Region

End Class
