Oefening.Models.Library library = new();

// lees de bestaande items uit een bestand

var creator = new Oefening.Views.Creator();
var menu = new SMUtils.Menu();

menu.AddOption('1', "Toon library details", () =>
{
    Console.WriteLine("Naam: " + library.Name);
    Console.WriteLine("Games: " + library.Items.Count);
});

menu.AddOption('2', "Voeg een game toe", () =>
{
    var game = creator.CreateGame();
    library.Items.Add(game);
});

menu.AddOption('3', "Toon Items", () => {
    Oefening.Views.Viewer.Show(library.Items);
    Console.Write("Typ ID voor meer: ");
    var result = Console.ReadLine();
    try
    {
        int i = int.Parse(result);
        if (i >= 0 && i < library.Items.Count)
        {
            Oefening.Views.Viewer.Show(library.Items[i]);
        }
    } catch { }
});

menu.AddOption('4', "Kies een library naam", () => {
    Console.Write("Naam van de library: ");
    library.Name = Console.ReadLine();
});



menu.Start();

// Sla de library op voordat het programma afsluit
