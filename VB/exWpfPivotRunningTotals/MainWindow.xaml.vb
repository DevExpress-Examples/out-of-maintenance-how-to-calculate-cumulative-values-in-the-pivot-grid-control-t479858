Imports System.Windows
Imports DevExpress.Xpf.Editors

Namespace exWpfPivotRunningTotals
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ceRunningTotals_EditValueChanged(ByVal sender As Object,
                                                     ByVal e As EditValueChangedEventArgs)
            fieldOrderQuarter.RunningTotal = CBool(ceRunningTotals.IsChecked)
        End Sub

        Private Sub ceAllowCrossGroupRunningTotals_EditValueChanged(ByVal sender As Object,
                                                    ByVal e As EditValueChangedEventArgs)
            pivot.AllowCrossGroupVariation = CBool(ceAllowCrossGroupRunningTotals.IsChecked)
        End Sub
    End Class
End Namespace
