Imports System.IO
Imports IBatisNet.DataMapper
Imports log4net.Config

Public Class Form1
    ' Loadイベント・ハンドラ 
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        XmlConfigurator.ConfigureAndWatch(New FileInfo(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "log4net.config"))

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim empSearchBean As EmpSearchBean = New EmpSearchBean()
        If (TextBoxEmpNo.Text <> "") Then
            empSearchBean.empNo = TextBoxEmpNo.Text
        End If

        If (TextBoxEmpName.Text <> "") Then
            empSearchBean.empName = TextBoxEmpName.Text
        End If


        Dim List As List(Of EmpDto) = Mapper.Instance.QueryForList(Of EmpDto)("searchEmp", empSearchBean)

        DataGridView1.Rows.Clear()

        For Each emp As EmpDto In list
            With emp
                DataGridView1.Rows.Add(.empNo.ToString(), .empName.ToString())
            End With
        Next

    End Sub

End Class
