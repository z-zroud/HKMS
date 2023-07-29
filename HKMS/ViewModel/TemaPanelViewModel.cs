using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using HKMS.DBModels;
using HKMS.Model;
using HKMS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace HKMS.ViewModel
{
    public class TemaPanelViewModel : ObservableObject
    {
        private const string DialogHostId = "TemaPanelDialogHostId";

        public TemaPanelViewModel()
        {
            var db = Ioc.Default.GetService<MSDBContext>();
            if (db != null)
            {
                var epoch = db.Epochs.Where(e => e.IsLatest).FirstOrDefault();
                if (epoch != null)
                {
                    CurrentEpoch = epoch.EpochNum;
                    var temas = db.TemaBets.Where(t => t.Epoch.IsLatest).ToList();
                    foreach (var tema in temas)
                    {
                        CurrentEpochTotalMoney += tema.Money;
                    }
                    var zodiacs = db.ZodiacBets.Where(z => z.Epoch.IsLatest).ToList();
                    foreach (var zodiac in zodiacs)
                    {
                        CurrentEpochTotalMoney += zodiac.Money;
                    }
                }
            }
        }

        private void UpdateTemas(int num, int money)
        {
            temaBetsRecords[num] = money;
            UpdateBets();
        }

        private void UpdateZodiac(string zodiac, int money)
        {
            zodiacBetRecords[zodiac] = money;
            UpdateBets();
        }

        private void UpdateBets()
        {
            TotalBetMoney = 0;
            BetCount = 0;
            foreach(var item in temaBetsRecords)
            {
                if(item.Value != 0)
                {
                    BetCount++;
                    TotalBetMoney += item.Value;
                }
            }
            foreach(var item in zodiacBetRecords)
            {
                if(item.Value != 0)
                {
                    BetCount++;
                    TotalBetMoney += item.Value;
                }
            }
        }

        private Dictionary<int, int> temaBetsRecords = new Dictionary<int, int>();
        private Dictionary<string, int> zodiacBetRecords = new Dictionary<string, int>();

        private int? _tema1 = null;
        public int? Tema1
        {
            get => _tema1;
            set
            {
                if (_tema1 != value)
                {
                    SetProperty(ref _tema1, value);
                    UpdateTemas(1, _tema1.GetValueOrDefault());
                }
            }
        }

        private int? _tema2 = null;
        public int? Tema2
        {
            get => _tema2;
            set
            {
                if (_tema2 != value)
                {
                    SetProperty(ref _tema2, value);
                    UpdateTemas(2, _tema2.GetValueOrDefault());
                }
            }
        }

        private int? _tema3 = null;
        public int? Tema3
        {
            get => _tema3;
            set
            {
                if (_tema3 != value)
                {
                    SetProperty(ref _tema3, value);
                    UpdateTemas(3, _tema3.GetValueOrDefault());
                }
            }
        }


        private int? _tema4 = null;
        public int? Tema4
        {
            get => _tema4;
            set
            {
                if (_tema4 != value)
                {
                    SetProperty(ref _tema4, value);
                    UpdateTemas(4, _tema4.GetValueOrDefault());
                }
            }
        }


        private int? _tema5 = null;
        public int? Tema5
        {
            get => _tema5;
            set
            {
                if (_tema5 != value)
                {
                    SetProperty(ref _tema5, value);
                    UpdateTemas(5, _tema5.GetValueOrDefault());
                }
            }
        }

        private int? _tema6 = null;
        public int? Tema6
        {
            get => _tema6;
            set
            {
                if (_tema6 != value)
                {
                    SetProperty(ref _tema6, value);
                    UpdateTemas(6, _tema6.GetValueOrDefault());
                }
            }
        }

        private int? _tema7 = null;
        public int? Tema7
        {
            get => _tema7;
            set
            {
                if (_tema7 != value)
                {
                    SetProperty(ref _tema7, value);
                    UpdateTemas(7, _tema7.GetValueOrDefault());
                }
            }
        }

        private int? _tema8 = null;
        public int? Tema8
        {
            get => _tema8;
            set
            {
                if (_tema8 != value)
                {
                    SetProperty(ref _tema8, value);
                    UpdateTemas(8, _tema8.GetValueOrDefault());
                }
            }
        }


        private int? _tema9 = null;
        public int? Tema9
        {
            get => _tema9;
            set
            {
                if (_tema9 != value)
                {
                    SetProperty(ref _tema9, value);
                    UpdateTemas(9, _tema9.GetValueOrDefault());
                }
            }
        }


        private int? _tema10 = null;
        public int? Tema10
        {
            get => _tema10;
            set
            {
                if (_tema10 != value)
                {
                    SetProperty(ref _tema10, value);
                    UpdateTemas(10, _tema10.GetValueOrDefault());
                }
            }
        }

        private int? _tema11 = null;
        public int? Tema11
        {
            get => _tema11;
            set
            {
                if (_tema11 != value)
                {
                    SetProperty(ref _tema11, value);
                    UpdateTemas(11, _tema11.GetValueOrDefault());
                }
            }
        }

        private int? _tema12 = null;
        public int? Tema12
        {
            get => _tema12;
            set
            {
                if (_tema12 != value)
                {
                    SetProperty(ref _tema12, value);
                    UpdateTemas(12, _tema12.GetValueOrDefault());
                }
            }
        }

        private int? _tema13 = null;
        public int? Tema13
        {
            get => _tema13;
            set
            {
                if (_tema13 != value)
                {
                    SetProperty(ref _tema13, value);
                    UpdateTemas(13, _tema13.GetValueOrDefault());
                }
            }
        }
        private int? _tema14 = null;
        public int? Tema14
        {
            get => _tema14;
            set
            {
                if (_tema14 != value)
                {
                    SetProperty(ref _tema14, value);
                    UpdateTemas(14, _tema14.GetValueOrDefault());
                }
            }
        }
        private int? _tema15 = null;
        public int? Tema15
        {
            get => _tema15;
            set
            {
                if (_tema15 != value)
                {
                    SetProperty(ref _tema15, value);
                    UpdateTemas(15, _tema15.GetValueOrDefault()); 
                }
            }
        }
        private int? _tema16 = null;
        public int? Tema16
        {
            get => _tema16;
            set
            {
                if (_tema16 != value)
                {
                    SetProperty(ref _tema16, value);
                    UpdateTemas(16, _tema16.GetValueOrDefault());
                }
            }
        }
        private int? _tema17 = null;
        public int? Tema17
        {
            get => _tema17;
            set
            {
                if (_tema17 != value)
                {
                    SetProperty(ref _tema17, value);
                    UpdateTemas(17, _tema17.GetValueOrDefault());
                }
            }
        }
        private int? _tema18 = null;
        public int? Tema18
        {
            get => _tema18;
            set
            {
                if (_tema18 != value)
                {
                    SetProperty(ref _tema18, value);
                    UpdateTemas(18, _tema18.GetValueOrDefault());
                }
            }
        }
        private int? _tema19 = null;
        public int? Tema19
        {
            get => _tema19;
            set
            {
                if (_tema19 != value)
                {
                    SetProperty(ref _tema19, value);
                    UpdateTemas(19, _tema19.GetValueOrDefault());
                }
            }
        }
        private int? _tema20 = null;
        public int? Tema20
        {
            get => _tema20;
            set
            {
                if (_tema20 != value)
                {
                    SetProperty(ref _tema20, value);
                    UpdateTemas(20, _tema20.GetValueOrDefault());
                }
            }
        }
        private int? _tema21 = null;
        public int? Tema21
        {
            get => _tema21;
            set
            {
                if (_tema21 != value)
                {
                    SetProperty(ref _tema21, value);
                    UpdateTemas(21, _tema21.GetValueOrDefault());
                }
            }
        }
        private int? _tema22 = null;
        public int? Tema22
        {
            get => _tema22;
            set
            {
                if (_tema22 != value)
                {
                    SetProperty(ref _tema22, value);
                    UpdateTemas(22, _tema22.GetValueOrDefault());
                }
            }
        }
        private int? _tema23 = null;
        public int? Tema23
        {
            get => _tema23;
            set
            {
                if (_tema23 != value)
                {
                    SetProperty(ref _tema23, value);
                    UpdateTemas(23, _tema23.GetValueOrDefault());
                }
            }
        }
        private int? _tema24 = null;
        public int? Tema24
        {
            get => _tema24;
            set
            {
                if (_tema24 != value)
                {
                    SetProperty(ref _tema24, value);
                    UpdateTemas(24, _tema24.GetValueOrDefault());
                }
            }
        }
        private int? _tema25 = null;
        public int? Tema25
        {
            get => _tema25;
            set
            {
                if (_tema25 != value)
                {
                    SetProperty(ref _tema25, value);
                    UpdateTemas(25, _tema25.GetValueOrDefault());
                }
            }
        }
        private int? _tema26 = null;
        public int? Tema26
        {
            get => _tema26;
            set
            {
                if (_tema26 != value)
                {
                    SetProperty(ref _tema26, value);
                    UpdateTemas(26, _tema26.GetValueOrDefault());
                }
            }
        }
        private int? _tema27 = null;
        public int? Tema27
        {
            get => _tema27;
            set
            {
                if (_tema27 != value)
                {
                    SetProperty(ref _tema27, value);
                    UpdateTemas(27, _tema27.GetValueOrDefault());
                }
            }
        }
        private int? _tema28 = null;
        public int? Tema28
        {
            get => _tema28;
            set
            {
                if (_tema28 != value)
                {
                    SetProperty(ref _tema28, value);
                    UpdateTemas(28, _tema27.GetValueOrDefault());
                }
            }
        }
        private int? _tema29 = null;
        public int? Tema29
        {
            get => _tema29;
            set
            {
                if (_tema29 != value)
                {
                    SetProperty(ref _tema29, value);
                    UpdateTemas(29, _tema29.GetValueOrDefault());
                }
            }
        }
        private int? _tema30 = null;
        public int? Tema30
        {
            get => _tema30;
            set
            {
                if (_tema30 != value)
                {
                    SetProperty(ref _tema30, value);
                    UpdateTemas(30, _tema30.GetValueOrDefault());
                }
            }
        }
        private int? _tema31 = null;
        public int? Tema31
        {
            get => _tema31;
            set
            {
                if (_tema31 != value)
                {
                    SetProperty(ref _tema31, value);
                    UpdateTemas(31, _tema31.GetValueOrDefault());
                }
            }
        }
        private int? _tema32 = null;
        public int? Tema32
        {
            get => _tema32;
            set
            {
                if (_tema32 != value)
                {
                    SetProperty(ref _tema32, value);
                    UpdateTemas(32, _tema32.GetValueOrDefault());
                }
            }
        }
        private int? _tema33 = null;
        public int? Tema33
        {
            get => _tema33;
            set
            {
                if (_tema33 != value)
                {
                    SetProperty(ref _tema33, value);
                    UpdateTemas(33, _tema33.GetValueOrDefault());
                }
            }
        }
        private int? _tema34 = null;
        public int? Tema34
        {
            get => _tema34;
            set
            {
                if (_tema34 != value)
                {
                    SetProperty(ref _tema34, value);
                    UpdateTemas(34, _tema34.GetValueOrDefault());
                }
            }
        }
        private int? _tema35 = null;
        public int? Tema35
        {
            get => _tema35;
            set
            {
                if (_tema35 != value)
                {
                    SetProperty(ref _tema35, value);
                    UpdateTemas(35, _tema35.GetValueOrDefault());
                }
            }
        }
        private int? _tema36 = null;
        public int? Tema36
        {
            get => _tema36;
            set
            {
                if (_tema36 != value)
                {
                    SetProperty(ref _tema36, value);
                    UpdateTemas(36, _tema36.GetValueOrDefault()); 
                }
            }
        }
        private int? _tema37 = null;
        public int? Tema37
        {
            get => _tema37;
            set
            {
                if (_tema37 != value)
                {
                    SetProperty(ref _tema37, value);
                    UpdateTemas(37, _tema37.GetValueOrDefault());
                }
            }
        }
        private int? _tema38 = null;
        public int? Tema38
        {
            get => _tema38;
            set
            {
                if (_tema38 != value)
                {
                    SetProperty(ref _tema38, value);
                    UpdateTemas(38, _tema38.GetValueOrDefault());
                }
            }
        }
        private int? _tema39 = null;
        public int? Tema39
        {
            get => _tema39;
            set
            {
                if (_tema39 != value)
                {
                    SetProperty(ref _tema39, value);
                    UpdateTemas(39, _tema39.GetValueOrDefault());
                }
            }
        }
        private int? _tema40 = null;
        public int? Tema40
        {
            get => _tema40;
            set
            {
                if (_tema40 != value)
                {
                    SetProperty(ref _tema40, value);
                    UpdateTemas(40, _tema40.GetValueOrDefault());
                }
            }
        }
        private int? _tema41 = null;
        public int? Tema41
        {
            get => _tema41;
            set
            {
                if (_tema41 != value)
                {
                    SetProperty(ref _tema41, value);
                    UpdateTemas(41, _tema41.GetValueOrDefault());
                }
            }
        }
        private int? _tema42 = null;
        public int? Tema42
        {
            get => _tema42;
            set
            {
                if (_tema42 != value)
                {
                    SetProperty(ref _tema42, value);
                    UpdateTemas(42, _tema42.GetValueOrDefault());
                }
            }
        }
        private int? _tema43 = null;
        public int? Tema43
        {
            get => _tema43;
            set
            {
                if (_tema43 != value)
                {
                    SetProperty(ref _tema43, value);
                    UpdateTemas(43, _tema43.GetValueOrDefault());
                }
            }
        }
        private int? _tema44 = null;
        public int? Tema44
        {
            get => _tema44;
            set
            {
                if (_tema44 != value)
                {
                    SetProperty(ref _tema44, value);
                    UpdateTemas(44, _tema44.GetValueOrDefault());
                }
            }
        }
        private int? _tema45 = null;
        public int? Tema45
        {
            get => _tema45;
            set
            {
                if (_tema45 != value)
                {
                    SetProperty(ref _tema45, value);
                    UpdateTemas(45, _tema45.GetValueOrDefault());
                }
            }
        }
        private int? _tema46 = null;
        public int? Tema46
        {
            get => _tema46;
            set
            {
                if (_tema46 != value)
                {
                    SetProperty(ref _tema46, value);
                    UpdateTemas(46, _tema46.GetValueOrDefault());
                }
            }
        }
        private int? _tema47 = null;
        public int? Tema47
        {
            get => _tema47;
            set
            {
                if (_tema47 != value)
                {
                    SetProperty(ref _tema47, value);
                    UpdateTemas(47, _tema47.GetValueOrDefault());
                }
            }
        }
        private int? _tema48 = null;
        public int? Tema48
        {
            get => _tema48;
            set
            {
                if (_tema48 != value)
                {
                    SetProperty(ref _tema48, value);
                    UpdateTemas(48, _tema48.GetValueOrDefault());
                }
            }
        }
        private int? _tema49 = null;
        public int? Tema49
        {
            get => _tema49;
            set
            {
                if (_tema49 != value)
                {
                    SetProperty(ref _tema49, value);
                    UpdateTemas(49, _tema49.GetValueOrDefault());
                }
            }
        }

        private int? _shu = null;
        public int? Zodiac_shu
        {
            get => _shu;
            set
            {
                SetProperty(ref _shu, value);
                UpdateZodiac("鼠", _shu.GetValueOrDefault());
            }
        }

        private int? _niu = null;
        public int? Zodiac_niu
        {
            get => _niu;
            set
            {
                SetProperty(ref _niu, value);
                UpdateZodiac("牛", _niu.GetValueOrDefault());
            }
        }

        private int? _hu = null;
        public int? Zodiac_hu
        {
            get => _hu;
            set
            {
                SetProperty(ref _hu, value);
                UpdateZodiac("虎", _hu.GetValueOrDefault());
            }
        }

        private int? _tu = null;
        public int? Zodiac_tu
        {
            get => _tu;
            set
            {
                SetProperty(ref _tu, value);
                UpdateZodiac("兔", _tu.GetValueOrDefault());
            }
        }

        private int? _long = null;
        public int? Zodiac_long
        {
            get => _long;
            set
            {
                SetProperty(ref _long, value);
                UpdateZodiac("龙", _long.GetValueOrDefault());
            }
        }

        private int? _she = null;
        public int? Zodiac_she
        {
            get => _she;
            set
            {
                SetProperty(ref _she, value);
                UpdateZodiac("蛇", _she.GetValueOrDefault());
            }
        }

        private int? _ma = null;
        public int? Zodiac_ma
        {
            get => _ma;
            set
            {
                SetProperty(ref _ma, value);
                UpdateZodiac("马", _ma.GetValueOrDefault());
            }
        }

        private int? _yang = null;
        public int? Zodiac_yang
        {
            get => _yang;
            set
            {
                SetProperty(ref _yang, value);
                UpdateZodiac("羊", _yang.GetValueOrDefault());
            }
        }

        private int? _hou = null;
        public int? Zodiac_hou
        {
            get => _hou;
            set
            {
                SetProperty(ref _hou, value);
                UpdateZodiac("猴", _hou.GetValueOrDefault());
            }
        }

        private int? _ji = null;
        public int? Zodiac_ji
        {
            get => _ji;
            set
            {
                SetProperty(ref _ji, value);
                UpdateZodiac("鸡", _ji.GetValueOrDefault());
            }
        }

        private int? _gou = null;
        public int? Zodiac_gou
        {
            get => _gou;
            set
            {
                SetProperty(ref _gou, value);
                UpdateZodiac("狗", _gou.GetValueOrDefault());
            }
        }

        private int? _zhu = null;
        public int? Zodiac_zhu
        {
            get => _zhu;
            set
            {
                SetProperty(ref _zhu, value);
                UpdateZodiac("猪", _zhu.GetValueOrDefault());
            }
        }

        // 每次总投注金额
        public int _totalBetMoney = 0;
        public int TotalBetMoney
        {
            get => _totalBetMoney;
            set
            {
                SetProperty(ref _totalBetMoney, value);
            }
        }

        // 投注次数
        private int _betCount = 0;
        public int BetCount
        {
            get { return _betCount; } 
            set
            {
                SetProperty(ref _betCount, value);
            }
        }

        // 当前投注期数
        private int _epoch;
        public int CurrentEpoch
        {
            get => _epoch;
            set { SetProperty(ref _epoch, value);}
        }

        //当期投注总金额
        private int _epochTotalMoney;
        public int CurrentEpochTotalMoney
        {
            get => _epochTotalMoney;
            set
            {
                SetProperty(ref _epochTotalMoney, value);
            }
        }


        // 新建开奖
        public ICommand NewEpochCommand => new RelayCommand(async () =>
        {
            var vm = new NewEpochDialogViewModel() { InputTitle = "新建开奖期数" };
            var result = await MaterialDesignThemes.Wpf.DialogHost.Show(vm, DialogHostId);
            
            if(result != null && (bool)result == true)
            {
                // 存储到数据库
                var db = Ioc.Default.GetService<MSDBContext>();
                if (db != null)
                {
                    var epoch = db.Epochs.Where(e => e.IsLatest).FirstOrDefault();
                    if(epoch != null)
                    {
                        epoch.IsLatest = false;
                        db.Epochs.Update(epoch);
                    }
                    db.Epochs.Add(new Epoch() { EpochNum = vm.NewEpoch, IsLatest = true });
                    db.SaveChanges();
                }
                //绑定界面
                CurrentEpoch = vm.NewEpoch;
            }
        });

        // 确认投注
        public ICommand BetCommand => new RelayCommand(() =>
        {
            var db = Ioc.Default.GetService<MSDBContext>();
            var epoch = db.Epochs.Where(e => e.EpochNum == CurrentEpoch).FirstOrDefault();

            if(epoch == null)
            {
                MessageBox.Show("没有指定开奖期数");
                return;
            }
            foreach(var item in zodiacBetRecords)
            {
                if(item.Value != 0)
                {
                    db.ZodiacBets.Add(new ZodiacBets() { Epoch = epoch, Money = item.Value, Name = item.Key  });
                    db.SaveChanges();
                    CurrentEpochTotalMoney += item.Value;
                }
            }
            foreach(var item in temaBetsRecords)
            {
                if (item.Value != 0)
                {
                    db.TemaBets.Add(new TemaBets() { Epoch = epoch, Money = item.Value, Number = item.Key });
                    db.SaveChanges();
                    CurrentEpochTotalMoney += item.Value;
                }
            }
            ResetBets();
        });

        //取消投注
        public ICommand CancelBetCommand => new RelayCommand(() =>
        {
            ResetBets();
        });

        private void ResetBets()
        {
            temaBetsRecords.Clear();
            zodiacBetRecords.Clear();
            BetCount = 0;
            TotalBetMoney = 0;

            Tema1 = Tema2 = Tema3 = Tema4 = Tema5 = Tema6 = Tema7 = Tema8 = Tema9 = Tema10 = null;
            Tema11 = Tema12 = Tema13 = Tema14 = null;
            Tema15 = Tema16 = null;
            Tema18 = null;
            Tema19 = null;
            Tema20 = null;
            Tema21 = Tema22 = null;
            Tema23 = Tema24 = Tema25 = Tema26 = Tema27 = Tema28  = Tema29 = Tema30  = null;
            Tema31 = Tema32 = Tema33 = Tema34 = Tema35 = Tema36 = Tema37 = Tema38 = Tema39 = Tema40 = null;
            Tema41 = Tema42 = Tema43 = Tema44 = Tema45 = Tema46 = Tema47 = Tema48 = Tema49 = null;

            Zodiac_gou = Zodiac_hou = Zodiac_zhu = Zodiac_long = Zodiac_ji = Zodiac_yang = null;
            Zodiac_shu = Zodiac_she = Zodiac_hu = Zodiac_tu = Zodiac_niu = Zodiac_ma = null;
        }
    }
}
