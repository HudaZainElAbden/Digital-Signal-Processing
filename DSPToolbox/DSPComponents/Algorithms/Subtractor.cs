﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DSPAlgorithms.DataStructures;

namespace DSPAlgorithms.Algorithms
{
    public class Subtractor : Algorithm
    {
        public Signal InputSignal1 { get; set; }
        public Signal InputSignal2 { get; set; }
        public Signal OutputSignal { get; set; }

        /// <summary>
        /// To do: Subtract Signal2 from Signal1 
        /// i.e OutSig = Sig1 - Sig2 
        /// </summary>
        public override void Run()
        {
            if (InputSignal1.Samples.Count > InputSignal2.Samples.Count)
            {
                for (int i = InputSignal1.Samples.Count; i < InputSignal2.Samples.Count; i++)
                {
                    InputSignal1.Samples.Add(0);
                }
            }
            else
            {
                for (int i = InputSignal2.Samples.Count; i < InputSignal1.Samples.Count; i++)
                {
                    InputSignal2.Samples.Add(0);
                }
            }

            List<float> subSamples = new List<float>();

            for (int i = 0; i < InputSignal1.Samples.Count; i++)
            {
                subSamples.Add(InputSignal1.Samples[i] - InputSignal2.Samples[i]);
            }

            OutputSignal = new Signal(subSamples, false);
        }
    }
}