using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuralNetworks
{
    public class Neuron
    {
        public List<double> Weight { get; }
        public NeuronType NeuronType { get; }
        public double Output { get; private set; }

        public Neuron(int inputCount, NeuronType type = NeuronType.Normal)
        {
            NeuronType = type;
            Weight = new List<double>();

            for (int i = 0; i < inputCount; i++)
            {
                Weight.Add(1);
            }

        }

        public double FeedForward(List<double> inputs)
        {
            //Проверка входных данных
            var sum = 0.0;
            for (int i = 0; i < inputs.Count; i++)
            {
                sum += inputs[i] * Weight[i];
            }

            Output = Sigmoid(sum);
            return Output;
        }
        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Pow(Math.E, -x));
        }

        public override string ToString()
        {
            return Output.ToString(); 
        }

    }
}
