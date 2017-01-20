''' <summary>
''' Macoratti .Net
''' Apresentando e usando Métodos Genéricos (VB.NET) - II
''' Introducing and Using Generic Methods (VB.NET) - II
''' http://www.macoratti.net/15/04/vbn_mgen2.htm
''' </summary>
''' <remarks></remarks>
Public Class clsMetodosGenericosVB

    ''' <summary>
    '''  Troca de Lugar os dois texto recebidos
    ''' Change of Place the two texts received
    ''' </summary>
    ''' <typeparam name="T">Tipo de variável - Variable Type</typeparam>
    ''' <param name="lhs">Texto recebido 1 - Received Text 1</param>
    ''' <param name="rhs">Texto recebido 2 - Received Text 2</param>
    Public Sub Trocar(Of T)(ByRef lhs As T, ByRef rhs As T)
        Dim temp As T

        temp = lhs
        lhs = rhs
        rhs = temp
    End Sub

    ''' <summary>
    ''' No código abaixo temos que o método Trocar agora é definido como sendo restrito a estruturas (ou tipos de valor). 
    ''' </summary>
    ''' <typeparam name="T">Tipo de variável - Variable Type</typeparam>
    ''' <param name="a">Texto recebido 1 - Received Text 1</param>
    ''' <param name="b">Texto recebido 2 - Received Text 2</param>
    ''' <remarks>Esta Sub não tem no C# - This Sub does not have in C#</remarks>
    Public Sub Trocar2(Of T As Structure)(ByRef a As T, ByRef b As T)
        Dim temp As T

        temp = a
        a = b
        b = temp
    End Sub

    ''' <summary>
    ''' Compara dois valores recebidos e retorna o maior.
    ''' Compares two received values and returns the largest.
    ''' </summary>
    ''' <typeparam name="T">Tipo de variável - Variable Type</typeparam>
    ''' <param name="valor1">Valor recebido 1 - Received Text 1</param>
    ''' <param name="valor2">Valor recebido 2 - Received Text 2</param>
    ''' <returns>O maior valor é retornado aqui</returns>
    Public Function Maximo(Of T As IComparable)(valor1 As T, valor2 As T) As T

        If valor1.CompareTo(valor2) > 0 Then Return valor1
        Return valor2

    End Function

    ''' <summary>
    ''' Cria uma lista a partir dos valores recebidos
    ''' Creates a list from received values
    ''' </summary>
    ''' <typeparam name="T">Tipo de variável - Variable Type</typeparam>
    ''' <param name="pars">Lista de parâmetros separada por vírgula</param>
    ''' <returns>A lista é devolvida aqui - The list is returned here</returns>
    Public Function CriaLista(Of T)(ParamArray pars As T()) As List(Of T)
        Dim lista As New List(Of T)()

        For Each elem As T In pars
            lista.Add(elem)
        Next

        Return lista
    End Function

End Class
