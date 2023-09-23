Imports System.Windows.Forms
Imports Word = Microsoft.Office.Interop.Word
Imports Excel = Microsoft.Office.Interop.Excel
Public Class Form1

    Private Sub btnGuardarWord_Click(sender As Object, e As EventArgs) Handles bttnGuardarWord.Click
        Dim dialogo As SaveFileDialog = New SaveFileDialog()

        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim ruta As String = dialogo.FileName
        Dim wordApp = New Word.Application()
        wordApp.Visible = True
        wordApp.Documents.Add()
        Dim dato As String = TextBox1.Text
        wordApp.Selection.TypeText(dato)
        wordApp.ActiveDocument.SaveAs2(ruta)
    End Sub

    Private Sub BtnGuardarExcel_Click(sender As Object, e As EventArgs) Handles bttnGuardarExcel.Click

        Dim dialogo As SaveFileDialog = New SaveFileDialog()
        If dialogo.ShowDialog() <> DialogResult.OK Then
            Return
        End If

        Dim dato As String = TextBox1.Text
        Dim ruta As String = dialogo.FileName
        Dim excelApp = New Excel.Application()
        excelApp.Visible = True
        excelApp.Workbooks.Add()
        Dim workSheet As Excel._Worksheet = CType(excelApp.ActiveSheet, Excel.Worksheet)
        workSheet.Cells(1, "A") = dato
        workSheet.Columns(1).AutoFit()
        workSheet.SaveAs(ruta)

    End Sub
End Class
