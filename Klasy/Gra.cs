public class Gra
{
  private Siatka _siatka;

  public Gra(int liczbaRzedow, int liczbaKolumn)
  {
    _siatka = new Siatka(liczbaRzedow,liczbaKolumn);
  }

  public void Uruchom(int liczbaIteracji)
  {
    for(int i = 0; i < liczbaIteracji; i++)
    {
      Console.WriteLine($"Iteracja: {i}: ");
      _siatka.ZrobKrok();
      _siatka.Wydrukuj();
    }
  }
}