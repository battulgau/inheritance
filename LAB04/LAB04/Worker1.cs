using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Worker1: Person
    {
        private string _AjliinGazar;
        private string _AlbanTushaal;
        private string _AjiltniiCode;
        private int _AjliinUtas;

        public string AjliinGazar
        {
            get { return _AjliinGazar; }
            set { _AjliinGazar = value; }
        }
        public string AlbanTushaal
        {
            get { return _AlbanTushaal; }
            set { _AlbanTushaal = value; }
        }
        public string AjiltniiCode
        {
            get { return _AjiltniiCode; }
            set { _AjiltniiCode = value; }
        }
        public int AjliinUtas
        {
            get { return _AjliinUtas; }
            set { _AjliinUtas = value; }
        }

        public Worker1(string Register, string Ovog, string Ner,
            int Nas, string Huis, string AjliinGazar,
            string AlbanTushaal, string AjiltniiCode,
            int AjliinUtas) : base(Register, Ovog,Ner, Nas,
                Huis)
        {
            this.AjliinGazar = AjliinGazar;
            this.AlbanTushaal = AlbanTushaal;
            this.AjiltniiCode = AjiltniiCode;
            this.AjliinUtas = AjliinUtas;
        }

        public string Oyutnii_medeelel_avah()
        {
            return base.Hunii_medeelel_avah() +
                "\n!!! Oyutnii medeelel ni !!!" +
                "\nOyutnii AjliinGazar: " + AjliinGazar +
                "\nAlbanTushaal: " + AlbanTushaal +
                "\nAjiltniiCode: " + AjiltniiCode + "\nAjliinUtas: " +
                AjliinUtas;
        }
    }
}
