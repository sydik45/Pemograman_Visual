﻿Imports System.Net
Imports System.Text
Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (pasien_baru = True) Then
            TambahData()
        Else
            UpdateData()
        End If

    End Sub

    Private Sub TambahData()

        ' Set the data you want to send as key-value pairs
        Dim nrp As String = txtNRP.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTgl_lahir.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the POST request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api, "POST", byteArray)

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
        Dim nrp As String = txtNRP.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTgl_lahir.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtNRP.Text, "PUT", byteArray)

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
        Dim nrp As String = txtNRP.Text
        Dim nama As String = txtNama.Text
        Dim jk As String = txtJK.Text
        Dim tgl_lahir As String = txtTgl_lahir.Text
        Dim alamat As String = txtAlamat.Text
        Dim kota As String = txtKota.Text

        Dim postData As String = $"nrp={nrp}&nama={nama}&jk={jk}&tgl_lahir={tgl_lahir}&alamat={alamat}&kota={kota}"

        ' Create a new WebClient instance
        Dim client As New WebClient()

        ' Set the content type header
        client.Headers.Add("Content-Type", "application/x-www-form-urlencoded")

        Try
            ' Encode the data as a byte array
            Dim byteArray As Byte() = Encoding.ASCII.GetBytes(postData)

            ' Send the PUT request and get the response
            Dim responseBytes As Byte() = client.UploadData(pasien_api & "?nrp=" & txtNRP.Text, "DELETE", byteArray)

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
            Dim response As HttpResponseMessage = client.GetAsync(pasien_api & "?nrp=" & txtNRP.Text).Result

            ' Check if the request was successful
            If response.IsSuccessStatusCode Then
                ' Read the response content as a string
                Dim jsonString As String = response.Content.ReadAsStringAsync().Result
                Try
                    If (jsonString = "[]") Then
                        pasien_baru = True
                        MessageBox.Show("Data Not Found")
                        Exit Sub
                    Else
                        pasien_baru = False
                        Exit Sub
                    End If
                Catch ex As Exception

                Finally
                    If (pasien_baru = False) Then
                        ' Deserialize the JSON into objects
                        Dim data As List(Of Pasien) = JsonConvert.DeserializeObject(Of List(Of Pasien))(jsonString)

                        ' Create textboxes dynamically and set their values
                        For Each mydata As Pasien In data
                            txtNRP.Text = mydata.nrp
                            txtNama.Text = mydata.nama
                            txtJK.Text = mydata.jk
                            txtTgl_lahir.Text = mydata.tgl_lahir
                            txtAlamat.Text = mydata.alamat
                            txtKota.Text = mydata.kota

                        Next
                    End If

                End Try




            Else
                ' Request failed, handle the error
                MessageBox.Show($"Error: {response.StatusCode} - {response.ReasonPhrase}")

            End If
        End Using
    End Sub

    Private Sub txtNIM_KeyDown(sender As Object, e As KeyEventArgs) Handles txtNRP.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            GetData()
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Reloaded()
    End Sub

    Private Sub Reloaded()

        ' Create a WebClient instance to make the HTTP request
        Dim client As New WebClient()

        ' Make the GET request and retrieve the response
        Dim response As String = client.DownloadString(pasien_api)

        ' Deserialize the JSON response into a list of objects
        Dim data As List(Of Pasien) = JsonConvert.DeserializeObject(Of List(Of Pasien))(response)

        ' Bind the data to the DataGridView
        dgvData.DataSource = data
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        GetClear()
    End Sub

    Private Sub GetClear()
        txtNRP.Clear()
        txtNama.Clear()
        txtJK.Clear()
        txtTgl_lahir.Clear()
        txtAlamat.Clear()
        txtKota.Clear()
        Reloaded()
        txtNRP.Focus()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If (pasien_baru = False) Then
            Dim result As DialogResult = MessageBox.Show("Apakah data akan dihapus?", "Confirmation", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                DeleteData()
            Else
                MessageBox.Show("Data batal dihapus.")
            End If


        End If
    End Sub
End Class