using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Media;

namespace Pull_the_Trigger
{
    public class TimerManager
    {
        //times in seconds
        private int MinTime, MaxTime, Setup;
        
        //time in milliseconds
        
        public int ChosenTime;
        private int RemainingTime;
        private int RemainingSetup;
        private string ChosenOption;
        private int CallTime;
        private int CallTimeRemaining;
        private List<string> Options;
        private List<int> Weights;
        private Boolean Called;


        private Random rng;

        private void playSound(string fileName)
        {
            UnmanagedMemoryStream ums = Properties.Resources.ResourceManager.GetStream(fileName);
            SoundPlayer player = new SoundPlayer(ums);
            player.Play();
        }
        public void callTime(int time)
        {
            string timeToString = time.ToString();
            if (time < 10)
            {
                timeToString = "_0" + timeToString;
            }
            else
            {
                timeToString = "_" + timeToString;
            }
            playSound(timeToString);
        }
        public TimerManager(int min, int max, int setup, List<string> options, List<int> weights, int timeCall = -1)
        {
            
            rng = new Random((int)DateTime.Now.ToBinary());
            MinTime = min;
            MaxTime = max;
            Setup = setup*1000;
            Options = options;
            Weights = weights;
            CallTime = timeCall;
            
            Reset();
        }

        public int Reset()
        {
            
            ChosenTime = rng.Next(MinTime, MaxTime + 1) * 1000;
            if (CallTime != -1)
            {
                CallTimeRemaining = CallTime;
            }
            RemainingSetup = Setup;
            RemainingTime = ChosenTime;
            //pick an option
            ChosenOption = Options[rollOption(Options, Weights)];
            Called = false;
            return ChosenTime;
        }

        public int rollOption(List<string> options, List<int> weights)
        {
            int OptionSize = options.Count;
            int TotalWeight = weights.Sum();
            List<int> weightClone = weights.ToList<int>();
            int roll = rng.Next(0, TotalWeight);
            for (int i = 1; i < weightClone.Count; i++)
            {
                weightClone[i] += weightClone[i - 1];
            }
            for (int i = 0; i < weightClone.Count; i++)
            {
                if (roll < weightClone[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void DecrementTime(int milliseconds = 1)
        {
            if (RemainingSetup > 0)
            {
                RemainingSetup -= milliseconds;
                if (RemainingSetup <= 0)
                {
                    playSound("Set");
                }
                return;
            }
            else if (RemainingTime > 0 || CallTime > 0)
            {
                RemainingTime -= milliseconds;

                if (RemainingTime <= 0)
                {
                    //play option sound
                    if (!Called)
                    {
                        playSound(ChosenOption);
                        Called = true;
                    }
                    

                    //start it over if not waiting to call time
                    if (CallTimeRemaining > 0)
                    {
                        CallTimeRemaining -= milliseconds;
                        if (CallTimeRemaining <= 0)
                        {
                            callTime(ChosenTime / 1000);
                            Reset();
                        }
                    }
                    else
                    {
                        Reset();
                    }
                }
                    
            }
            
                
            
            
        }
    }
}
