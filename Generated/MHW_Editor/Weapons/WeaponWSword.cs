using MHW_Template;

namespace MHW_Editor.Weapons {
    public partial class WeaponWSword {
        public const uint StructSize = 10;
        public const ulong InitialOffset = 10;
        public const long EntryCountOffset = 6;
        public uint Id {
            get => GetData<uint>(0);
        }
        public MHW_Template.Weapons.Element Element_1_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(4);
            set {
                SetData(4, (byte) value);
                OnPropertyChanged(nameof(Element_1_Type));
            }
        }
        public short Element_1_Dmg {
            get => GetData<short>(5);
            set {
                SetData(5, value);
                OnPropertyChanged(nameof(Element_1_Dmg));
            }
        }
        public MHW_Template.Weapons.Element Element_2_Type {
            get => (MHW_Template.Weapons.Element) GetData<byte>(7);
            set {
                SetData(7, (byte) value);
                OnPropertyChanged(nameof(Element_2_Type));
            }
        }
        public short Element_2_Dmg {
            get => GetData<short>(8);
            set {
                SetData(8, value);
                OnPropertyChanged(nameof(Element_2_Dmg));
            }
        }
    }
}