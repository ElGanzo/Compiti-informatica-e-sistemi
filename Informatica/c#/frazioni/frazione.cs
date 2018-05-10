using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frazione
{
    // Classe frazione
    public class frazione
    {
        public int n, d;
        public string s;

        // Costruttore
        public frazione(int num = 0, int den = 1)
        {
            n = num;
            d = den;
        }

        // Metodi
        public void Set(int num = 0, int den = 1)
        {
            n = num;
            d = den;
            MinTerm();
        }

        public static frazione operator+(frazione f)
        {
            frazione app = new frazione();
            app.d = f.d * f2.d;
            app.n = f.n * f2.d + f.d * f2.n;
            app.MinTerm();
            return app;
        }

        public static frazione operator-(frazione f)
        {
            frazione app = new frazione();
            app.d = f.d * f2.d;
            app.n = f.n * f2.d - f.d * f2.n;
            app.MinTerm();
            return app;
        }

        public static frazione operator/(frazione f)
        {
            frazione app = new frazione();
            app.d = f.d * f2.d;
            app.n = (f.n * f2.d) / (f.d * f2.n);
            app.MinTerm();
            return app;
        }

        public static frazione operator*(frazione f)
        {
            frazione app = new frazione();
            app.d = f.d * f2.d;
            app.n = f.n * f2.d;
            app.MinTerm();
            return app;
        }

        // Minimo comun denominatore
        protected int mcd()
        {
            int nc = n;
            int dc = d;

            if( nc < 0 )
                nc = -nc;

            while( nc != dc )
            {
                if( nc > dc )
                    nc = nc- dc;
                else
                    dc = dc - nc;
            }
            return nc;
        }

        protected void MinTerm()
        {
            int dc = mcd();
            n = n / dc;
            d = d / dc;
        }
    }
}
