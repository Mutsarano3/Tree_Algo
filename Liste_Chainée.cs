using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbre
{
      class Liste_Chainée:Element
    {
        public Liste_Chainée Root;
        public int data;
        public Liste_Chainée(int value):base(value)
        {
            Root = null;
            data = value;

        }
        public void InsertLast(Liste_Chainée Liste, Element element)
        {
            if(Liste.Root == null)
            {
                Liste.Root.data = element.data;
                
            }
            else
            {
                var current = Liste.Root;
                while(current.next != null)
                {
                    current = current.next;
                }
                current.next = element;
            }

        }
        public int Compter(Liste_Chainée liste)
        {
            int compteur = 0;
            Liste_Chainée current = liste.Root;
            while (current != null)
            {
                current = current.next;
                compteur++;
            }
            return compteur;
        }

    }
}
