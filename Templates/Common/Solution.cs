using System;
using System.IO;
using System.Linq;

namespace DNNX.GoogleCodeJam.Common
{
    public abstract class Solution<TTestCase>
    {
        private readonly TextReader _input;
        private readonly TextWriter _output;
        
        protected Solution() : this(Console.In, Console.Out)
        {
        }

        protected Solution(TextReader input, TextWriter output)
        {
            _input = input;
            _output = output;
        }
        
        protected string ReadString()
        {
            return _input.ReadLine().Trim();
        }
        
        protected int ReadInt()
        {
            return int.Parse(ReadString());
        }

        protected int[] ReadInts()
        {
            return ReadString().Split(' ').Select(int.Parse).ToArray();
        }
        
        public abstract TTestCase ReadTestCase();
        
        public abstract object Solve(TTestCase testCase);
        
        /// <summary>
        /// Read-eval-print loop
        /// http://en.wikipedia.org/wiki/REPL
        /// </summary>
        public void REPL()
        {
            int numberOfTests = ReadInt();
            var tests = new TTestCase[numberOfTests];
            for (int i=0; i<numberOfTests; ++i)
            {
                tests[i] = ReadTestCase();
            }
            
            var answers = tests
                        .AsParallel()
                        .Select(Solve)
                        .ToArray();
            
            for (int i=0; i<numberOfTests; ++i)
            {
                _output.WriteLine("Case #{0}: {1}", i+1, answers[i]);
            }
        }
    }
    
    public abstract class Solution<T1, T2> : Solution<Tuple<T1, T2>>
    {
        public override object Solve(Tuple<T1, T2> testCase)
        {
            return Solve(testCase.Item1, testCase.Item2);
        }
        
        public abstract object Solve(T1 arg1, T2 arg2);
    }
}