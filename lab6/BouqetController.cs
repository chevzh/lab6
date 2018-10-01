using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class BouqetController
    {
        Bouqet _bouqet;

        public BouqetController(Bouqet bouqet)
        {
            _bouqet = bouqet;
        }
                
        public enum Comand
        {
            FindByColor,
            SortByParam
        }

        public Bouqet ExecuteCommand(Comand command, string param)
        {
            Bouqet b = new Bouqet();

            switch (command)
            {
                case Comand.FindByColor:
                    b = FindByColor(param);
                    return b;

                case Comand.SortByParam:
                    SortByName();
                    break;
            }

            return b;
        }

        private Bouqet FindByColor(string color)
        {
            Bouqet b = new Bouqet();
            foreach(var flower in _bouqet)
            {
                if(flower.Color == color)
                {
                    b.Add(flower);
                }
            }
            return b;
        }

        private void SortByName()
        {
            _bouqet.Sort();
        }

        public int TotalPrice()
        {
            int price = new int();
            foreach(var flower in _bouqet)
            {
                price += flower.Price;                
            }

            return price;
        }

    }
}
