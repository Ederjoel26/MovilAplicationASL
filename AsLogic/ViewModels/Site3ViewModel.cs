using AsLogic.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsLogic.ViewModels
{
    public partial class Site3ViewModel : ObservableObject
    {
        // Label's
        [ObservableProperty]
        double temperaturaRack1, temperaturaRack2, temperaturaRack3, temperaturaRack4;
        [ObservableProperty]
        double humedadRack1, humedadRack2, humedadRack3, humedadRack4;
        [ObservableProperty]
        string energiaRack1, energiaRack2, energiaRack3, energiaRack4;
        [ObservableProperty]
        string luzRack1, luzRack2, luzRack3, luzRack4;
        [ObservableProperty]
        string puertasRack1, puertasRack2, puertasRack3, puertasRack4;

        // Imagenes
        [ObservableProperty]
        string imgTemperaturaRack1, imgTemperaturaRack2, imgTemperaturaRack3, imgTemperaturaRack4;
        [ObservableProperty]
        string imgHumedadRack1, imgHumedadRack2, imgHumedadRack3, imgHumedadRack4;
        [ObservableProperty]
        string imgEnergiaRack1, imgEnergiaRack2, imgEnergiaRack3, imgEnergiaRack4;
        [ObservableProperty]
        string imgLuzRack1, imgLuzRack2, imgLuzRack3, imgLuzRack4;
        [ObservableProperty]
        string imgPuertasRack1, imgPuertasRack2, imgPuertasRack3, imgPuertasRack4;

        [RelayCommand]
        public async void AsignarValoresRack1()
        {
            string jsonGoogle = "jsonGoogle.json";
            var localPath = Path.Combine(FileSystem.CacheDirectory, jsonGoogle);
            using var json = await FileSystem.OpenAppPackageFileAsync(jsonGoogle);
            using var dest = File.Create(localPath);
            await json.CopyToAsync(dest);
            dest.Close();
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site3").Document("Rack1");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                if (rack.Puertas == false)
                {
                    ImgPuertasRack1 = "puertacerr.png";
                    PuertasRack1 = "Cerrada";
                }
                else
                {
                    ImgPuertasRack1 = "puertaopen.png";
                    PuertasRack1 = "Abierta";
                }
                if (rack.Energia == false)
                {
                    ImgEnergiaRack1 = "energia.png";
                    EnergiaRack1 = "No hay energia";
                }
                else
                {
                    ImgEnergiaRack1 = "rayocol.png";
                    EnergiaRack1 = "Hay energia";
                }
                if (rack.Luz == false)
                {
                    ImgLuzRack1 = "focoapg.png";
                    LuzRack1 = "Apagada";
                }
                else
                {
                    ImgLuzRack1 = "focopren.png";
                    LuzRack1 = "Encendida";
                }
                HumedadRack1 = rack.Humedad;
                if (rack.Humedad <= 10) ImgHumedadRack1 = "gotavacia.png";
                else if (rack.Humedad > 10 && rack.Humedad <= 20) ImgHumedadRack1 = "gota10.png";
                else if (rack.Humedad > 20 && rack.Humedad <= 30) ImgHumedadRack1 = "gota20.png";
                else if (rack.Humedad > 30 && rack.Humedad <= 40) ImgHumedadRack1 = "gota30.png";
                else if (rack.Humedad > 40 && rack.Humedad <= 50) ImgHumedadRack1 = "gota40.png";
                else if (rack.Humedad > 50 && rack.Humedad <= 60) ImgHumedadRack1 = "gota50.png";
                else if (rack.Humedad > 60 && rack.Humedad <= 70) ImgHumedadRack1 = "gota60.png";
                else if (rack.Humedad > 70 && rack.Humedad <= 80) ImgHumedadRack1 = "gota70.png";
                else if (rack.Humedad > 80 && rack.Humedad <= 90) ImgHumedadRack1 = "gota80.png";
                else if (rack.Humedad >= 90) ImgHumedadRack1 = "gota90.png";

                TemperaturaRack1 = rack.Temperatura;
                if (rack.Temperatura <= 0) ImgTemperaturaRack1 = "termovacio.png";
                else if (rack.Temperatura > 0 && rack.Temperatura <= 5) ImgTemperaturaRack1 = "termo1.png";
                else if (rack.Temperatura > 5 && rack.Temperatura <= 10) ImgTemperaturaRack1 = "termo2.png";
                else if (rack.Temperatura > 10 && rack.Temperatura <= 15) ImgTemperaturaRack1 = "termo3.png";
                else if (rack.Temperatura > 15 && rack.Temperatura <= 20) ImgTemperaturaRack1 = "termo4.png";
                else if (rack.Temperatura > 20 && rack.Temperatura <= 25) ImgTemperaturaRack1 = "termo5.png";
                else if (rack.Temperatura > 25) ImgTemperaturaRack1 = "termofull.png";
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack2()
        {
            string jsonGoogle = "jsonGoogle1.json";
            var localPath = Path.Combine(FileSystem.CacheDirectory, jsonGoogle);
            using var json = await FileSystem.OpenAppPackageFileAsync(jsonGoogle);
            using var dest = File.Create(localPath);
            await json.CopyToAsync(dest);
            dest.Close();
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site3").Document("Rack2");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                if (rack.Puertas == false)
                {
                    ImgPuertasRack2 = "puertacerr.png";
                    PuertasRack2 = "Cerrada";
                }
                else
                {
                    ImgPuertasRack2 = "puertaopen.png";
                    PuertasRack2 = "Abierta";
                }
                if (rack.Energia == false)
                {
                    ImgEnergiaRack2 = "energia.png";
                    EnergiaRack2 = "No hay energia";
                }
                else
                {
                    ImgEnergiaRack2 = "rayocol.png";
                    EnergiaRack2 = "Hay energia";
                }
                if (rack.Luz == false)
                {
                    ImgLuzRack2 = "focoapg.png";
                    LuzRack2 = "Apagada";
                }
                else
                {
                    ImgLuzRack2 = "focopren.png";
                    LuzRack2 = "Encendida";
                }
                HumedadRack2 = rack.Humedad;
                if (rack.Humedad <= 10) ImgHumedadRack2 = "gotavacia.png";
                else if (rack.Humedad > 10 && rack.Humedad <= 20) ImgHumedadRack2 = "gota10.png";
                else if (rack.Humedad > 20 && rack.Humedad <= 30) ImgHumedadRack2 = "gota20.png";
                else if (rack.Humedad > 30 && rack.Humedad <= 40) ImgHumedadRack2 = "gota30.png";
                else if (rack.Humedad > 40 && rack.Humedad <= 50) ImgHumedadRack2 = "gota40.png";
                else if (rack.Humedad > 50 && rack.Humedad <= 60) ImgHumedadRack2 = "gota50.png";
                else if (rack.Humedad > 60 && rack.Humedad <= 70) ImgHumedadRack2 = "gota60.png";
                else if (rack.Humedad > 70 && rack.Humedad <= 80) ImgHumedadRack2 = "gota70.png";
                else if (rack.Humedad > 80 && rack.Humedad <= 90) ImgHumedadRack2 = "gota80.png";
                else if (rack.Humedad >= 90) ImgHumedadRack2 = "gota90.png";

                TemperaturaRack2 = rack.Temperatura;
                if (rack.Temperatura <= 0) ImgTemperaturaRack2 = "termovacio.png";
                else if (rack.Temperatura > 0 && rack.Temperatura <= 5) ImgTemperaturaRack2 = "termo1.png";
                else if (rack.Temperatura > 5 && rack.Temperatura <= 10) ImgTemperaturaRack2 = "termo2.png";
                else if (rack.Temperatura > 10 && rack.Temperatura <= 15) ImgTemperaturaRack2 = "termo3.png";
                else if (rack.Temperatura > 15 && rack.Temperatura <= 20) ImgTemperaturaRack2 = "termo4.png";
                else if (rack.Temperatura > 20 && rack.Temperatura <= 25) ImgTemperaturaRack2 = "termo5.png";
                else if (rack.Temperatura > 25) ImgTemperaturaRack2 = "termofull.png";
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack3()
        {
            string jsonGoogle = "jsonGoogle2.json";
            var localPath = Path.Combine(FileSystem.CacheDirectory, jsonGoogle);
            using var json = await FileSystem.OpenAppPackageFileAsync(jsonGoogle);
            using var dest = File.Create(localPath);
            await json.CopyToAsync(dest);
            dest.Close();
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site3").Document("Rack3");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                if (rack.Puertas == false)
                {
                    ImgPuertasRack3 = "puertacerr.png";
                    PuertasRack3 = "Cerrada";
                }
                else
                {
                    ImgPuertasRack3 = "puertaopen.png";
                    PuertasRack3 = "Abierta";
                }
                if (rack.Energia == false)
                {
                    ImgEnergiaRack3 = "energia.png";
                    EnergiaRack3 = "No hay energia";
                }
                else
                {
                    ImgEnergiaRack3 = "rayocol.png";
                    EnergiaRack3 = "Hay energia";
                }
                if (rack.Luz == false)
                {
                    ImgLuzRack3 = "focoapg.png";
                    LuzRack3 = "Apagada";
                }
                else
                {
                    ImgLuzRack3 = "focopren.png";
                    LuzRack3 = "Encendida";
                }
                HumedadRack3 = rack.Humedad;
                if (rack.Humedad <= 10) ImgHumedadRack3 = "gotavacia.png";
                else if (rack.Humedad > 10 && rack.Humedad <= 20) ImgHumedadRack3 = "gota10.png";
                else if (rack.Humedad > 20 && rack.Humedad <= 30) ImgHumedadRack3 = "gota20.png";
                else if (rack.Humedad > 30 && rack.Humedad <= 40) ImgHumedadRack3 = "gota30.png";
                else if (rack.Humedad > 40 && rack.Humedad <= 50) ImgHumedadRack3 = "gota40.png";
                else if (rack.Humedad > 50 && rack.Humedad <= 60) ImgHumedadRack3 = "gota50.png";
                else if (rack.Humedad > 60 && rack.Humedad <= 70) ImgHumedadRack3 = "gota60.png";
                else if (rack.Humedad > 70 && rack.Humedad <= 80) ImgHumedadRack3 = "gota70.png";
                else if (rack.Humedad > 80 && rack.Humedad <= 90) ImgHumedadRack3 = "gota80.png";
                else if (rack.Humedad >= 90) ImgHumedadRack3 = "gota90.png";

                TemperaturaRack3 = rack.Temperatura;
                if (rack.Temperatura <= 0) ImgTemperaturaRack3 = "termovacio.png";
                else if (rack.Temperatura > 0 && rack.Temperatura <= 5) ImgTemperaturaRack3 = "termo1.png";
                else if (rack.Temperatura > 5 && rack.Temperatura <= 10) ImgTemperaturaRack3 = "termo2.png";
                else if (rack.Temperatura > 10 && rack.Temperatura <= 15) ImgTemperaturaRack3 = "termo3.png";
                else if (rack.Temperatura > 15 && rack.Temperatura <= 20) ImgTemperaturaRack3 = "termo4.png";
                else if (rack.Temperatura > 20 && rack.Temperatura <= 25) ImgTemperaturaRack3 = "termo5.png";
                else if (rack.Temperatura > 25) ImgTemperaturaRack3 = "termofull.png";
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack4()
        {
            string jsonGoogle = "jsonGoogle3.json";
            var localPath = Path.Combine(FileSystem.CacheDirectory, jsonGoogle);
            using var json = await FileSystem.OpenAppPackageFileAsync(jsonGoogle);
            using var dest = File.Create(localPath);
            await json.CopyToAsync(dest);
            dest.Close();
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site3").Document("Rack4");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                if (rack.Puertas == false)
                {
                    ImgPuertasRack4 = "puertacerr.png";
                    PuertasRack4 = "Cerrada";
                }
                else
                {
                    ImgPuertasRack4 = "puertaopen.png";
                    PuertasRack4 = "Abierta";
                }
                if (rack.Energia == false)
                {
                    ImgEnergiaRack4 = "energia.png";
                    EnergiaRack4 = "No hay energia";
                }
                else
                {
                    ImgEnergiaRack4 = "rayocol.png";
                    EnergiaRack4 = "Hay energia";
                }
                if (rack.Luz == false)
                {
                    ImgLuzRack4 = "focoapg.png";
                    LuzRack3 = "Apagada";
                }
                else
                {
                    ImgLuzRack4 = "focopren.png";
                    LuzRack4 = "Encendida";
                }
                HumedadRack4 = rack.Humedad;
                if (rack.Humedad <= 10) ImgHumedadRack4 = "gotavacia.png";
                else if (rack.Humedad > 10 && rack.Humedad <= 20) ImgHumedadRack4 = "gota10.png";
                else if (rack.Humedad > 20 && rack.Humedad <= 30) ImgHumedadRack4 = "gota20.png";
                else if (rack.Humedad > 30 && rack.Humedad <= 40) ImgHumedadRack4 = "gota30.png";
                else if (rack.Humedad > 40 && rack.Humedad <= 50) ImgHumedadRack4 = "gota40.png";
                else if (rack.Humedad > 50 && rack.Humedad <= 60) ImgHumedadRack4 = "gota50.png";
                else if (rack.Humedad > 60 && rack.Humedad <= 70) ImgHumedadRack4 = "gota60.png";
                else if (rack.Humedad > 70 && rack.Humedad <= 80) ImgHumedadRack4 = "gota70.png";
                else if (rack.Humedad > 80 && rack.Humedad <= 90) ImgHumedadRack4 = "gota80.png";
                else if (rack.Humedad >= 90) ImgHumedadRack4 = "gota90.png";

                TemperaturaRack4 = rack.Temperatura;
                if (rack.Temperatura <= 0) ImgTemperaturaRack4 = "termovacio.png";
                else if (rack.Temperatura > 0 && rack.Temperatura <= 5) ImgTemperaturaRack4 = "termo1.png";
                else if (rack.Temperatura > 5 && rack.Temperatura <= 10) ImgTemperaturaRack4 = "termo2.png";
                else if (rack.Temperatura > 10 && rack.Temperatura <= 15) ImgTemperaturaRack4 = "termo3.png";
                else if (rack.Temperatura > 15 && rack.Temperatura <= 20) ImgTemperaturaRack4 = "termo4.png";
                else if (rack.Temperatura > 20 && rack.Temperatura <= 25) ImgTemperaturaRack4 = "termo5.png";
                else if (rack.Temperatura > 25) ImgTemperaturaRack4 = "termofull.png";
            });
        }

        [RelayCommand]
        public async void RedireccionarPaginaAnterior()
        {
            await Shell.Current.GoToAsync("PaginaPrincipal");
        }
    }
}
