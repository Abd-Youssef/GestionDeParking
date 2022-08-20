using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using GestionDeParking.Model;

namespace GestionDeParking.Services
{
    public static class CarService
    {
        static SQLiteAsyncConnection db;
        static async Task Init()
        {
            if (db != null)
                return;

            // Get an absolute path to the database file
            var databasePath = Path.Combine(FileSystem.AppDataDirectory, "MyData.db");

            db = new SQLiteAsyncConnection(databasePath);

            await db.CreateTableAsync<Car>();
        }

        public static async Task AddNewCar(Car newCar)
        {
            
            await Init();
            Car car = new Car
            {
                Name = newCar.Name,
                Marque = newCar.Marque,
                Dispo = newCar.Dispo,
                Engine = newCar.Engine,
                Distance = newCar.Distance,
                Price = newCar.Price,
            };
            if (newCar.Image is null)
            {
                car.Image = "unknown.png";
                
            }
            else
            {
               car.Image=newCar.Image;
            }
            var id = await db.InsertAsync(car);

        }

        public static async Task RemoveCar(int id)
        {

            await Init();

            await db.DeleteAsync<Car>(id);
        }
        public static async Task ModifyCar(Car car)
        {
            await Init();
            await db.UpdateAsync(car);

        }

        public static async Task<IEnumerable<Car>> GetCar()
        {
            await Init();

            var car = await db.Table<Car>().ToListAsync();
            return car;
        }
        public static async Task ChangeDispo(Car car)
        {

            await Init();
            car.Dispo = !car.Dispo;
            await db.UpdateAsync(car);


        }

    }
}

