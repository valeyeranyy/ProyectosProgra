using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasesiniciales
{
    public class Program
    {
        //este es el metodo main. Sirve como punto de entrada para el programa (inicia desde aqui):
        static void Main(string[] args)
        {
            Mochila mochilaAna = new Mochila();
            mochilaAna.Disenio = "Piolín";
            mochilaAna.Material = "Vinyl";
            mochilaAna.NumDeBolsas = 3;
            mochilaAna.NumDeLlaveros = 0;
            mochilaAna.Precio = 500.00f;
            mochilaAna.Tamanio = "Grande";
            mochilaAna.color = new Color();
            mochilaAna.color.Rojo = 100;
            mochilaAna.color.Verde = 20;
            mochilaAna.color.Azul = 33;

            Mochila mochilaBeto = new Mochila();
            mochilaBeto.Material = "piel";
            mochilaBeto.Disenio = "Pokemon";
            mochilaBeto.NumDeBolsas = 3;
            mochilaBeto.NumDeLlaveros = 3;
            mochilaBeto.Precio = 179.50f;
            mochilaBeto.Tamanio = "Grande";
            mochilaBeto.color = new Color();
            mochilaBeto.color.Rojo = 0;
            mochilaBeto.color.Verde = 128;
            mochilaBeto.color.Azul = 210;


            Mochila mochilaKarla = new Mochila();
            mochilaKarla.Material = "piel";
            mochilaKarla.Disenio = "Mariposa";
            mochilaKarla.NumDeBolsas = 4;
            mochilaKarla.NumDeLlaveros = 3;
            mochilaKarla.Precio = 179.50f;
            mochilaKarla.Tamanio = "Grande";
            mochilaKarla.color = new Color();
            mochilaKarla.color.Rojo = 0;
            mochilaKarla.color.Verde = 128;
            mochilaKarla.color.Azul = 210;


            SmartPhone SmartPhoneVal = new SmartPhone();
            SmartPhoneVal.NetworkTechnology = "GSM/CDMA/HSPA/EVDO/LTE";
            SmartPhoneVal.LaunchAnnounce = 2018;
            SmartPhoneVal.LaunchStatus = 2018;
            SmartPhoneVal.BodyDimensionsAlto = 70.9f;
            SmartPhoneVal.BodyDimensionsAncho = 143.6f;
            SmartPhoneVal.BodyWeight = 177;
            SmartPhoneVal.BodyBuild = "Corning-made glass";
            SmartPhoneVal.BodySim = "Nano-SIM and eSIM";
            SmartPhoneVal.DisplayType = "Super Retina OLED";
            SmartPhoneVal.DisplaySize = 1.5f;
            SmartPhoneVal.ResolutionAlto = 1125;
            SmartPhoneVal.ResolutionAncho = 2436;
            SmartPhoneVal.DisplayProtection = "Scratch-resistant glass";
            SmartPhoneVal.PlatformOS = "iOS 12";
            SmartPhoneVal.PlatformChipset = "Apple A12 Bionic";
            SmartPhoneVal.PlatformCPU = "Hexa-core";
            SmartPhoneVal.PlatformGPU = "Apple GPU";
            SmartPhoneVal.MemoryCardSlot = false;
            SmartPhoneVal.MemoryIntrnal = "64GB 4GB RAM";
            SmartPhoneVal.MainCameraDual = 1.8f;
            SmartPhoneVal.MainCamerafeatures = "64GB 4GB RAM";
            SmartPhoneVal.MainCameraVideo = "4K@24/30/60fps";
            SmartPhoneVal.SelfieCameraSingle = 7;
            SmartPhoneVal.SelfieCameraFeatures = "HDR4";
            SmartPhoneVal.SelfieCameraVideo = 1080;
            SmartPhoneVal.LoudSpeakers = "Yes, with stereo speakers";
            SmartPhoneVal.CommsWlan = "wifi 802.11";
            SmartPhoneVal.Bluetooth = 5.0f;
            SmartPhoneVal.FeaturesSensors = "FaceID";
            SmartPhoneVal.BateryType = 2658;
            SmartPhoneVal.MiscColors = "Space Gray, Silver, Gold";
            SmartPhoneVal.MiscSar = 1.19f;
            SmartPhoneVal.Tests = "AnTuTu: 346379";
            SmartPhoneVal.TestsDisplay = "Contrast Ratio";
            SmartPhoneVal.TestsCamera = "Photo/Video";

        }
    }
}
