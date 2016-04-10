Imports System.Runtime.InteropServices

Public Class Aero
    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS

        Public Destra As Integer
        Public Sinistra As Integer
        Public Su As Integer
        Public Giu As Integer

    End Structure
    Declare Auto Function DwmIsCompositionEnabled Lib "dwmapi.dll" Alias "DwmIsCompositionEnabled" (ByRef pfEnabled As Boolean) As Integer
    Declare Auto Function DwmExtendFrameIntoClientArea Lib "dwmapi.dll" Alias "DwmExtendFrameIntoClientArea" (ByVal hWnd As IntPtr, ByRef pMargin As MARGINS) As Integer
    Shared pMargins As New MARGINS With {.Su = -1, .Sinistra = -1, .Destra = -1, .Giu = -1}
    Shared Sub Init(ByVal e)
        Dim en As Boolean = False
        DwmIsCompositionEnabled(en)
        If en Then
            DwmExtendFrameIntoClientArea(e.Handle, pMargins)
        End If
        If en = False Then
            MsgBox("Running in failsafe graphics.")
        End If
        e.TransparencyKey = Color.FromKnownColor(KnownColor.ActiveCaption)
        e.BackColor = e.TransparencyKey
    End Sub
End Class
