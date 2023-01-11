SaveToFile.Models.Library library = new();

// lees de bestaande items uit een bestand

var creator = new SaveToFile.Views.Creator();
var menu = new SMUtils.Menu();

menu.AddOption('1', "Voeg een boek toe", () =>
{
    var book = creator.CreateBook();
    library.Items.Add(book);
});

menu.AddOption('2', "Voeg een game toe", () =>
{
    var game = creator.CreateGame();
    library.Items.Add(game);
});

menu.AddOption('3', "Toon Items", () => {
    SaveToFile.Views.Viewer.Show(library.Items);
    Console.Write("Typ ID voor meer: ");
    var result = Console.ReadLine();
    try
    {
        int i = int.Parse(result);
        if (i >= 0 && i < library.Items.Count)
        {
            SaveToFile.Views.Viewer.Show(library.Items[i]);
        }
    } catch { }
});

menu.AddOption('4', "Kies een library naam", () => {
    Console.Write("Naam van de library: ");
    library.Name = Console.ReadLine();
});

menu.AddOption('5', "Toon library details", () =>
{
    Console.WriteLine("Naam: " + library.Name);
    Console.WriteLine("Items: " + library.Items.Count);
    int books = 0;
    int games = 0;
    foreach (var item in library.Items)
    {
        if (item is SaveToFile.Models.Book) books++;
        else games++;
    }
    Console.WriteLine("books: " + books);
    Console.WriteLine("games: " + games);
});

menu.Start();

// Sla de library op voordat het programma afsluit
