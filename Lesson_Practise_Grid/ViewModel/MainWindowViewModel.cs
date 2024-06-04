using Lesson_Practise_Grid.Models;
using Lesson_Practise_Grid.Services;
using Lesson_Practise_Grid.ViewModel.Base;
using System.Collections.ObjectModel;

namespace Lesson_Practise_Grid.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<Good> _goods;
        public ObservableCollection<Good> Goods
        {
            get { return _goods; }
            set
            {
                if (_goods != value)
                {
                    _goods = value;
                    OnPropertyChanged(nameof(Goods));
                }
            }
        }

        public MainWindowViewModel()
        {
            Goods = CsvFileReader.ReadCSVFile();
        }
    }
}
