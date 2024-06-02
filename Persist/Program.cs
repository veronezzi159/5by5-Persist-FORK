using Model;
using Service;
string path = "C:\\Users\\cauem\\JSONS\\dados_dos_radares.json";

//não consegui chamar a controller
var lst = ReadFile.GetData(path);
PersistService persistService = new PersistService();
Console.WriteLine( persistService.Insert(lst));
