﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefaktoringFowler.Core.Vlozit_metodu
{
    public class VlozitMetodu
    {
        private int _pocetZpozdeni = 3;

        public int GetHodnoceni()
        {
            return (_pocetZpozdeni > 5) ? 2 : 1;
        }
    }
}
