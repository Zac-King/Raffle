using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InputWindow
{
    [Serializable]
    public class Candidate
    {
        public string Name;
        public int NumOfEntries;
        public Candidate() { }
        public Candidate(string n, int e)
        {
            Name = n;
            NumOfEntries = e;
        }
    }
}