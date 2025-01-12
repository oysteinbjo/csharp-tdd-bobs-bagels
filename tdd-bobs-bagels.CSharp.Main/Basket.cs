﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_bobs_bagels.CSharp.Main
{
    public class Basket
    {
        private List<Bagel> _bagels = [];
        private int _basketSize;

        public Basket(int basketSize) 
        {
            _basketSize = basketSize;
        }

        public void AddToBasket(Bagel bagel)
        {
            if (BasketSize == 0)
            {
                throw new ArgumentException("No more room in basket");
            }
            Bagels.Add(bagel);
            BasketSize -= 1;
            
        }

        public void RemoveFromBasket(Bagel bagel)
        {
            if (!Bagels.Exists(b => b.Equals(bagel)))
            {
                throw new ArgumentException("No bagel here matches that request");
            }
            Bagels.Remove(bagel);
            BasketSize += 1;
        }
        
        public void ExpandBasket(int expansion)
        {
            BasketSize += expansion;
        }
                
        public List<Bagel> Bagels { get { return _bagels; } set { _bagels = value; } }
        public int BasketSize { get { return _basketSize; } set { _basketSize = value; } }
    }
}
