using GestionDeParking.Model;
using GestionDeParking.Services;
using GestionDeParking.View;
using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDeParking.ViewModel
{
    [QueryProperty(nameof(Car), "Car")]
    public partial class ModificationPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        Car car;
        [ObservableProperty]
        string mediaPath;

        [ICommand]
        public async void Modify()
        {
            await CarService.ModifyCar(car);
            await Shell.Current.GoToAsync("..");
            MediaPath = null; MessagingCenter.Send<HomePageViewModel>(new HomePageViewModel(), "refresh");

        }
        public Command CaptureImage
        {
            get
            {
                return new Command(async (e) =>
                {
                    var photo = await MediaPicker.CapturePhotoAsync();
                    var stream = await LoadPhotoAsync(photo);
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
            Car.Image = photo.FullPath;
            return stream;
        }
    }

}
