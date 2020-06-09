﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using MHW_Editor.Models;

namespace MHW_Editor.Weapons {
    public partial class WeaponWSword : MhwMultiStructItem<WeaponWSword>, IShowAsSingleStruct<WeaponWSword.Entries> {
        public ObservableCollection<object> GetStructList() {
            return data.Last.Value.list;
        }

        public IEnumerable<Entries> GetIterableStructList() {
            return GetStructList().Cast<Entries>();
        }
    }
}