using System;
using System.ComponentModel;
using MHW_Editor.Assets;
using MHW_Editor.Models;
using MHW_Template;
using MHW_Template.Models;

namespace MHW_Editor.Monster {
    public partial class MonsterEnrage {
        public const uint StructSize = 144;
        public const ulong InitialOffset = 0;
        public const long EntryCountOffset = -1;
        public const string EncryptionKey = null;
        public override string UniqueId => $"0";

        public const string Monster_Id_displayName = "Monster Id";
        public const int Monster_Id_sortIndex = 50;
        [SortOrder(Monster_Id_sortIndex)]
        [DisplayName(Monster_Id_displayName)]
        public virtual uint Monster_Id {
            get => GetData<uint>(8);
            set {
                if (GetData<uint>(8) == value) return;
                SetData(8, value, nameof(Monster_Id));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Monster_Id));
            }
        }

        public const string LR_HR_Trigger_Damage_displayName = "LR/HR Trigger Damage";
        public const int LR_HR_Trigger_Damage_sortIndex = 100;
        [SortOrder(LR_HR_Trigger_Damage_sortIndex)]
        [DisplayName(LR_HR_Trigger_Damage_displayName)]
        public virtual uint LR_HR_Trigger_Damage {
            get => GetData<uint>(16);
            set {
                if (GetData<uint>(16) == value) return;
                SetData(16, value, nameof(LR_HR_Trigger_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Trigger_Damage));
            }
        }

        public const string LR_HR_Duration_displayName = "LR/HR Duration";
        public const int LR_HR_Duration_sortIndex = 150;
        [SortOrder(LR_HR_Duration_sortIndex)]
        [DisplayName(LR_HR_Duration_displayName)]
        public virtual float LR_HR_Duration {
            get => GetData<float>(20);
            set {
                if (GetData<float>(20) == value) return;
                SetData(20, value, nameof(LR_HR_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Duration));
            }
        }

        public const string LR_HR_Speed_displayName = "LR/HR Speed";
        public const int LR_HR_Speed_sortIndex = 200;
        [SortOrder(LR_HR_Speed_sortIndex)]
        [DisplayName(LR_HR_Speed_displayName)]
        public virtual float LR_HR_Speed {
            get => GetData<float>(24);
            set {
                if (GetData<float>(24) == value) return;
                SetData(24, value, nameof(LR_HR_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Speed));
            }
        }

        public const string LR_HR_Damage_displayName = "LR/HR Damage";
        public const int LR_HR_Damage_sortIndex = 250;
        [SortOrder(LR_HR_Damage_sortIndex)]
        [DisplayName(LR_HR_Damage_displayName)]
        public virtual float LR_HR_Damage {
            get => GetData<float>(28);
            set {
                if (GetData<float>(28) == value) return;
                SetData(28, value, nameof(LR_HR_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Damage));
            }
        }

        public const string LR_HR_Player_Damage_displayName = "LR/HR Player Damage";
        public const int LR_HR_Player_Damage_sortIndex = 300;
        [SortOrder(LR_HR_Player_Damage_sortIndex)]
        [DisplayName(LR_HR_Player_Damage_displayName)]
        public virtual float LR_HR_Player_Damage {
            get => GetData<float>(32);
            set {
                if (GetData<float>(32) == value) return;
                SetData(32, value, nameof(LR_HR_Player_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(LR_HR_Player_Damage));
            }
        }

        public const string Unk1_displayName = "Unk1";
        public const int Unk1_sortIndex = 350;
        [SortOrder(Unk1_sortIndex)]
        [DisplayName(Unk1_displayName)]
        public virtual float Unk1 {
            get => GetData<float>(36);
            set {
                if (GetData<float>(36) == value) return;
                SetData(36, value, nameof(Unk1));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk1));
            }
        }

        public const string Unk2_displayName = "Unk2";
        public const int Unk2_sortIndex = 400;
        [SortOrder(Unk2_sortIndex)]
        [DisplayName(Unk2_displayName)]
        public virtual float Unk2 {
            get => GetData<float>(40);
            set {
                if (GetData<float>(40) == value) return;
                SetData(40, value, nameof(Unk2));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk2));
            }
        }

        public const string Unk3_displayName = "Unk3";
        public const int Unk3_sortIndex = 450;
        [SortOrder(Unk3_sortIndex)]
        [DisplayName(Unk3_displayName)]
        public virtual float Unk3 {
            get => GetData<float>(44);
            set {
                if (GetData<float>(44) == value) return;
                SetData(44, value, nameof(Unk3));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk3));
            }
        }

        public const string Unk4_displayName = "Unk4";
        public const int Unk4_sortIndex = 500;
        [SortOrder(Unk4_sortIndex)]
        [DisplayName(Unk4_displayName)]
        public virtual float Unk4 {
            get => GetData<float>(48);
            set {
                if (GetData<float>(48) == value) return;
                SetData(48, value, nameof(Unk4));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk4));
            }
        }

        public const string Unk5_displayName = "Unk5";
        public const int Unk5_sortIndex = 550;
        [SortOrder(Unk5_sortIndex)]
        [DisplayName(Unk5_displayName)]
        public virtual float Unk5 {
            get => GetData<float>(52);
            set {
                if (GetData<float>(52) == value) return;
                SetData(52, value, nameof(Unk5));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk5));
            }
        }

        public const string Unk6_displayName = "Unk6";
        public const int Unk6_sortIndex = 600;
        [SortOrder(Unk6_sortIndex)]
        [DisplayName(Unk6_displayName)]
        public virtual float Unk6 {
            get => GetData<float>(56);
            set {
                if (GetData<float>(56) == value) return;
                SetData(56, value, nameof(Unk6));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk6));
            }
        }

        public const string Unk7_displayName = "Unk7";
        public const int Unk7_sortIndex = 650;
        [SortOrder(Unk7_sortIndex)]
        [DisplayName(Unk7_displayName)]
        public virtual float Unk7 {
            get => GetData<float>(60);
            set {
                if (GetData<float>(60) == value) return;
                SetData(60, value, nameof(Unk7));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk7));
            }
        }

        public const string Unk8_displayName = "Unk8";
        public const int Unk8_sortIndex = 700;
        [SortOrder(Unk8_sortIndex)]
        [DisplayName(Unk8_displayName)]
        public virtual float Unk8 {
            get => GetData<float>(64);
            set {
                if (GetData<float>(64) == value) return;
                SetData(64, value, nameof(Unk8));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk8));
            }
        }

        public const string Unk9_displayName = "Unk9";
        public const int Unk9_sortIndex = 750;
        [SortOrder(Unk9_sortIndex)]
        [DisplayName(Unk9_displayName)]
        public virtual float Unk9 {
            get => GetData<float>(68);
            set {
                if (GetData<float>(68) == value) return;
                SetData(68, value, nameof(Unk9));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk9));
            }
        }

        public const string Unk10_displayName = "Unk10";
        public const int Unk10_sortIndex = 800;
        [SortOrder(Unk10_sortIndex)]
        [DisplayName(Unk10_displayName)]
        public virtual float Unk10 {
            get => GetData<float>(72);
            set {
                if (GetData<float>(72) == value) return;
                SetData(72, value, nameof(Unk10));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk10));
            }
        }

        public const string Unk11_displayName = "Unk11";
        public const int Unk11_sortIndex = 850;
        [SortOrder(Unk11_sortIndex)]
        [DisplayName(Unk11_displayName)]
        public virtual float Unk11 {
            get => GetData<float>(76);
            set {
                if (GetData<float>(76) == value) return;
                SetData(76, value, nameof(Unk11));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk11));
            }
        }

        public const string MR_Trigger_Damage_displayName = "MR Trigger Damage";
        public const int MR_Trigger_Damage_sortIndex = 900;
        [SortOrder(MR_Trigger_Damage_sortIndex)]
        [DisplayName(MR_Trigger_Damage_displayName)]
        public virtual uint MR_Trigger_Damage {
            get => GetData<uint>(80);
            set {
                if (GetData<uint>(80) == value) return;
                SetData(80, value, nameof(MR_Trigger_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Trigger_Damage));
            }
        }

        public const string MR_Duration_displayName = "MR Duration";
        public const int MR_Duration_sortIndex = 950;
        [SortOrder(MR_Duration_sortIndex)]
        [DisplayName(MR_Duration_displayName)]
        public virtual float MR_Duration {
            get => GetData<float>(84);
            set {
                if (GetData<float>(84) == value) return;
                SetData(84, value, nameof(MR_Duration));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Duration));
            }
        }

        public const string MR_Speed_displayName = "MR Speed";
        public const int MR_Speed_sortIndex = 1000;
        [SortOrder(MR_Speed_sortIndex)]
        [DisplayName(MR_Speed_displayName)]
        public virtual float MR_Speed {
            get => GetData<float>(88);
            set {
                if (GetData<float>(88) == value) return;
                SetData(88, value, nameof(MR_Speed));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Speed));
            }
        }

        public const string MR_Damage_displayName = "MR Damage";
        public const int MR_Damage_sortIndex = 1050;
        [SortOrder(MR_Damage_sortIndex)]
        [DisplayName(MR_Damage_displayName)]
        public virtual float MR_Damage {
            get => GetData<float>(92);
            set {
                if (GetData<float>(92) == value) return;
                SetData(92, value, nameof(MR_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Damage));
            }
        }

        public const string MR_Player_Damage_displayName = "MR Player Damage";
        public const int MR_Player_Damage_sortIndex = 1100;
        [SortOrder(MR_Player_Damage_sortIndex)]
        [DisplayName(MR_Player_Damage_displayName)]
        public virtual float MR_Player_Damage {
            get => GetData<float>(96);
            set {
                if (GetData<float>(96) == value) return;
                SetData(96, value, nameof(MR_Player_Damage));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(MR_Player_Damage));
            }
        }

        public const string Unk12_displayName = "Unk12";
        public const int Unk12_sortIndex = 1150;
        [SortOrder(Unk12_sortIndex)]
        [DisplayName(Unk12_displayName)]
        public virtual float Unk12 {
            get => GetData<float>(100);
            set {
                if (GetData<float>(100) == value) return;
                SetData(100, value, nameof(Unk12));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk12));
            }
        }

        public const string Unk13_displayName = "Unk13";
        public const int Unk13_sortIndex = 1200;
        [SortOrder(Unk13_sortIndex)]
        [DisplayName(Unk13_displayName)]
        public virtual float Unk13 {
            get => GetData<float>(104);
            set {
                if (GetData<float>(104) == value) return;
                SetData(104, value, nameof(Unk13));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk13));
            }
        }

        public const string Unk14_displayName = "Unk14";
        public const int Unk14_sortIndex = 1250;
        [SortOrder(Unk14_sortIndex)]
        [DisplayName(Unk14_displayName)]
        public virtual float Unk14 {
            get => GetData<float>(108);
            set {
                if (GetData<float>(108) == value) return;
                SetData(108, value, nameof(Unk14));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk14));
            }
        }

        public const string Unk15_displayName = "Unk15";
        public const int Unk15_sortIndex = 1300;
        [SortOrder(Unk15_sortIndex)]
        [DisplayName(Unk15_displayName)]
        public virtual float Unk15 {
            get => GetData<float>(112);
            set {
                if (GetData<float>(112) == value) return;
                SetData(112, value, nameof(Unk15));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk15));
            }
        }

        public const string Unk16_displayName = "Unk16";
        public const int Unk16_sortIndex = 1350;
        [SortOrder(Unk16_sortIndex)]
        [DisplayName(Unk16_displayName)]
        public virtual float Unk16 {
            get => GetData<float>(116);
            set {
                if (GetData<float>(116) == value) return;
                SetData(116, value, nameof(Unk16));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk16));
            }
        }

        public const string Unk17_displayName = "Unk17";
        public const int Unk17_sortIndex = 1400;
        [SortOrder(Unk17_sortIndex)]
        [DisplayName(Unk17_displayName)]
        public virtual float Unk17 {
            get => GetData<float>(120);
            set {
                if (GetData<float>(120) == value) return;
                SetData(120, value, nameof(Unk17));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk17));
            }
        }

        public const string Unk18_displayName = "Unk18";
        public const int Unk18_sortIndex = 1450;
        [SortOrder(Unk18_sortIndex)]
        [DisplayName(Unk18_displayName)]
        public virtual float Unk18 {
            get => GetData<float>(124);
            set {
                if (GetData<float>(124) == value) return;
                SetData(124, value, nameof(Unk18));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk18));
            }
        }

        public const string Unk19_displayName = "Unk19";
        public const int Unk19_sortIndex = 1500;
        [SortOrder(Unk19_sortIndex)]
        [DisplayName(Unk19_displayName)]
        public virtual float Unk19 {
            get => GetData<float>(128);
            set {
                if (GetData<float>(128) == value) return;
                SetData(128, value, nameof(Unk19));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk19));
            }
        }

        public const string Unk20_displayName = "Unk20";
        public const int Unk20_sortIndex = 1550;
        [SortOrder(Unk20_sortIndex)]
        [DisplayName(Unk20_displayName)]
        public virtual float Unk20 {
            get => GetData<float>(132);
            set {
                if (GetData<float>(132) == value) return;
                SetData(132, value, nameof(Unk20));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk20));
            }
        }

        public const string Unk21_displayName = "Unk21";
        public const int Unk21_sortIndex = 1600;
        [SortOrder(Unk21_sortIndex)]
        [DisplayName(Unk21_displayName)]
        public virtual float Unk21 {
            get => GetData<float>(136);
            set {
                if (GetData<float>(136) == value) return;
                SetData(136, value, nameof(Unk21));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk21));
            }
        }

        public const string Unk22_displayName = "Unk22";
        public const int Unk22_sortIndex = 1650;
        [SortOrder(Unk22_sortIndex)]
        [DisplayName(Unk22_displayName)]
        public virtual float Unk22 {
            get => GetData<float>(140);
            set {
                if (GetData<float>(140) == value) return;
                SetData(140, value, nameof(Unk22));
                OnPropertyChanged(nameof(Raw_Data));
                OnPropertyChanged(nameof(Unk22));
            }
        }

        public const int lastSortIndex = 1700;
    }
}