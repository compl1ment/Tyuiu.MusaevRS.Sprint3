using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MusaevRS.Sprint3.Task3.V9.Lib
{
    public class DataSerivce : ISprint3Task3V9
    {
        public string ReplaceNumOnChar(string value, char item)
        {
            
            foreach (char ch in value)
            {
                if (char.IsDigit(ch))
                {
                    value = value.Replace(ch,item);
                }
            }
            return value;




        }
    }
}
