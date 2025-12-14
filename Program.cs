int [,] szybowiec = new int [3,3]
{
  {0,1,0},
  {0,0,1},
  {1,1,1}
};

int [,] kaczka = new int [5,5]
{
  {0,0,0,0,0},
  {0,0,1,1,0},
  {1,1,0,1,1},
  {1,1,1,1,0},
  {0,1,1,0,0}
};

int [,] wlasnaStruktura = new int [5,5]
{
  {0,0,1,0,0},
  {0,1,0,1,0},
  {1,0,0,0,1},
  {0,1,0,1,0},
  {0,0,1,0,0}
};

Siatka siatkaSzybowiec = new Siatka(szybowiec,20,20);
Siatka siatkaKaczka = new Siatka(kaczka,20,20);
Siatka wlasnaSiatka = new Siatka(wlasnaStruktura,20,20);
Siatka siatkaSeed = new Siatka(20,20,1);

// Gra gra = new Gra(25,25);
// Gra gra = new Gra(wlasnaSiatka);
Gra gra = new Gra(siatkaSeed);
gra.Uruchom(1000);