using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordOfTanks
{
    class Tank
    {
        public Tank(int ammo_, int armor_, int mobility_, string model_)
        {
           
            try
            {
                if (ammo_ > 100 || ammo_ < 0) throw new Exception("неадекватный уровень боекомплекта");
                if (armor_ > 100 || armor_ < 0) throw new Exception("неадекватный уровень брони");
                if (mobility_ > 100 || mobility < 0) throw new Exception("неадекватный уровень маневренности");

               
                ammo = ammo_;
                armor = armor_;
                mobility = mobility_;
                model = model_;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override string ToString()
        {
            return String.Format("{0,6}\t\t{1,2}\t\t{2,2}\t\t{3,2} ", model, armor, ammo, mobility);
        }

        public static Tank operator ^(Tank t1, Tank t2)
        {
            try
            {
                if (t1 == null || t2 == null) throw new ArgumentNullException("Передан пустой аргумент для сравнения");
                if (t1.ammo > t2.ammo)
                {
                    if (t1.armor > t2.armor) return t1;
                    else
                    {
                        if (t1.mobility > t2.mobility) return t1;
                        else return t2;
                    }
                }
                else
                {
                    if (t1.armor > t2.armor)
                    {
                        if (t1.mobility > t2.mobility) return t1;
                        else return t2;
                    }
                    else return t2;
                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public string Model
        {
            get { return model; }
        }
        private int ammo;
        private int armor;
        private int mobility;
        private string model;
    }
}
