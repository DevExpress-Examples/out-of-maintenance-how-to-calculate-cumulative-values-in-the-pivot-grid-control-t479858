using System.Windows;
using DevExpress.Xpf.Editors;
using DevExpress.Xpf.PivotGrid;

namespace exWpfPivotRunningTotals
{
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ceRunningTotals_EditValueChanged(object sender, 
                    EditValueChangedEventArgs e) {
            UpdateBinding();
        }

        private void ceAllowCrossGroupRunningTotals_EditValueChanged(object sender, 
                    EditValueChangedEventArgs e) {
            UpdateBinding();
        }
        
        void UpdateBinding() {
            DataSourceColumnBinding sourceBinding = new DataSourceColumnBinding("Extended Price");
            if((bool)ceRunningTotals.IsChecked) {
                RunningTotalBinding runningBinding = new RunningTotalBinding();
                runningBinding.Source = sourceBinding;
                if((bool)ceAllowCrossGroupRunningTotals.IsChecked)
                    runningBinding.PartitioningCriteria = CalculationPartitioningCriteria.RowValue;
                else
                    runningBinding.PartitioningCriteria = CalculationPartitioningCriteria.RowValueAndColumnParentValue;
                fieldProductSales.DataBinding = runningBinding;
            }
            else {
                fieldProductSales.DataBinding = sourceBinding;
            }

        }
    }
}
