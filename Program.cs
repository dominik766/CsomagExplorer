using csomagkezelo;
Console.WriteLine("program elindult");
// az adatokat listaba gyujtjuk, a feldarabolt reszeknel jon majd a tomb //
// lista neve altalanossagban a temahoz kotodik, a tomb neve viszont nem lehet ugyanaz //
List<Csomag> csomagok = new List<Csomag>();
foreach (string aktsor in File.ReadAllLines("csomagok.txt")){
    if (!string.IsNullOrWhiteSpace(aktsor)){
        string[] adatok = aktsor.Split(';');
        if (adatok.Count() == 3){
            if (int.TryParse(adatok[2], out int SulyKg)) 
            { Csomag aktualis = new Csomag(adatok[0], adatok[1], SulyKg); csomagok.Add(aktualis);}
            else { Console.WriteLine("hiba: helytelen adatok, a sort átugrottam. (3)"); continue; }
        } else if (adatok.Count() == 4){
            if (int.TryParse(adatok[2], out int SulyKg)
             && int.TryParse(adatok[3], out int TavolsagKm)) 
            { Csomag aktualis = new Csomag(adatok[0], adatok[1], SulyKg, TavolsagKm); csomagok.Add(aktualis);}
            else { Console.WriteLine("hiba: helytelen adatok, a sort átugrottam. (4)"); continue; }}
    } else { Console.WriteLine("hiba: hiányzó adatok a sorban, átugorva."); continue; }
}
// ez a foreach a listaban porog egy segedvaltozoval a Csomag osztalyt felhasznalva, //
// aztan mindegyiket kiirja a console-ba egyesevel //
foreach (Csomag csomag in csomagok) { Console.WriteLine(csomag.ToString()); }
Console.WriteLine($"a rendszerben tárolt összes csomag: {Csomag.OsszesCsomagSzam} db");