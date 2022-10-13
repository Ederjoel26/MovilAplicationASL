using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsLogic.Models
{
    public static class Valores
    {
        public static RespuestaAsignacionModel Asignacion(RackModel rack)
        {
            RackStringModel res = new RackStringModel();
            RackImagenesModel resImagenes = new RackImagenesModel();
            Puertas(rack, res, resImagenes);
            Energia(rack, res, resImagenes);
            Luz(rack, res, resImagenes);
            Humedad(rack, res, resImagenes);
            Temperatura(rack, res, resImagenes);
            return new RespuestaAsignacionModel(res, resImagenes);
        }

        private static void Puertas(RackModel rack, RackStringModel res, RackImagenesModel resImagenes)
        {
            if (rack.Puertas == false)
            {
                resImagenes.ImgPuertas = "puertacerr.png";
                res.Puertas = "Cerrada";
            }
            else
            {
                resImagenes.ImgPuertas = "puertaopen.png";
                res.Puertas = "Abierta";
            }
        }

        private static void Energia(RackModel rack, RackStringModel res, RackImagenesModel resImagenes)
        {
            if (rack.Energia == false)
            {
                resImagenes.ImgEnergia = "energia.png";
                res.Energia = "No hay energia";
            }
            else
            {
                resImagenes.ImgEnergia = "rayocol.png";
                res.Energia = "Hay energia";
            }
        }

        private static void Luz(RackModel rack, RackStringModel res, RackImagenesModel resImagenes)
        {
            if (rack.Luz == false)
            {
                resImagenes.ImgLuz = "focoapg.png";
                res.Luz = "Apagada";
            }
            else
            {
                resImagenes.ImgLuz = "focopren.png";
                res.Luz = "Encendida";
            }
        }

        private static void Humedad(RackModel rack, RackStringModel res, RackImagenesModel resImagenes)
        {
            res.Humedad = $"{rack.Humedad} %";
            if (rack.Humedad <= 10) resImagenes.ImgHumedad = "gotavacia.png";
            else if (rack.Humedad > 10 && rack.Humedad <= 20) resImagenes.ImgHumedad = "gota10.png";
            else if (rack.Humedad > 20 && rack.Humedad <= 30) resImagenes.ImgHumedad = "gota20.png";
            else if (rack.Humedad > 30 && rack.Humedad <= 40) resImagenes.ImgHumedad = "gota30.png";
            else if (rack.Humedad > 40 && rack.Humedad <= 50) resImagenes.ImgHumedad = "gota40.png";
            else if (rack.Humedad > 50 && rack.Humedad <= 60) resImagenes.ImgHumedad = "gota50.png";
            else if (rack.Humedad > 60 && rack.Humedad <= 70) resImagenes.ImgHumedad = "gota60.png";
            else if (rack.Humedad > 70 && rack.Humedad <= 80) resImagenes.ImgHumedad = "gota70.png";
            else if (rack.Humedad > 80 && rack.Humedad <= 90) resImagenes.ImgHumedad = "gota80.png";
            else if (rack.Humedad >= 90) resImagenes.ImgHumedad = "gota90.png";
        }

        private static void Temperatura(RackModel rack, RackStringModel res, RackImagenesModel resImagenes)
        {
            res.Temperatura = $"{rack.Temperatura} °C";
            if (rack.Temperatura <= 0) resImagenes.ImgTemperatura = "termovacio.png";
            else if (rack.Temperatura > 0 && rack.Temperatura <= 5) resImagenes.ImgTemperatura = "termo1.png";
            else if (rack.Temperatura > 5 && rack.Temperatura <= 10) resImagenes.ImgTemperatura = "termo2.png";
            else if (rack.Temperatura > 10 && rack.Temperatura <= 15) resImagenes.ImgTemperatura = "termo3.png";
            else if (rack.Temperatura > 15 && rack.Temperatura <= 20) resImagenes.ImgTemperatura = "termo4.png";
            else if (rack.Temperatura > 20 && rack.Temperatura <= 25) resImagenes.ImgTemperatura = "termo5.png";
            else if (rack.Temperatura > 25) resImagenes.ImgTemperatura = "termofull.png";
        }

        public async static Task<string> Validar(string Nombre)
        {
            string jsonGoogle = Nombre;
            string localPath = Path.Combine(FileSystem.CacheDirectory, jsonGoogle);
            using var json = await FileSystem.OpenAppPackageFileAsync(jsonGoogle);
            using var dest = File.Create(localPath);
            await json.CopyToAsync(dest);
            dest.Close();
            return localPath;
        }
    }
}
