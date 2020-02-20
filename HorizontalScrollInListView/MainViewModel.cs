using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HorizontalScrollInListView
{
    public class MainViewModel: INotifyPropertyChanged
    {

        public ObservableCollection<Any> Items { get; private set; } = new ObservableCollection<Any>();
        //public ObservableCollection<Animal> HorizontalList { get; private set; } = new ObservableCollection<Animal>();

        public event PropertyChangedEventHandler PropertyChanged;
        private void onPropertyChanged([CallerMemberName] string key = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
        }

        public MainViewModel()
        {
        }

        public void loadItems()
        {
            Animal a1 = new Animal();
            a1.Name = "Jerry";
            a1.Age = 3000;

            Animal a2 = new Animal();
            a2.Name = "Burt";
            a2.Age = 300;

            Animal a3 = new Animal();
            a3.Name = "Arnold";
            a3.Age = 30;

            AnimalList a4 = new AnimalList();
            a4.List = new List<Animal>() { a1, a2, a3 };

            //HorizontalList = new ObservableCollection<Animal>() { a1, a2, a3 };
            Items = new ObservableCollection<Any>() { a1, a2, a3, a4 };
            onPropertyChanged("Items");
            //onPropertyChanged("HorizontalList");
        }

    }
}
