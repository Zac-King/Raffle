using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace InputWindow
{
    [Serializable]
    [XmlRoot("Raffle")]
    public class Raffle
    {
        private List<Candidate> _raff;

        [XmlArray("Candidates"), XmlArrayItem(typeof(Candidate), ElementName = "Candidate")]
        public List<Candidate> RaffleParticipants
        {
            get
            {
                return _raff;
            }
            set
            {
                _raff = value;
            }
        }
        
        public Raffle()
        {
            _raff = new List<Candidate>();
        }
        public void AddCandidate(Candidate c)
        {
            _raff.Add(c);
        }
        public void AddCandidate(string n, int num)
        {
            Candidate t = new Candidate(n, num);

            for (int i = 0; i < num; i++)
                _raff.Add(t);
        }

        public Candidate PickWinner()
        {
            Random r = new Random();

            if(RaffleParticipants != null)
            {
                int c = r.Next(0, RaffleParticipants.Count - 1);
                return RaffleParticipants[c];
            }
            return (new Candidate("Invalid", 0));
        }
    }



}
