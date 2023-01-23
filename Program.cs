using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.InteropServices;

namespace ExemplesCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Livre l0 = new Livre() { Réf = 0, Titre="Programmation C#", Auteur="O.Chamseddine", Genre="Programmation", MaisonEdition="Orelly" };
            Livre l1 = new Livre() { Réf = 1, Titre = "Programmation HTML5 CSS3 et JacaScript", Auteur = "O.Chamseddine", Genre = "Programmation web", MaisonEdition = "Eyrolles" };
            Livre l2 = new Livre() { Réf = 2, Titre = "Le Framework .Net 4.6", Auteur = "O.Chamseddine", Genre = "Programmation", MaisonEdition = "Vuibert" };
            Livre l3 = new Livre() { Réf = 3, Titre = "Algorithmique", Auteur = "O.Chamseddine", Genre = "Programmation", MaisonEdition = "First" };
            Livre l4 = new Livre() { Réf = 4, Titre = "ASP.Net", Auteur = "O.Chamseddine", Genre = "Programmation web", MaisonEdition = "Ellipses" };

            #region Tableau
            //Livre[] tableauLivres = new Livre[5];
            //tableauLivres[0] = l0;
            //tableauLivres[1] = l1;
            //tableauLivres[2] = l2;
            //tableauLivres[3] = l3;
            //tableauLivres[4] = l4;

            //foreach (var item in tableauLivres)
            //{
            //    Console.WriteLine("{0}", item.Titre);
            //} 
            #endregion
            #region ArrayList
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(l0);
            //arrayList.Add(l1);
            //arrayList.Add(l2);
            //arrayList.Add(l3);
            //arrayList.Add(l4);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine("{0}", ((Livre)item).Titre);

            //}
            //Console.WriteLine("Le nombre d'objets est " + arrayList.Count);
            //Console.WriteLine("La capacite de ma collection est " + arrayList.Capacity); 
            #endregion

            #region Queue
            //Queue file = new Queue();
            //file.Enqueue(l0);
            //file.Enqueue(l1);
            //file.Enqueue(l2);
            //file.Enqueue(l3);
            //file.Enqueue(l4);

            //foreach (var item in file)
            //{
            //    Console.WriteLine("{0}", ((Livre)item).Titre);
            //} 
            #endregion

            #region Stack
            //Stack pile = new Stack();
            //pile.Push(l0);
            //pile.Push(l1);
            //pile.Push(l2);
            //pile.Push(l3);
            //pile.Push(l4);

            //foreach (var item in pile)
            //{
            //    Console.WriteLine("{0}", ((Livre)item).Titre);
            //}
            #endregion

            StringCollection collectionchaine = new StringCollection();
            //collectionchaine.Add("Lundi");
            //collectionchaine.Add("Mardi");
            //collectionchaine.Add("Mercredi");
            //collectionchaine.Add("Jeudi");
            //collectionchaine.Add("Vendredi");
            //collectionchaine.Add("Samedi");
            //collectionchaine.Add("Dimanche");

            string[] tab = new string[] { "lundi", "Mardi", "mercredi", "jeudi", "vendredi", "samedi", "diamche" };
            collectionchaine.AddRange(tab);
            
            foreach (string s in collectionchaine)
            {
                Console.WriteLine(s);
            }

            // Instruction pour retenir la fenêtre console
            Console.ReadLine();
        }
    }
}






