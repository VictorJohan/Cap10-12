using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cap10_12.Entidades.Capitulo10E
{
    public class Poligonos
    {
        //atributos
        private static float lado =0;
        private static float radio = 0;
        private static float anguloCentral = 0;
        private static float apotema = 0;
        private static float circunferenciaCircunscrita = 0;
        private static float circunferenciaInscrita = 0;

        //EJERCICIO 3
        //constructor
        public Poligonos(float _lado, float _radio, float _anguloCentral, float _apotema)
        {
            Lado = _lado;
            Radio = _radio;
            AnguloCentral = _anguloCentral;
            Apotema = _apotema;
        }

        //constructor sobrecargado
        public Poligonos(float _lado, float _radio, float _anguloCentral, float _apotema, float
            _circunferenciaCircunscrita, float _circunferenciaInscrita)
        {
            Lado = _lado;
            Radio = _radio;
            AnguloCentral = _anguloCentral;
            Apotema = _apotema;
            CircunferenciaCircunscrita = _circunferenciaCircunscrita;
            CircunferenciaInscrita = _circunferenciaInscrita;
        }

        // FIN EJERCICIO 3

        //EJERCICIO 4

        public float Lado
        {
            get
            {
                return lado;
            }
            set
            {
                string var = lado.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    lado = 0;
                lado = value;
            }
        }

        public float Radio
        {
            get
            {
                return radio;
            }
            set
            {
                string var = radio.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    radio = 0;
                radio = value;
            }
        }

        public float AnguloCentral
        {
            get
            {
                return anguloCentral;
            }
            set
            {
                string var = anguloCentral.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    anguloCentral = 0;
                anguloCentral = value;
            }
        }

        public float Apotema
        {
            get
            {
                return apotema;
            }
            set
            {
                string var = apotema.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    apotema = 0;
                apotema = value;
            }
        }

        public float CircunferenciaCircunscrita
        {
            get
            {
                return circunferenciaCircunscrita;
            }
            set
            {
                string var = circunferenciaCircunscrita.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    circunferenciaCircunscrita = 0;
                circunferenciaCircunscrita = value;
            }
        }

        public float CircunferenciaInscrita
        {
            get
            {
                return circunferenciaInscrita;
            }
            set
            {
                string var = circunferenciaInscrita.ToString();

                if (!Regex.IsMatch(var, "^[0-9]+$"))
                    circunferenciaInscrita = 0;
                circunferenciaInscrita = value;
            }
        }

        //FIN EJERCICIO 4


        //EJERCICIO 5

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendFormat($"Lados: {lado}\nRadio: {radio}\nAngulo Central {anguloCentral}\nApotema: {apotema}\n" +
                $"Circunferencia Circunscrita: {circunferenciaCircunscrita}\nCircunferencia Inscrita: {circunferenciaInscrita}");
            return (stringBuilder.ToString());
        }

        //FIN EJERCICIO 5
    }
}
