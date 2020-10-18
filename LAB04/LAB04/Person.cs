using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB04
{
    class Person
    {
        protected string _Register;
        protected string _Ovog;
        protected string _Ner;
        protected int _Nas;
        protected string _Huis;

        protected string Register {
            get { return _Register; }
            set { _Register = value; }
        }
        protected string Ovog
        {
            get { return _Ovog; }
            set { _Ovog = value; }
        }
        protected string Ner
        {
            get { return _Ner; }
            set { _Ner = value; }
        }
        protected int Nas
        {
            get { return _Nas; }
            set { _Nas = value; }
        }
        protected string Huis
        {
            get { return _Huis; }
            set { _Huis = value; }
        }

        public Person(string Register, String Ovog,string Ner, int Nas, string Huis)
        {
            this.Register = Register;
            this.Ovog = Ovog;
            this.Ner = Ner;
            this.Nas = Nas;
            this.Huis = Huis;
        }

        protected string Hunii_medeelel_avah()
        {
            return "!!! Huvi hunii medeelel ni !!!\nRegister: "
                + Register + "\nNer: " + fname() + "\nNas: " + Nas
                + "\nHuis: " + Huis + "\nTursun ognoo: "
                + bdate();
        }
        protected string bdate() {
            string ss = Register.Substring(2, 2) + 
                "." + Register.Substring(4, 2) + 
                "." + Register.Substring(6, 2);
            return ss;
        }

        protected string fname() {
            return Ovog.Substring(0, 1).ToUpper() +
                "." + Ner.Substring(0, 1).ToUpper() +
                Ner.Substring(1, Ner.Length - 1).ToLower();
        }
    }
}
