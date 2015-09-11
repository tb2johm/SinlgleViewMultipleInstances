using System.Windows.Controls;
using MMVVM.ViewModelBase;

namespace ListViewTryout.Views
{
    /// <summary>
    /// Interaction logic for PersonalView.xaml
    /// </summary>
    public partial class GenericGroupView : UserControl
    {
        private ViewModelBase _viewModel;

        public ViewModelBase ViewModel
        {
            get { return _viewModel; }
            set
            {
                _viewModel = value;
                this.MainGrid.DataContext = ViewModel;
            }
        }

        public GenericGroupView()
        {
            InitializeComponent();
        }
    }
}
