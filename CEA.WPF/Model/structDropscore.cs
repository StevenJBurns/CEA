using System;
using System.Collections.Generic;
using System.Text;

namespace CEA.Model
    {
    public enum ScoreResult
        {
        NoDrop,
        ScoredSAT,
        ScoredUNSAT,
        Scored,
        ScoredPI        
        }
    public enum DropType
        {
        HeavyEquipment = 1,
        Personnel,
        MFF,
        CDS,
        HVCDS,
        SATBH,
        SATBP,
        SATBC,
        CRRC,
        HSLLADS
        }
    public enum NoDropCode
        {

        }


    public struct DropScore
        {
        private ScoreResult res;
        private int rawrange;
        private int rawclock;
        private bool cancorrect;
        private bool iscorrected;

        public ScoreResult Result
            {
            get{return res;}
            set{res = value;}
            }            
        
        public int Range
            {
            get { return rawrange; }
            set { rawrange = value; }
            }

        public int Clock
            {
            get { return rawclock; }
            set { rawclock = value; }
            }

        private bool DeterminePI()
            {            
            if (rawrange < 36  && rawrange > 0)
                return true;
            else
                return false;
            }

        public bool CanCorrect
            {
            get { return cancorrect; }
            set { cancorrect = value; }
            }

        public bool IsCorrected
            {
            get { return iscorrected; }
            set { iscorrected = value; }
            }
        

        public DropScore(int range, int clock)
            {
            this.res = ScoreResult.Scored;
            this.rawrange = range;
            this.rawclock = clock;
            this.cancorrect = false;
            this.iscorrected = false;
            }

        public DropScore(ScoreResult r)
            {
            res = r;
            
            switch (r)
                {
                case ScoreResult.NoDrop:
                    this.rawrange = 0;
                    this.rawclock = 0;
                    break;
                case ScoreResult.Scored:
                    this.rawrange = 36;
                    this.rawclock = 12;
                    break;
                case ScoreResult.ScoredPI:
                    this.rawrange = 1;
                    this.rawclock = 12;
                    break;
                case ScoreResult.ScoredSAT:
                    this.rawrange = 0;
                    this.rawclock = 0;
                    break;
                case ScoreResult.ScoredUNSAT:
                    this.rawrange = 0;
                    this.rawclock = 0;
                    break;
                default:
                    this.rawrange = 0;
                    this.rawclock = 0;
                    break;
                }

            this.cancorrect = false;
            this.iscorrected = false;
            }

        public DropScore CorrectDropscore(DropScore leaderscore)
            {
            DropScore correctedscore = new DropScore();



            return correctedscore;
            }
        
        public override string ToString()
            {
            return Range.ToString() + "@" + Clock.ToString();
            }
        
        }
    
    }