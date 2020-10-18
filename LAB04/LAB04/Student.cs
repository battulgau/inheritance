using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Student : Person
    {

        private string _Code;
        private string _Mergejil;
        private double _Gpa;
        private int _Credit;

        public string Code {
            get { return _Code; }
            set { _Code = value; }
        }
        public string Mergejil
        {
            get { return _Mergejil; }
            set { _Mergejil = value; }
        }
        public double Gpa
        {
            get { return _Gpa; }
            set { _Gpa = value; }
        }
        public int Credit
        {
            get { return _Credit; }
            set { _Credit = value; }
        }

        public Student(string Register, string Ovog, string Ner, 
            int Nas, string Huis, string Code, 
            string Mergejil, double Gpa, 
            int Credit): base(Register, Ovog,Ner, Nas, 
                Huis)
        {
            this.Code = Code;
            this.Mergejil = Mergejil;
            this.Gpa = Gpa;
            this.Credit = Credit;
        }

        public string Oyutnii_medeelel_avah()
        {
            return base.Hunii_medeelel_avah() + 
                "\n!!! Oyutnii medeelel ni !!!" + 
                "\nOyutnii Code: " + Code + 
                "\nMergejil: " + Mergejil + 
                "\nGPA: " + Gpa + "\nCredit: " + 
                Credit;
        }
    }
}
