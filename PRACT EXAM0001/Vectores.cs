using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACT_EXAM0001
{
    internal class Vectores
    {
        int n;
        int[] v;
        int MAX = 100;

        public Vectores()
        {
            n = 0;
            v = new int[MAX];
        }

        public void cargar(int dato, int a, int b)
        {
            n = dato;
            Random r = new Random();
            int i;
            for (i = 1; i <= n; i++)
            {
                v[i] = r.Next(a, b + 1);
            }
        }

        public string Descargar()
        {
            string s = "";
            int i;
            for (i = 1; i <= n; i++)
            {
                s = s + "| " + v[i];
            }
            return s;
        }

        //Dependencias
        public void Push(int dato)
        {
            n++;
            v[n] = dato;
        }

        public bool VerifPrimo(int num)
        {
            int c, i;
            c = 0;
            for (i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    c++;
                }
            }
            return c == 2;
        }

        public void BurbujaAsc()
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    if (v[i] > v[j])// la  condicion determina  lo que va al final
                    {
                        int aux = v[i];
                        v[i] = v[j];
                        v[j] = aux;

                    }
                }
            }
        }

        public void Purgar()
        {
            int i, j, k;
            for (i = 1; i <= n; i++)
            {
                j = i + 1;
                while (j <= n)
                {
                    if (v[i] == v[j])
                    {
                        for (k = j; k <= n - 1; k++)
                        {
                            v[k] = v[k + 1];
                        }
                        n--;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }

        private int frec(int ele)
        {
            int c = 0;
            for (int i = 0; i <= n; i++)
            {
                if (v[i] == ele)
                {
                    c++;
                }
            }
            return c;
        }

        //1
        public void ElimPrim()
        {
            for (int i = 1; i <= n; i++)
            {
                if (VerifPrimo(v[i]))
                {
                    for (int j = i; j <= n - 1; j++)
                    {
                        v[j] = v[j + 1];
                    }
                    n--;
                    i--;
                }

            }
        }

        //2
        public void EleyFrec(Vectores v2, Vectores v3)
        {
            v2.n = 0;
            v3.n = 0;

            for (int i = 0; i <= n; i++)
            {
                if (VerifPrimo(v[i]))
                {
                    v2.Push(v[i]);
                }
            }

            v2.BurbujaAsc();
            v2.Purgar();

            for (int i = 1; i <= v2.n; i++)
            {
                int f = frec(v2.v[i]);
                v3.Push(f);
            }
        }

        
    }
}
