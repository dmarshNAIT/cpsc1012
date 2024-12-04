using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic8_Olympics
{
    internal class Record
    {
        private string _sportName;
        private int _year;
        private string _athleteName;
        private float _score; // assume scores 0-10
        private bool _active = true;

        public string SportName
        {
            get { return _sportName; }
            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new Exception("Must provide name.");
                }
                else
                {
                    _sportName = value.Trim();
                }
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                if (value < 1896)
                { throw new Exception("The Olympics started in 1896 so that's impossible."); }
                else if (value > 2024) // ASPIRATIONAL TODO: unhardcode the year
                { throw new Exception("No time travellers allowed."); }
                else { _year = value; }
            }
        }

        public string AthleteName
        {
            get { return _athleteName; }
            set
            {
                if (String.IsNullOrEmpty(value.Trim()))
                {
                    throw new Exception("Must provide name.");
                }
                else 
                {
                    _athleteName = value.Trim();
                }
            }
        }

        public float Score
        {
            get { return _score; }
            set
            {
                if (value < 0) { throw new Exception("Score cannot be negative."); }
                else if (value > 10) { throw new Exception("Maximum score of 10."); }
                else { _score = value; }
            }
        }

        public bool Active { 
            get { return _active; }
            set { _active = value; }
        }

        public Record() { }

        public Record(string sportName, int year, string athleteName, float score, bool activeStatus)
        {
            SportName = sportName;
            Year = year;   
            AthleteName = athleteName;
            Score = score;
            Active = activeStatus;
        }
    }
}
// ASPIRATIONAL TODO: Add Country as a field and validate against a list of countries (with assumptions made)
