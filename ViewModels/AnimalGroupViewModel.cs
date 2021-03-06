﻿using System.Collections.ObjectModel;
using MMVVM.ViewModelBase;

using Groups.Model;

namespace Groups.ViewModels
{
    class AnimalGroupViewModel : ViewModelBase
    {
        public AnimalGroupViewModel()
        {
            GroupList = new ObservableCollection<object>();

            GroupList.Add(new AnimalGroup{Name = "Dogs", Comment = "Group for all dogs in the hood"});
            GroupList.Add(new AnimalGroup{Name = "Cats", Comment = "Group for all cats in the woods"});
            
            PossibleMembers = new ObservableCollection<object>();
            
            PossibleMembers.Add(new Animal("Aristocat"));

            ActiveMembers = new ObservableCollection<object>();

            ColumnHeading = "Animal groups";
            Notify("ColumnHeading");
        }

        public string ColumnHeading { get; set; }

        public ObservableCollection<object> GroupList { get; private set; }
        public ObservableCollection<object> PossibleMembers { get; private set; }
        public ObservableCollection<object> ActiveMembers { get; set; }
    }
}
