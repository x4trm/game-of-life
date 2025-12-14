public class Gra
{
  private Siatka _siatka;

  // public Gra(int liczbaRzedow, int liczbaKolumn, int ziarno)
  // {
  //   _siatka = new Siatka(liczbaRzedow,liczbaKolumn, ziarno);
  // }

  public Gra(Siatka siatka)
  {
    _siatka = siatka;
  }

  public void Uruchom(int liczbaIteracji)
  {
    for(int i = 0; i < liczbaIteracji; i++)
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.Black;
      Console.BackgroundColor = ConsoleColor.White; 
      Console.WriteLine($"Iteracja: {i+1}: ");
      Console.ResetColor();
      _siatka.ZrobKrok();
      _siatka.Wydrukuj();
      Thread.Sleep(200);
    }
  }
}