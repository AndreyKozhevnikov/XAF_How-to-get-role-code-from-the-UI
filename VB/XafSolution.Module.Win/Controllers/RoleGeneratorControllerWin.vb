﻿Imports System
Imports System.Collections.Generic
Imports System.Configuration
Imports System.IO
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports XafSolution.Module.Controllers

Namespace XafSolution.Module.Win.Controllers
    Public Class RoleGeneratorControllerWin
        Inherits RoleGeneratorController

        Protected Overrides Sub SaveFile(ByVal updaterCode As String)
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "vb|*.vb"
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                Using file As New StreamWriter(saveFileDialog.FileName, False)
                    file.Write(updaterCode)
                End Using
            End If
        End Sub
    End Class
End Namespace
