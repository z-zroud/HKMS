using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKMS.Models
{
    public class Tema : ObservableObject
    {
        public int Number { get; set; }

        private int? _betMoney = null;
        public int? BetMoney
        {
            get => _betMoney;
            set
            {
                _betMoney = value;
                SetProperty(ref _betMoney, value);
            }
        }
    }
}
