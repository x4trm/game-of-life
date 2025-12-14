public class Siatka
{
  private int[,] _tablicaKomórek;
  private const int Zywa = 1;
  private const int Martwa = 0;

  public Siatka(int liczbaRzedow, int liczbaKolumn, int ziarno)
  {
    _tablicaKomórek = new int[liczbaRzedow, liczbaKolumn];
    Random random = new Random(ziarno);
    for (int i = 0; i < liczbaRzedow; i++)
    {
      for (int j = 0; j < liczbaKolumn; j++)
      {
        int wylosowanaLiczba = random.Next(2); // zwraca 0 lub 1
        _tablicaKomórek[i, j] = wylosowanaLiczba == 1 ? Zywa : Martwa;
      }
    }
  }

  public Siatka(int[,] tablicaPoczatkowa,int liczbaRzedow, int liczbaKolumn)
  {
    _tablicaKomórek = new int[liczbaRzedow, liczbaKolumn];
    for (int i = 0; i < tablicaPoczatkowa.GetLength(0); i++)
    {
      for (int j = 0; j < tablicaPoczatkowa.GetLength(1); j++)
      {
        _tablicaKomórek[i, j] = tablicaPoczatkowa[i,j];
      }
    }
  }

  public void ZrobKrok()
  {
    int[,] noweKomorki = new int[_tablicaKomórek.GetLength(0), _tablicaKomórek.GetLength(1)];
    for (int i = 0; i < _tablicaKomórek.GetLength(0); i++)
    {
      for (int j = 0; j < _tablicaKomórek.GetLength(1); j++)
      {
        noweKomorki[i,j] = ZastosujZasady(i,j);
      }
    }
    _tablicaKomórek = noweKomorki;
  }

  private int PoliczZywychSasiadow(int nrRzedu, int nrKolumny)
  {
    int licznik = 0;
    for (int i = nrRzedu - 1; i <= nrRzedu + 1; i++)
    {
      for (int j = nrKolumny - 1; j <= nrKolumny + 1; j++)
      {
        if (i >= 0
            && i < _tablicaKomórek.GetLength(0)
            && j >= 0
            && j < _tablicaKomórek.GetLength(1)
            && !(i == nrRzedu && j == nrKolumny))
        {
          if (_tablicaKomórek[i, j] == Zywa)
          {
            licznik++;
          }
        }
      }
    }

    return licznik;
  }

  private int ZastosujZasady(int nrRzedu, int nrKolumny)
  {
    int liczbaSasiadow = PoliczZywychSasiadow(nrRzedu, nrKolumny);
    if(_tablicaKomórek[nrRzedu,nrKolumny] == Zywa)
    {
      if(liczbaSasiadow == 2 || liczbaSasiadow == 3)
      {
        return Zywa;
      }
    }
    else // martwa komorka
    {
      if(liczbaSasiadow == 3)
      {
        return Zywa;
      }
    }
    return Martwa;
  }


  public void Wydrukuj()
  {
    string wydruk = new string('-',_tablicaKomórek.GetLength(1)*2) + "\n";
    for(int i = 0; i < _tablicaKomórek.GetLength(0); i++)
    {
      for(int j = 0; j< _tablicaKomórek.GetLength(1); j++)
      {
        if (_tablicaKomórek[i, j] == Zywa)
        {
          wydruk += "X";
        }
        else
        {
          wydruk += " ";
        }
        wydruk += " ";
      }
      wydruk +="|\n";
    }
    wydruk += new string('-',_tablicaKomórek.GetLength(1)*2);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(wydruk);
    Console.ResetColor();
  }
}