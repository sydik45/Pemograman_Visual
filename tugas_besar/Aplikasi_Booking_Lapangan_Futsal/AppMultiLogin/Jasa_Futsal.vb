﻿Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Jasa_Futsal
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (futsal_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If

    End Sub

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim kdf As String = txtkdf.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim alamat As String = txtAlamat.Text
        Dim tanggal As String = txtTgl.Text
        Dim pukul As String = txtpukul.Text
        Dim jam_main As String = Txtjam.Text
        Dim jenis_lapangan As String = Txtjnl.Text
        Dim harga As String = Txtharga.Text
        Dim total_harga As String = Txttotal.Text

        Dim postData As String = $"kdf={kdf}&nama={nama}&jk={jk}&alamat={alamat}&tanggal={tanggal}&pukul={pukul}&jam_main={jam_main}
        &jenis_lapangan={jenis_lapangan}&harga={harga}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(futsal_api, "POST", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub UpdateData()

        ' Set the data you want to send as key-value pairs
        Dim kdf As String = txtkdf.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim alamat As String = txtAlamat.Text
        Dim tanggal As String = txtTgl.Text
        Dim pukul As String = txtpukul.Text
        Dim jam_main As String = Txtjam.Text
        Dim jenis_lapangan As String = Txtjnl.Text
        Dim harga As String = Txtharga.Text
        Dim total_harga As String = Txttotal.Text

        Dim postData As String = $"kdf={kdf}&nama={nama}&jk={jk}&alamat={alamat}&tanggal={tanggal}&pukul={pukul}&jam_main={jam_main}
        &jenis_lapangan={jenis_lapangan}&harga={harga}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(futsal_api & "?kdf=" & txtkdf.Text, "PUT", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub DeleteData()

        ' Set the data you want to send as key-value pairs
        Dim kdf As String = txtkdf.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim alamat As String = txtAlamat.Text
        Dim tanggal As String = txtTgl.Text
        Dim pukul As String = txtpukul.Text
        Dim jam_main As String = Txtjam.Text
        Dim jenis_lapangan As String = Txtjnl.Text
        Dim harga As String = Txtharga.Text
        Dim total_harga As String = Txttotal.Text

        Dim postData As String = $"kdf={kdf}&nama={nama}&jk={jk}&alamat={alamat}&tanggal={tanggal}&pukul={pukul}&jam_main={jam_main}
        &jenis_lapangan={jenis_lapangan}&harga={harga}&total_harga={total_harga}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(futsal_api & "?kdf=" & txtkdf.Text, "DELETE", byteArray)

            ' Convert the response bytes to a string
            Dim responseBody As String = Encoding.ASCII.GetString(responseBytes)

            ' Display the response
            MessageBox.Show(responseBody, "Response")
        Catch ex As Exception
            ' Handle any errors that occur during the request
            MessageBox.Show("An error occurred: " & ex.Message, "Error")
        End Try
        GetClear()
    End Sub

    Private Sub GetData()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(futsal_api & "?kdf=" & txtkdf.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        futsal_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        futsal_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (futsal_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Futsal) = JsonConvert.DeserializeObject(Of List(Of Futsal))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Futsal In data
                            txtkdf.Text = mydata.kdf
                            txtNama.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtAlamat.Text = mydata.alamat
                            txtTgl.Text = mydata.tanggal
                            txtpukul.Text = mydata.pukul
                            Txtjam.Text = mydata.jam_main
                            Txtjnl.Text = mydata.jenis_lapangan
                            Txtharga.Text = mydata.harga
                            Txttotal.Text = mydata.total_harga
                        Next
                    End If

                End Try




            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub


    Private Sub txtkdf_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkdf.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub GetData2()
        Using client As New HttpClient()
            ' Send a GET request to the API endpoint
            Dim response As HttpResponseMessage = client.GetAsync(lapangan_api & "?kode_lapangan=" & txtkdl.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        lapangan_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        lapangan_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (lapangan_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Lapangan) = JsonConvert.DeserializeObject(Of List(Of Lapangan))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Lapangan In data
                            txtkdl.Text = mydata.kode_lapangan
                            Txtjnl.Text = mydata.jenis_lapangan
                            Txtharga.Text = mydata.harga
                        Next
                    End If

                End Try




            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub txtkdl_KeyDown(sender As Object, e As KeyEventArgs) Handles txtkdl.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData2()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(futsal_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Futsal) = JsonConvert.DeserializeObject(Of List(Of Futsal))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub GetClear()
        txtkdf.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtAlamat.Clear()
        txtTgl.Clear()
        txtpukul.Clear()
        Txtjam.Clear()
        txtkdl.Clear()
        Txtjnl.Clear()
        Txtharga.Clear()
        Txttotal.Clear()
        Reloaded()
        txtkdf.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If (futsal_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If


        End If
    End Sub
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        Dim jam As Integer
        Dim harga As Integer
        Dim total As Integer

        Integer.TryParse(Txtjam.Text, jam)
        Integer.TryParse(Txtharga.Text, harga)

        total = jam * harga

        Txttotal.Text = total.ToString()
    End Sub

End Class