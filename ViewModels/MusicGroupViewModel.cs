using System.Collections.ObjectModel;
using MMVVM.ViewModelBase;

using Groups.Model;

namespace Groups.ViewModels
{
    class MusicGroupViewModel : ViewModelBase
    {
        public MusicGroupViewModel()
        {
            GroupList = new ObservableCollection<object>();

            GroupList.Add(new MusicGroup { Name = "IronMaiden", Description = "The Iron Maiden group page", IsActive = true});
            GroupList.Add(new MusicGroup { Name = "Metallica", Description = "The Metallica group page", IsActive = false});

            PossibleMembers = new ObservableCollection<object>();

            PossibleMembers.Add(new BandMember("Adam Claton"));
            PossibleMembers.Add(new BandMember("Axl Rose"));
            PossibleMembers.Add(new BandMember("James Hetfield"));

            ActiveMembers = new ObservableCollection<object>();

            ColumnHeading = "Music groups";
            Notify("ColumnHeading");
        }

        public string ColumnHeading { get; set; }

        public ObservableCollection<object> GroupList { get; private set; }
        public ObservableCollection<object> PossibleMembers { get; private set; }
        public ObservableCollection<object> ActiveMembers { get; set; } 
    }
}
