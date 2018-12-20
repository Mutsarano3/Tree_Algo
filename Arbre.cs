using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbre
{
    public class Arbre:Liste_Chainée
    {
        public Liste_Chainée children = new Liste_Chainée(0); //Liste d'enfants
        public int data;

        public void SetData(Arbre tree,int data)
        {
            tree.data = data;
        }
        public int GetData(Arbre tree)
        {
            return tree.data;
        }
        public void AddChild(Arbre tree, Element child)
        {
            var elemnt = new Element(child.data);
            InsertLast(tree.children, elemnt);
            
            

        }
        public int  CounterChildren(Arbre tree)
        {
            return Compter(tree.children);       //Appel de la fonction compter
        }
        public bool isLeaf(Arbre tree)
        {
            return CounterChildren(tree) < 1;     //Si il n'a pas d'enfant alors cet une feuille

        }
        public void  RemoveChildren(Arbre tree)
        {
            tree.children = null;
        }
        public int GetChild(Arbre tree, int position)
        {
            var current = tree.children.Root;
            while(position > 0)
            {
                current = current.next;
                position--;
            }
            return current.data;
        }
        


    }
}
