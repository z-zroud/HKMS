using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HKMS.Model
{
    public class Zodiac : ObservableObject
    {
        public Zodiac() {
            RelateNumber = new List<int>();
        }
        public string? Name { get; set; }

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

        public List<int> RelateNumber { get; set; }
    }
}
