Set-Location .\src\Chromaliste.Web\
dotnet run -c Release -- -i .\input\ -o ..\..\output\
Set-Location ../..
dotnet serve --directory .\output\ --path-base ChromaListe -o -q
