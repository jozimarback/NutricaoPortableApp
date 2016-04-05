using SQLite;

namespace NutricaoPortableApp.Data
{
    public interface ISqlite
    {
        SQLiteConnection ObterConexao();
    }
}