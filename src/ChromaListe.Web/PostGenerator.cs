using System.Globalization;
using ChromaListe.Web.Core;
using Spectre.Console;

namespace ChromaListe.Web;

internal static class PostGenerator
{
    public static async Task RunAsync()
    {
        TextPrompt<Choice<(string name, string number)>> pokemonPrompt = new TextPrompt<Choice<(string name, string number)>>("Quel [yellow]Pokémon[/] ?")
            .AddChoices(Pokemon.GetAll().Select(p => new Choice<(string name, string number)>(p.Name, (p.Name, p.Number))))
            .HideChoices();
        Choice<(string name, string number)> selectedPokemon = pokemonPrompt.Show(AnsiConsole.Console);

        string catchYear = AnsiConsole.Ask("Année de capture ?", DateTime.Now.Year).ToString("D2", CultureInfo.InvariantCulture);
        string catchMonth = AnsiConsole.Ask("Mois de capture ?", DateTime.Now.Month).ToString("D2", CultureInfo.InvariantCulture);
        string catchDay = AnsiConsole.Ask("Jour de capture ?", DateTime.Now.Day).ToString("D2", CultureInfo.InvariantCulture);
        string catchLocation = AnsiConsole.Ask<string>("Lieu de capture ?");
        int catchLevel = AnsiConsole.Ask<int>("Niveau de capture ?");

        string? imageSuffix = null;
        if (Confirm("Doublon ?"))
        {
            imageSuffix = AnsiConsole.Ask<string>("Suffixe de l'image ?");
        }

        string? caughtAs = null;
        if (Confirm("Evolution ?"))
        {
            TextPrompt<Choice<string>> basePokemonPrompt = new TextPrompt<Choice<string>>("Forme capturée ?")
                .AddChoices(Pokemon.GetAll().Select(p => new Choice<string>(p.Name, p.Name)))
                .HideChoices();
            caughtAs = basePokemonPrompt.Show(AnsiConsole.Console).Value;
        }

        SelectionPrompt<Choice<GameVersion>> gamePrompt = new SelectionPrompt<Choice<GameVersion>>()
            .Title("Quel [blue]jeu[/] ?")
            .PageSize(Enum.GetValues<GameVersion>().Length)
            .AddChoices(Enum.GetValues<GameVersion>().Select(p => new Choice<GameVersion>(p.GetDescription(), p)).Reverse());
        Choice<GameVersion> game = AnsiConsole.Prompt(gamePrompt);
        AnsiConsole.MarkupLine($"Quel [blue]jeu[/] ? {game.Value.GetDescription()}");

        SelectionPrompt<Choice<Category>> categoryPrompt = new SelectionPrompt<Choice<Category>>()
            .Title("Quelle [blue]méthode[/] ?")
            .PageSize(Enum.GetValues<Category>().Length)
            .AddChoices(Enum.GetValues<Category>().Select(p => new Choice<Category>(p.GetDescription(), p)).Reverse());
        Choice<Category> category = AnsiConsole.Prompt(categoryPrompt);
        AnsiConsole.MarkupLine($"Quelle [blue]méthode[/] ? {category.Value.GetDescription()}");

        SelectionPrompt<Choice<Ball>> ballPrompt = new SelectionPrompt<Choice<Ball>>()
            .Title("Quelle [blue]balle[/] ?")
            .PageSize(Enum.GetValues<Ball>().Length)
            .AddChoices(Enum.GetValues<Ball>().Select(p => new Choice<Ball>(p.GetDescription(), p)));
        Choice<Ball> ball = AnsiConsole.Prompt(ballPrompt);
        AnsiConsole.MarkupLine($"Quelle [blue]balle[/] ? {ball.Value.GetDescription()}");

        string filename = $@"input\posts\{catchYear}\{catchMonth}\{catchYear}-{catchMonth}-{catchDay}-{selectedPokemon.Value.name.Slugify()}.md";

        ICollection<string> lines =
        [
            "---",
            $"number: {selectedPokemon.Value.number}",
            $"category: {category.Value}",
            $"location: {catchLocation}",
            $"level: {catchLevel}",
            $"version: {game.Value}",
            $"ball: {ball.Value}",
        ];

        if (imageSuffix is not null)
        {
            lines.Add($"imageSuffix: {imageSuffix}");
        }

        if (caughtAs is not null)
        {
            lines.Add($"caught: {caughtAs}");
        }

        lines.Add("---");

        Directory.CreateDirectory(Path.GetDirectoryName(filename)!);
        await File.WriteAllLinesAsync(filename, lines);
    }

    private static bool Confirm(string prompt)
    {
        return new ConfirmationPrompt(prompt)
        {
            DefaultValue = false,
            Yes = 'o',
            No = 'n',
        }.Show(AnsiConsole.Console);
    }
}

public record Choice<T>(string Title, T Value)
{
    public override string ToString()
    {
        return Title;
    }
}
