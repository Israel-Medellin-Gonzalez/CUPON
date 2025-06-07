using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CUPON
{
    internal class CUPONS
    {
        //atributos
        protected float tope_limite;
        protected float compra_minima;
        protected string cupon;
        protected float monto;
        protected float descuento;
        protected float total;

        //propiedades
        public float get_tope_limite() 
        {
            return tope_limite;
        }
        public float get_compra_minima()
        {
            return compra_minima;
        }
        public string CUPON
        {
            get { return cupon; }
            set { cupon = value; }
        }

        public float MONTO
        {
            get { return monto; }
            set { monto = value; }
        }
        public float DESCUENTO
        {
            get { return descuento; }
            set { descuento = value; }
        }
        public float TOTAL
        {
            get { return total; }
            set { total = value; }
        }

        //constructor
        public CUPONS()
        {
            tope_limite = 500;
            compra_minima = 2000;
            cupon = "";
            monto = 0;
            descuento = 0;
        }

        //metodos
        public float CALCULAR_DESCUENTO()
        {
            descuento = monto * 15 / 100;
            if (descuento > tope_limite)
            {
                descuento = tope_limite;
            }
            else
            {
                descuento = 0;
            }

            return descuento;
        }
        public float Calcular_TOTAL()
        {
            if (cupon == "MX15" && monto > compra_minima)
            {
                total = monto - descuento;
            }
            else
            {
                descuento = 0;
                total = monto - descuento;
            }
            return total;
        }
    }
}
