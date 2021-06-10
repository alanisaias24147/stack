using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace stackNotas
{
    class stackNotas
    {
        List <string> notas = new List <string> ();

            public void push(string nota)
            {
                   this.notas.Add(nota);
            }
           
            public string pop()
            {
                  string value = this.notas[this.notas.Count - 1];
                   this.notas.RemoveAt(this.notas.Count - 1);
                   return value;
            }

            public string peek()
            {
                   return this.notas[this.notas.Count - 1];
            }

            
            public void printstack()
            {

                for (int i = this.notas.Count - 1; i > = 0; i--)
                {
                    Console.WriteLine(notas[i]);
                }

            }
    }
}
