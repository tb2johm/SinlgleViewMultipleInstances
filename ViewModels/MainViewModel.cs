using MMVVM.ViewModelBase;

namespace Groups.ViewModels
{
    class MainViewModel : ViewModelBase
    {
        public MainViewModel()
        {
            MusicGroupViewModel = new MusicGroupViewModel();
            AnimalGroupViewModel = new AnimalGroupViewModel();
        }


        private ViewModelBase _musicGroupViewModel;
        public ViewModelBase MusicGroupViewModel
        {
            get { return _musicGroupViewModel; }
            private set
            {
                if (value != _musicGroupViewModel)
                {
                    _musicGroupViewModel = value;
                    Notify("MusicGroupViewModel");
                }
            }
        }

        private ViewModelBase _animalGroupViewModel;
        public ViewModelBase AnimalGroupViewModel
        {
            get { return _animalGroupViewModel; }
            private set
            {
                if (value != _animalGroupViewModel)
                {
                    _animalGroupViewModel = value;
                    Notify("AnimalGroupViewModel");
                }
            }
        }
    }
}
