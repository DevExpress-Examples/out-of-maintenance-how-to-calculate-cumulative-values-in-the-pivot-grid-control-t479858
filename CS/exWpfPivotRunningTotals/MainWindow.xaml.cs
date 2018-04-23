using System.Windows;
using DevExpress.Xpf.Editors;

namespace exWpfPivotRunningTotals
{
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void ceRunningTotals_EditValueChanged(object sender, 
                    EditValueChangedEventArgs e) {
            fieldOrderQuarter.RunningTotal = (bool)ceRunningTotals.IsChecked;
        }

        private void ceAllowCrossGroupRunningTotals_EditValueChanged(object sender, 
                    EditValueChangedEventArgs e) {
            pivot.AllowCrossGroupVariation = (bool)ceAllowCrossGroupRunningTotals.IsChecked;
        }
    }
}
