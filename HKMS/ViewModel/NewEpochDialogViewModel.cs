using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKMS.ViewModel
{
    public class NewEpochDialogViewModel : ObservableObject
    {
        private string? _inputTitle;
        public string? InputTitle
        {
            get => _inputTitle;
            set => SetProperty(ref _inputTitle, value);
        }

        private int _newEpoch;
        public int NewEpoch
        {
            get => _newEpoch;
            set => SetProperty(ref _newEpoch, value);
        }
    }
}
