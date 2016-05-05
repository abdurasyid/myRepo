using Template10.Mvvm;
using NewbieNgalam.Models;

namespace NewbieNgalam.ViewModels
{
    public class ListPageViewModel : ViewModelBase
    {
        private int _AngkotId;

        public int AngkotId
        {
            get
            {
                return _AngkotId;
            }
        }

        public string AngkotName { get; set; }
        public string AngkotTrayek { get; set; }
        public string AngkotOutPath { get; set; }
        public string AngkotInPath { get; set; }

        public ListPageViewModel()
        {
        }

        public static ListPageViewModel FromAngkot(Angkot angkot)
        {
            var viewModel = new ListPageViewModel();

            viewModel._AngkotId = angkot.Id;
            viewModel.AngkotName = angkot.AngkotName;
            viewModel.AngkotTrayek = angkot.AngkotTrayek;
            viewModel.AngkotOutPath = angkot.AngkotOutPath;
            viewModel.AngkotInPath = angkot.AngkotInPath;

            return viewModel;
        }
    }
}
