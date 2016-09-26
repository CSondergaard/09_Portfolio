using System;
using System.Collections.Generic;

namespace _09_Portfolio
{
    internal class Portfolio
    {
        List<IAsset> assetlist = new List<IAsset>();
        public Portfolio()
        {
            assetlist = new List<IAsset>();
        }

        public Portfolio(List<IAsset> list)
        {
            assetlist = list;
        }
        public void AddAsset(IAsset item)
        {
            assetlist.Add(item);
        }

        public double GetTotalValue()
        {
            double value = 0;
            foreach (IAsset item in assetlist)
            {
                value += item.GetValue();
            }
            return value;
        }
    }
}