using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лб1
{
    class traffic
    {
        public string nazv_f;
        private double cost_1t;
        private int sumgr;
        private int[] weightcar = new int[5];
        //свойства для числовых полей

        public double Cost_1t
        {
            get
            {
                return cost_1t;
            }

            set
            {
                if (value < 0)
                    cost_1t = 1;
                else cost_1t = value;

            }
        }

        public int Sumgr
        {
            get
            {
                return sumgr;
            }

            set
            {
                if (value < 0)
                    sumgr = 0;
                else sumgr = value;
            }
        }
        public int[] Weightcar
        {
            get
            {
                return weightcar;
            }

            set
            {
                int i = 0;  // счетчик
                foreach (int m in value)    // цикл по всем элементам в value
                {
                    if (m < 0)
                        weightcar[i] = 0;
                    else
                    weightcar[i] = m;
                    i++;
                    if (i >= 5) break;  // если аргументов больше, чем надо
                }

            }
        }

        public traffic(): this("ФирмаЧ",0,0.0,0,0,0,0,0)
        {

        }
        public traffic(string nazv_f): this(nazv_f, 0,0.0,0,0,0,0,0)
        {

        }
        public traffic(string nazv_f,int sumgr,double cost_1t,params int[] weightcar)
        {
            this.nazv_f = nazv_f;
            Weightcar = weightcar;
            Cost_1t = cost_1t;
            Sumgr = sumgr;
        }
        public double procvir()
        {
            double c = sumgr * cost_1t;
            return c;
        }
        public bool padrent()
        {
            int sum=0;
            for (int i = 0; i < 5; i++)
                sum += weightcar[i];
            if (sum < sumgr * 0.4)
            {
                cost_1t = cost_1t * 0.85;
                return true;
            }

            else return false;
        }
        public bool rent(traffic tr3)
        {
            //sadas
            return cost_1t > tr3.cost_1t;
               
        }
        static public traffic sr3(traffic tr1,traffic tr2,traffic tr4)
        {
            if ((tr1.cost_1t > tr2.cost_1t)&&(tr1.cost_1t>tr4.cost_1t))
                return tr1;
            if (tr2.cost_1t > tr4.cost_1t)
                return tr2;
            return tr4;

        }
        public override string ToString()
        {
            return String.Format("Фирма {0} предлагает услуги по перевозке песка.\nМы предлагаем фуры, грузоподъемностью {1}, {2}, {3}, {4}, {5}.\nСтоимость перевозки 1 тонны всего {6}.\nЗакажи услуги у нас и получи суммарную массу перевезенных грузов в {7} в подарок!",nazv_f,weightcar[0], weightcar[1], weightcar[2], weightcar[3], weightcar[4],cost_1t,sumgr);
        }
    }
}
