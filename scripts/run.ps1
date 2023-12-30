# Launch from base folder repo
Set-Location .\src\ChromaListe.Web\
dotnet run -c Release -- -i .\input\ -o ..\..\output\
Set-Location ..\..
dotnet serve --directory .\output\ --path-base ChromaListe -o -q -p 36567
