Module MyMod
    Public api_folder As String = "lap_futsal"
    Public users_api As String = "http://f0833852.xsph.ru/" & api_folder & "/users_api.php"
    Public futsal_api As String = "http://f0833852.xsph.ru/" & api_folder & "/futsal_api.php"
    Public lapangan_api As String = "http://f0833852.xsph.ru/" & api_folder & "/lapangan_api.php"
    Public Dashboard As New Form1
    Public Admin1Form As New Futsal
    Public Admin2Form As New Lapangan
    Public Dosen1Form As New Pemilik
    Public Dosen2Form As New Pemilik2
    Public LoginForm As New Form1
    Public admin_role As Boolean = False
    Public pemilik_role As Boolean = False
    Public login_valid As Boolean = False
    Public lapangan_baru As Boolean
    Public futsal_baru As Boolean

End Module
