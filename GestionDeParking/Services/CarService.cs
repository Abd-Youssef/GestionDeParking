using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using GestionDeParking.Model;

namespace GestionDeParking.Services
{
    public  class CarService
    {

        
        private readonly SQLiteAsyncConnection _database;

        public CarService(string dbPath)
        {
            if (_database != null)
                        return;
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Car>();


        }

        public Task<List<Car>> GetPeopleAsync()
        {
            var car = _database.Table<Car>().ToListAsync();
            return car;
        }

        public Task<int> SavePersonAsync(Car car)
        {
            return _database.InsertAsync(car);
        }
    }



    //static SQLiteAsyncConnection db;
    // async Task Init()
    //{
    //    if (db != null)
    //        return;

    //    // Get an absolute path to the database file
    //    var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

    //    db = new SQLiteAsyncConnection(databasePath);

    //    await db.CreateTableAsync<Car>();
    //}

    //public  async Task AddCar(string name, string marque)
    //{
    //    await Init();
    //var image = "bmw.png";
    //var car = new Car
    //{
    //    Name = name,
    //    Marque = marque,
    //    Image = image
    //};

    //var id = await db.InsertAsync(car);
    //}

    //public  async Task RemoveCar(int id)
    //{

    //    await Init();

    //    await db.DeleteAsync<Car>(id);
    //}

    //public  async Task<IEnumerable<Car>> GetCar()
    //{
    //    await Init();

    //    var car = await db.Table<Car>().ToListAsync();
    //    return car;
    //}

    //public async Task<Car> GetCar(int id)
    //{
    //    await Init();

    //    var car = await db.Table<Car>()
    //        .FirstOrDefaultAsync(c => c.Id == id);

    //    return car;
    //}
}

