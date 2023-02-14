using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7Partea1
{
    /*
    Un autoturism detine un motor
    precum si un numar de usi. De 
    asemenea autovehiculul este
    caracterizat de marca, model si an 
    de fabricatie 
    */
    public class Autoturism
    {
        private Motor motor;

        private int numarDeUsi;

        private string marca;

        private string model;

        private int anDeFabricatie;

        public Autoturism(Motor motor, int numarDeUsi, string marca, string model, int anDeFabricatie)
        {
            this.motor = motor;
            this.numarDeUsi = numarDeUsi;
            this.marca = marca;
            this.model = model;
            this.anDeFabricatie = anDeFabricatie;
        }

        /// <summary>
        /// Returneaza obiectul motor
        /// </summary>
        /// <returns></returns>
        public Motor GetMotor()
        {
            return motor;
        }

        /// <summary>
        /// Atribuie o valoare de tip Motor obiectului motor
        /// </summary>
        /// <param name="motor"></param>
        public void SetMotor(Motor motor)
        {
            this.motor = motor;
        }

        /// <summary>
        /// Returneaza valoarea campului numarDeUsi
        /// </summary>
        /// <returns></returns>
        public int GetNumarDeUsi()
        {
            return numarDeUsi;
        }

        /// <summary>
        /// Atribuie o valoare int primita ca parametru campului numarDeUsi
        /// </summary>
        /// <param name="numarDeUsi"></param>
        public void SetNumarDeUsi(int numarDeUsi)
        {
            this.numarDeUsi = numarDeUsi;
        }

        /// <summary>
        /// Returneaza valoarea campului marca
        /// </summary>
        /// <returns></returns>
        public string GetMarca()
        {
            return marca;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului marca
        /// </summary>
        /// <param name="marca"></param>
        public void SetMarca(string marca)
        {
            this.marca = marca;
        }

        /// <summary>
        /// Returneaza valoarea campului model
        /// </summary>
        /// <returns></returns>
        public string GetModel()
        {
            return model;
        }

        /// <summary>
        /// Atribuie o valoare string primita ca parametru campului model
        /// </summary>
        /// <param name="model"></param>
        public void SetModel(string model)
        {
            this.model = model;
        }

        /// <summary>
        /// Returneaza valoarea campului anDeFabricatie
        /// </summary>
        /// <returns></returns>
        public int GetAnDeFabricatie()
        {
            return anDeFabricatie;
        }

        /// <summary>
        /// Atribuie o valoare int primita ca parametru campului anDeFabricatie
        /// </summary>
        /// <param name="anDeFabricatie"></param>
        public void SetAnDeFabricatie(int anDeFabricatie)
        {
            this.anDeFabricatie = anDeFabricatie;
        }

        /// <summary>
        /// Returneaza o forma printabila a campurilor obiectului.
        /// 
        /// Va returna descrierea completa a 
        /// autovehicolului sub forma unui sir de
        /// caractere
        /// “Marca, model, anDeFabricatie, 
        /// capacitate cilindrica, combustibil,
        /// putere motor, numar de usi
        /// 
        /// </summary>
        /// <returns></returns>
        public string GetDescription()
        {
            return $"{marca},{model},{anDeFabricatie},{motor.GetCapacitateCilindrica()},{motor.GetTipulCombustibilului()},{motor.GetPutere()},{numarDeUsi}";
        }
    }
}
