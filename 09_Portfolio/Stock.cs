using System;

namespace _09_Portfolio
{
    interface IAsset
    {
        double GetValue();
    }

    internal class Stock : IAsset
    {

        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
        public int NumShares { get; set; }

        public Stock()
        {

        }
        public Stock(string s, double price, int shares)
        {
            Symbol = s;
            PricePerShare = price;
            NumShares = shares;
        }

        public override string ToString()
        {
            return "Stock[symbol=" + Symbol + ",pricePerShare=" + PricePerShare.ToString().Replace(',', '.') + ",numShares=" + NumShares + "]";
        }

        public override bool Equals(object obj)
        {
            if (ToString() != obj.ToString())
            {
                return false;
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public double GetValue()
        {
            double i = NumShares * PricePerShare;
            return i;
        }

    
        public static double TotalValue(IAsset[] sar)
        {
            double value = 0;
            foreach (var item in sar)
            {
                value = value + item.GetValue();
            }
            return value;
        }


    } // Stock end

    internal class SavingsAccount : IAsset
    {
        public string AccountName { get; set; }
        public double value { get; set; }
        public double InterestRate { get; set; }
        public SavingsAccount(string s, double i, double d)
        {
            AccountName = s;
            value = i;
            InterestRate = d;
        }

        public void ApplyInterest()
        {
            double rate = value * (InterestRate / 100);
            value = value + rate;
            
            
        }

        public double GetValue()
        {
            return value;
        }

        public override string ToString()
        {
            return "SavingsAccount[value=" + value + ".0,interestRate=" + InterestRate.ToString().Replace(',', '.') + "]";
        }       

    }
}