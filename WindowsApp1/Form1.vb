Imports System.Threading

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fecha()
        lbl_cliente.Text = ""





    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Timer1.Start()
    End Sub

    Private Sub fecha()
        lbl_hora.Text = String.Format("{0:HH:mm:ss}", DateTime.Now)
        Dim meses = DateTime.Now.ToString("MM")
        Dim diaSemana = Format(Now, "dddd")
        Dim diaMes = Format(Now, "dd")
        Dim mes = Thread.CurrentThread.CurrentCulture.DateTimeFormat.MonthNames(meses - 1)
        Dim año = Format(Now, "yyyy")
        lbl_fecha.Text = diaSemana + ", " + diaMes + " de " + mes + " del " + año
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id = txt_id.Text
        Dim buscar As New conexiones
        Dim nombre = buscar.BuscarCliente(id)
        If nombre = "" Then
            MessageBox.Show("No existe cliente con ese número, favor de buscar de nuevo", "Cliente no encontrado",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk)
            lbl_cliente.Text = nombre
        Else
            lbl_cliente.Text = nombre
        End If
    End Sub
End Class
