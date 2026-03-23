// Services/EntradaService.cs
using SQLite;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Maui.Storage;
using MyGoodDiary.src.Model;

namespace MyGoodDiary.src.Service;

public class EntradaService
{
    private readonly SQLiteAsyncConnection _db;

    public EntradaService()
    {
        var path = Path.Combine(FileSystem.AppDataDirectory, "diario.db3");
        _db = new SQLiteAsyncConnection(path);
        _db.CreateTableAsync<Entrada>().Wait();
    }

    public Task<List<Entrada>> GetEntradasAsync()
        => _db.Table<Entrada>().OrderByDescending(e => e.Fecha).ToListAsync();

    public Task<int> SaveEntradaAsync(Entrada entrada)
        => entrada.Id != 0 ? _db.UpdateAsync(entrada) : _db.InsertAsync(entrada);

    public Task<int> DeleteEntradaAsync(Entrada entrada)
        => _db.DeleteAsync(entrada);
}