Imports System.Windows
Imports DevExpress.Xpf.Editors
Imports DevExpress.Xpf.PivotGrid

Namespace exWpfPivotRunningTotals
    Partial Public Class MainWindow
        Inherits Window

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub ceRunningTotals_EditValueChanged(ByVal sender As Object,
                                                     ByVal e As EditValueChangedEventArgs)
            UpdateBinding()
        End Sub

        Private Sub ceAllowCrossGroupRunningTotals_EditValueChanged(ByVal sender As Object,
                                                    ByVal e As EditValueChangedEventArgs)
            UpdateBinding()
        End Sub

        Private Sub UpdateBinding()
            Dim sourceBinding As New DataSourceColumnBinding("Extended Price")
            If CBool(ceRunningTotals.IsChecked) Then
                Dim runningBinding As New RunningTotalBinding()
                runningBinding.Source = sourceBinding
                If CBool(ceAllowCrossGroupRunningTotals.IsChecked) Then
                    runningBinding.PartitioningCriteria = CalculationPartitioningCriteria.RowValue
                Else
                    runningBinding.PartitioningCriteria = CalculationPartitioningCriteria.RowValueAndColumnParentValue
                End If
                fieldProductSales.DataBinding = runningBinding
            Else
                fieldProductSales.DataBinding = sourceBinding
            End If

        End Sub

    End Class
End Namespace
