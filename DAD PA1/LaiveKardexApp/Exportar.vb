Imports Microsoft.Office.Interop.Excel
Imports Microsoft.Office.Interop
Module Exportar
    Function ExportarExcel(ByVal ElGrid As DataGridView) As Boolean

        Dim exApp As New Application
        Dim exLibro As Workbook
        Dim exHoja As New Worksheet

        Try

            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()

            Dim Ncol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount

            For i As Integer = 1 To Ncol

                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).HeaderText.ToString

            Next

            For Fila As Integer = 0 To NRow - 1

                For Col As Integer = 0 To Ncol - 1

                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Item(Col, Fila).Value

                Next

            Next

            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            exApp.Application.Visible = True
            'exHoja = Nothing
            'exLibro = Nothing
            'exApp = Nothing

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar el excel")

            Return False

        End Try

        Return True

    End Function
End Module
