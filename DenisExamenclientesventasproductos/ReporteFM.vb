Imports ClosedXML.Excel
Imports MySql.Data.MySqlClient

Public Class ReporteFM
    Private connectionString As String = "Server=localhost;Database=pruebademo;Uid=root;Password=dennis;"

    ' Método para generar el reporte de ventas
    Private Sub GenerarReporteVentas()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT v.ID, c.Cliente, v.Fecha, v.Total " &
                                  "FROM ventas v " &
                                  "INNER JOIN clientes c ON v.IDCliente = c.ID"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Crear un archivo Excel
                    Dim workbook = New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Ventas")

                    ' Agregar los datos al archivo Excel
                    worksheet.Cell(1, 1).Value = "ID"
                    worksheet.Cell(1, 2).Value = "Cliente"
                    worksheet.Cell(1, 3).Value = "Fecha"
                    worksheet.Cell(1, 4).Value = "Total"

                    For i As Integer = 0 To table.Rows.Count - 1
                        worksheet.Cell(i + 2, 1).Value = table.Rows(i)("ID").ToString()
                        worksheet.Cell(i + 2, 2).Value = table.Rows(i)("Cliente").ToString()
                        worksheet.Cell(i + 2, 3).Value = Convert.ToDateTime(table.Rows(i)("Fecha")).ToString("dd/MM/yyyy")
                        worksheet.Cell(i + 2, 4).Value = Convert.ToDecimal(table.Rows(i)("Total")).ToString("C")
                    Next

                    ' Guardar el archivo Excel
                    Dim saveFileDialog As New SaveFileDialog()
                    saveFileDialog.Filter = "Excel Files|*.xlsx"
                    saveFileDialog.Title = "Guardar Reporte de Ventas"
                    saveFileDialog.FileName = "Reporte_Ventas.xlsx"

                    If saveFileDialog.ShowDialog() = DialogResult.OK Then
                        workbook.SaveAs(saveFileDialog.FileName)
                        MessageBox.Show("Reporte de ventas generado correctamente.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Método para generar el reporte de productos
    Private Sub GenerarReporteProductos()
        Using conn As New MySqlConnection(connectionString)
            conn.Open()
            Dim query As String = "SELECT ID, Nombre, Precio, Categoria FROM productos"
            Using cmd As New MySqlCommand(query, conn)
                Using adapter As New MySqlDataAdapter(cmd)
                    Dim table As New DataTable()
                    adapter.Fill(table)

                    ' Crear un archivo Excel
                    Dim workbook = New XLWorkbook()
                    Dim worksheet = workbook.Worksheets.Add("Productos")

                    ' Agregar los datos al archivo Excel
                    worksheet.Cell(1, 1).Value = "ID"
                    worksheet.Cell(1, 2).Value = "Nombre"
                    worksheet.Cell(1, 3).Value = "Precio"
                    worksheet.Cell(1, 4).Value = "Categoría"

                    For i As Integer = 0 To table.Rows.Count - 1
                        worksheet.Cell(i + 2, 1).Value = table.Rows(i)("ID").ToString()
                        worksheet.Cell(i + 2, 2).Value = table.Rows(i)("Nombre").ToString()
                        worksheet.Cell(i + 2, 3).Value = Convert.ToDecimal(table.Rows(i)("Precio")).ToString("C")
                        worksheet.Cell(i + 2, 4).Value = table.Rows(i)("Categoria").ToString()
                    Next

                    ' Guardar el archivo Excel
                    Dim saveFileDialog As New SaveFileDialog()
                    saveFileDialog.Filter = "Excel Files|*.xlsx"
                    saveFileDialog.Title = "Guardar Reporte de Productos"
                    saveFileDialog.FileName = "Reporte_Productos.xlsx"

                    If saveFileDialog.ShowDialog() = DialogResult.OK Then
                        workbook.SaveAs(saveFileDialog.FileName)
                        MessageBox.Show("Reporte de productos generado correctamente.")
                    End If
                End Using
            End Using
        End Using
    End Sub

    ' Evento del botón para generar el reporte de ventas
    Private Sub ButtonGenerarReporteVentas_Click(sender As Object, e As EventArgs) Handles ButtonGenerarReporteVentas.Click
        GenerarReporteVentas()
    End Sub

    ' Evento del botón para generar el reporte de productos
    Private Sub ButtonGenerarReporteProductos_Click(sender As Object, e As EventArgs) Handles ButtonGenerarReporteProductos.Click
        GenerarReporteProductos()
    End Sub
End Class