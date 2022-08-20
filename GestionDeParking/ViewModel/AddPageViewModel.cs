using GestionDeParking.View;
using Microsoft.Maui.Controls;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionDeParking.Model;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using GestionDeParking.Services;

namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class AddPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;
        [ObservableProperty]
        string mediaPath;

        [ICommand]
        public async void AddCar()
        {
            await CarService.AddNewCar(car);
            await Shell.Current.GoToAsync("..");
            MediaPath=null; MessagingCenter.Send<HomePageViewModel>(new HomePageViewModel(), "refresh");
        }
        public Command CaptureImage
        {
            get
            {
                return new Command(async (e) =>
            {
                var photo = await MediaPicker.CapturePhotoAsync();
                var stream = await LoadPhotoAsync(photo);
                photo = null;
            });
            }
        }
        public Command PickImage
        {
            get
            {
                return new Command(async (e) =>
                {
                    var photo = await MediaPicker.PickPhotoAsync();
                    var stream = await LoadPhotoAsync(photo);
                    photo = null;
                    
                });
            }
        }
        async Task<Stream> LoadPhotoAsync(FileResult photo)
        {
            if (photo == null)
            {
                return null;
            }
            Path.Combine(FileSystem.CacheDirectory, photo.FileName);
            var stream = await photo.OpenReadAsync();
            MediaPath = photo.FullPath;
            Car.Image =MediaPath;
            return stream;
        }



      
    }
}