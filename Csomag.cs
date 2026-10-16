using System;
using System.Collections.Generic;
using System.Text;

namespace csomagkezelo
{
    internal class Csomag
    {
        // belso tarolok //
        private int sulyKg;
        private int tavolsagKm;
        private static int osszesCsomagSzam = 0;

        // tulajdonsagok //
        public string CsomagKod { get; set; }
        public string Cimzett { get; set; }
        // get-setben a belso valtozot hasznaljuk ! //
        public int SulyKg { get => sulyKg ; set => sulyKg = value < 0 ? 0 : value; }
        public int TavolsagKm { get => sulyKg; set => tavolsagKm = value < 0 ? 0 : value; }
        public static int OsszesCsomagSzam { get; }

        // konstruktorok //
        public Csomag(string csomagKod, string cimzett, int sulyKg) : this(csomagKod, cimzett, sulyKg, 10){ }
        public Csomag(string csomagKod, string cimzett, int sulyKg, int tavolsagKm)
        {
            SulyKg = sulyKg;
            Cimzett = cimzett;
            TavolsagKm = tavolsagKm;
            CsomagKod = csomagKod;
            osszesCsomagSzam++;
        }

        // metodusok //
        public int KiszallitasiDij(){ return 500 + (tavolsagKm * 100) + (sulyKg * 200); }
        public override string ToString() { return $"{CsomagKod} Címzett: {Cimzett} | Súly: {SulyKg} kg | Távolság: {TavolsagKm} km | Díj: {KiszallitasiDij()} Ft"; }
    }
}
