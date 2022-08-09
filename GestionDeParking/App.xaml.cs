using GestionDeParking.Model;
using GestionDeParking.Services;

namespace GestionDeParking;

public partial class App : Application
{

    private static CarService database;

    public static CarService Database
    {
        get
        {
            if (database == null)
            {
                database = new CarService(Path.Combine(FileSystem.AppDataDirectory, "car.db"));
                //var image = "bmw.png";
                //var car = new Car
                //{
                //    Name = "BMW",
                //    Marque = "BMW",
                //    Image = image
                //};

                //database.SavePersonAsync(car);
            }

            return database;
        }
    }
    public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
		 
	}
}
