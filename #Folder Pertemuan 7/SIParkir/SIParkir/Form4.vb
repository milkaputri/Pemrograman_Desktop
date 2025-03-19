Imports MySql.Data.MySqlClient
Public Class frmLangganan
    Private Sub RefreshGrid()
        Dim i
        i = 0
        DataGridView1.Rows.Clear()
        Dim sql As String = "select * from tbllangganan"

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If
        myDataReader = myCommand.ExecuteReader
        If myDataReader.HasRows Then
            While myDataReader.Read()
                DataGridView1.Rows.Add()
                DataGridView1.Item(0, i).Value = myDataReader("id")
                DataGridView1.Item(1, i).Value = myDataReader("no_plat")
                DataGridView1.Item(2, i).Value = myDataReader("nama")
                DataGridView1.Item(3, i).Value = myDataReader("biaya")
                DataGridView1.Item(4, i).Value = myDataReader("jenis")
                DataGridView1.Item(5, i).Value = myDataReader("expired")
                i = i + 1
            End While
        End If
        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub frmLangganan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RefreshGrid()
    End Sub

    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim idx As String = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        Dim sql As String = "select * from tbllangganan where id=" & idx

        If myConn.State = ConnectionState.Closed Then
            myConn.Open()
        End If

        If myCommand Is Nothing Then
            myCommand = New MySqlCommand(sql, myConn)
        Else
            myCommand.CommandText = sql
        End If

        myDataReader = myCommand.ExecuteReader

        If myDataReader.HasRows Then
            While myDataReader.Read()
                lblId.Text = myDataReader("id")
                txtNomorPlat.Text = myDataReader("no_plat")
                txtNamaPelanggan.Text = myDataReader("nama")
                txtTarifLangganan.Text = myDataReader("biaya")
                cmbJenis.Text = myDataReader("jenis")
                DateTimePicker1.Text = myDataReader("expired")
            End While
        End If

        If myDataReader.IsClosed = False Then
            myDataReader.Close()
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            txtNomorPlat.Enabled = True
            txtNamaPelanggan.Enabled = True
            txtTarifLangganan.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnEdit.Enabled = False
            btnHapus.Enabled = False
            txtNomorPlat.Clear()
            txtNamaPelanggan.Clear()
            txtTarifLangganan.Clear()
            cmbJenis.Text = ""
        ElseIf btnTambah.Text = "Simpan" Then
            Dim hasil As DateTime = DateTimePicker1.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & "16:00:00"
            Dim sql As String = "insert into tbllangganan(no_plat,nama,jenis,biaya,expired) values ('" & txtNomorPlat.Text & "','" & txtNamaPelanggan.Text & "','" & cmbJenis.Text & "'," & txtTarifLangganan.Text & ",'" & waktu & "')"

            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            myCommand.ExecuteNonQuery()
            btnTambah.Text = "Tambah"
            txtNomorPlat.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
            RefreshGrid()
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If DataGridView1.CurrentRow.Cells(0).Value.ToString <> "" Then
            If MessageBox.Show("Delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes Then
                Dim sql As String = "delete from tbllangganan where id=" & DataGridView1.CurrentRow.Cells(0).Value.ToString
                MsgBox(sql)
                If myConn.State = ConnectionState.Closed Then
                    myConn.Open()
                End If

                If myCommand Is Nothing Then
                    myCommand = New MySqlCommand(sql, myConn)
                Else
                    myCommand.CommandText = sql
                End If

                Dim hasil As Integer = myCommand.ExecuteNonQuery
                If hasil = 1 Then
                    MsgBox("Delete success!")
                    RefreshGrid()
                End If
            Else
            End If
        End If
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        If btnEdit.Text = "Edit" Then
            btnEdit.Text = "Simpan"
            txtNomorPlat.Enabled = True
            txtNamaPelanggan.Enabled = True
            txtTarifLangganan.Enabled = True
            cmbJenis.Enabled = True
            DateTimePicker1.Enabled = True
            btnCancel.Visible = True
            btnTambah.Enabled = False
            btnHapus.Enabled = False
        ElseIf btnEdit.Text = "Simpan" Then
            Dim hasil As DateTime = DateTimePicker1.Value
            Dim waktu As String = hasil.Year & "-" & hasil.Month & "-" & hasil.Day & "00:00:00"
            Dim sql As String = "update tbllangganan set no_plat = '" & txtNomorPlat.Text & "',nama = '" & txtNamaPelanggan.Text & "',jenis = '" & cmbJenis.Text & "',biaya = '" & txtTarifLangganan.Text & "',expired = '" & waktu & "' where id = " & lblId.Text
            MsgBox(sql)
            If myConn.State = ConnectionState.Closed Then
                myConn.Open()
            End If

            If myCommand Is Nothing Then
                myCommand = New MySqlCommand(sql, myConn)
            Else
                myCommand.CommandText = sql
            End If

            Dim hsl As Integer = myCommand.ExecuteNonQuery
            If hsl = 1 Then
                MsgBox("Update success!")
                RefreshGrid()
            End If
            btnEdit.Text = "Edit"
            txtNomorPlat.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If btnTambah.Text = "Simpan" Then
            btnTambah.Text = "Tambah"
            txtNomorPlat.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnEdit.Enabled = True
            btnHapus.Enabled = True
        ElseIf btnEdit.Text = "Simpan" Then
            btnEdit.Text = "Edit"
            txtNomorPlat.Enabled = False
            txtNamaPelanggan.Enabled = False
            txtTarifLangganan.Enabled = False
            cmbJenis.Enabled = False
            DateTimePicker1.Enabled = False
            btnCancel.Visible = False
            btnTambah.Enabled = True
            btnHapus.Enabled = True
        End If
    End Sub
End Class