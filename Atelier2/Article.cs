using System;
using System.Collections.Generic;
using System.Text;

namespace Atelier2
{
   
    class Article
    {

        public int _NumberRef { get;  private set; }
        public String _Name { get; private set; }
        public decimal _PrixAchat { get;  private set; }
        public decimal _PrixVente { get; private set; }

        public Article()
        {

        }

        //Class constructor, with an Exception for when the Buy prix is higher than the Sale Price
        public Article(int NumRef, String Name, decimal PrixAchat, decimal PrixVente)
        {
            if (PrixAchat > PrixVente)
                throw new ArgumentException("Prix achat est plus grand que prix de vente");
            this._NumberRef = NumRef;
            this._Name = Name;
            this._PrixAchat = PrixAchat;
            this._PrixVente = PrixVente;
        }
    }
}
