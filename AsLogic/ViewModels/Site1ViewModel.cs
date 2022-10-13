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
    public partial class Site1ViewModel : ObservableObject
    {
        [ObservableProperty]
        string temperaturaRack1, temperaturaRack2, temperaturaRack3, temperaturaRack4;
        [ObservableProperty]
        string humedadRack1, humedadRack2, humedadRack3, humedadRack4;
        [ObservableProperty]
        string energiaRack1, energiaRack2, energiaRack3, energiaRack4;
        [ObservableProperty]
        string luzRack1, luzRack2, luzRack3, luzRack4;
        [ObservableProperty]
        string puertasRack1, puertasRack2, puertasRack3, puertasRack4;

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
            string localPath = await Valores.Validar("jsonGoogle.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site1").Document("Rack1");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                RespuestaAsignacionModel res = Valores.Asignacion(rack);
                HumedadRack1 = res.rack.Humedad;
                TemperaturaRack1 = res.rack.Temperatura;
                LuzRack1 = res.rack.Luz;
                EnergiaRack1 = res.rack.Energia;
                PuertasRack1 = res.rack.Puertas;
                ImgLuzRack1 = res.rackImagenesModel.ImgLuz;
                ImgPuertasRack1 = res.rackImagenesModel.ImgPuertas;
                ImgTemperaturaRack1 = res.rackImagenesModel.ImgTemperatura;
                ImgEnergiaRack1 = res.rackImagenesModel.ImgEnergia;
                ImgHumedadRack1 = res.rackImagenesModel.ImgHumedad;
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack2()
        {
            string localPath = await Valores.Validar("jsonGoogle1.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site1").Document("Rack2");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                RespuestaAsignacionModel res = Valores.Asignacion(rack);
                HumedadRack2 = res.rack.Humedad;
                TemperaturaRack2 = res.rack.Temperatura;
                LuzRack2 = res.rack.Luz;
                EnergiaRack2 = res.rack.Energia;
                PuertasRack2 = res.rack.Puertas;
                ImgLuzRack2 = res.rackImagenesModel.ImgLuz;
                ImgPuertasRack2 = res.rackImagenesModel.ImgPuertas;
                ImgTemperaturaRack2 = res.rackImagenesModel.ImgTemperatura;
                ImgEnergiaRack2 = res.rackImagenesModel.ImgEnergia;
                ImgHumedadRack2 = res.rackImagenesModel.ImgHumedad;
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack3()
        {
            string localPath = await Valores.Validar("jsonGoogle2.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site1").Document("Rack3");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                RespuestaAsignacionModel res = Valores.Asignacion(rack);
                HumedadRack3 = res.rack.Humedad;
                TemperaturaRack3 = res.rack.Temperatura;
                LuzRack3 = res.rack.Luz;
                EnergiaRack3 = res.rack.Energia;
                PuertasRack3 = res.rack.Puertas;
                ImgLuzRack3 = res.rackImagenesModel.ImgLuz;
                ImgPuertasRack3 = res.rackImagenesModel.ImgPuertas;
                ImgTemperaturaRack3 = res.rackImagenesModel.ImgTemperatura;
                ImgEnergiaRack3 = res.rackImagenesModel.ImgEnergia;
                ImgHumedadRack3 = res.rackImagenesModel.ImgHumedad;
            });
        }

        [RelayCommand]
        public async void AsignarValoresRack4()
        {
            string localPath = await Valores.Validar("jsonGoogle3.json");
            Environment.SetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS", localPath);
            FirestoreDb db = FirestoreDb.Create(Constantes.ProjectID);
            DocumentReference docRef = db.Collection("Site1").Document("Rack4");
            FirestoreChangeListener listener = docRef.Listen(snap =>
            {
                RackModel rack = snap.ConvertTo<RackModel>();
                RespuestaAsignacionModel res = Valores.Asignacion(rack);
                HumedadRack4 = res.rack.Humedad;
                TemperaturaRack4 = res.rack.Temperatura;
                LuzRack4 = res.rack.Luz;
                EnergiaRack4 = res.rack.Energia;
                PuertasRack4 = res.rack.Puertas;
                ImgLuzRack4 = res.rackImagenesModel.ImgLuz;
                ImgPuertasRack4 = res.rackImagenesModel.ImgPuertas;
                ImgTemperaturaRack4 = res.rackImagenesModel.ImgTemperatura;
                ImgEnergiaRack4 = res.rackImagenesModel.ImgEnergia;
                ImgHumedadRack4 = res.rackImagenesModel.ImgHumedad;
            });
        }
    }
}
