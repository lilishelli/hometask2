using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBigInteger
{
    public class MyInt
    {
        //long num;
        byte[] num;
        bool isNeg = false;
        public MyInt(String n)
        {
            if(n[0]=='-')
            {
                isNeg = true;
                n=n.Substring(1);
            }
            num = new byte[n.Length];
            //char[] nc = n.ToArray();           
            for (int i = 0; i < n.Length; i++)
                num[i] = Convert.ToByte(n[i].ToString());
        }
        public MyInt(long num):this (num.ToString())
        {
            
        }
        public MyInt(byte[] num)
        {
            this.num = num;
        }
        public String ToString()
        {            
            String s="";
            if (isNeg)
                s += "-";
            for (int i = 0; i < num.Count(); i++)
                s += num[i].ToString();
            return s;
        }
        public byte[] ToArr()
        {
            return this.num;
        }
        public Int64 toLong()
        {
            Int64 n=Convert.ToInt64(this.ToString());
            return n;
        }
        public String abs()
        {
            if (isNeg)
                return this.ToString().Substring(1);
            else
                return this.ToString();
        }

        public MyInt add(MyInt b)
        {
            byte[] bb = b.ToArr();
            int size = this.ToArr().Count();
            if (bb.Count() > num.Count())
            {
                byte[] temp = bb;
                bb = num;
                num = temp;
            }
            size = num.Count();
            //MyInt res=new MyInt();            
            int redix = 10;
            int mem = 0;
            int dif = Math.Abs(bb.Count() - num.Count());
            for (int i = b.ToString().Length - 1; i >= 0; i--)
            {                
                num[i] = Convert.ToByte(num[i] + bb[i]+mem);
                mem = 0;
                if (num[i] >= redix)
                {
                    num[i] %= 10;
                    mem = 1;
                }
            }
            return this;
        }

        public MyInt subTrack(MyInt b)
        {
            byte[] res = new byte[b.ToString().Length + 1];
            byte[] bb = b.ToArr();
            for (int i = b.ToString().Length - 1; i >= 0; i--)
                this.ToArr()[i] = Convert.ToByte(this.ToArr()[i] - bb[i]);
            return this;
        }
    }
}
