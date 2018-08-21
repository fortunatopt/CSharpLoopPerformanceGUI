using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPerformanceGUI
{
    public static class LoopWork
    {
        public static List<Output> Do<T>(long iterator, string loopType, T obj = default(T))
        {

            List<Output> output = new List<Output>();

            List<T> rows = PopulateLoop<T>(iterator, obj);
            T[] rowsArray = PopulateArray<T>(iterator, obj);
            Stopwatch sw = new Stopwatch();

            sw.Start();
            IterateForeachOnList(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Foreach On List", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateForOnListWithoutCountOptimization(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} For On List Without Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateForOnListWithCountOptimization(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} For On List With Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForeachOnList(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel Foreach On List", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForOnListWithoutCountOptimization(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel For On List Without Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForOnListWithCountOptimization(rows);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel For On List With Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateForeachOnArray(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Foreach On Array", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateForOnArrayWithoutCountOptimization(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} For On Array Without Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateForOnArrayWithCountOptimization(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} For On Array With Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForeachOnArray(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel Foreach On Array", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForOnArrayWithoutCountOptimization(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel For On Array Without Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            sw = new Stopwatch();
            sw.Start();
            IterateParallelForOnArrayWithCountOptimization(rowsArray);
            sw.Stop();
            output.Add(new Output { Title = $"{loopType} Parallel For On Array With Count Optimization", Time = sw.ElapsedTicks.ToString("N0") });

            return output;
        }
        static List<T> PopulateLoop<T>(long rows, T obj)
        {
            List<T> objs = new List<T>();
            for (int i = 0; i < rows; i++)
                objs.Add(obj);
            return objs;
        }
        static T[] PopulateArray<T>(long rows, T obj)
        {
            List<T> objs = PopulateLoop(rows, obj);
            return objs.ToArray();
        }

        static void IterateForeachOnList<T>(List<T> list)
        {
            foreach (var i in list) { T j = i; }
        }
        static void IterateForOnListWithoutCountOptimization<T>(List<T> list)
        {
            for (var i = 0; i < list.Count; i++) { T j = list[i]; }
        }
        static void IterateForOnListWithCountOptimization<T>(List<T> list)
        {
            int count = list.Count;
            for (var i = 0; i < count; i++) { T j = list[i]; }
        }

        static void IterateForeachOnArray<T>(T[] array)
        {
            foreach (var i in array) { T j = i; }
        }
        static void IterateForOnArrayWithoutCountOptimization<T>(T[] array)
        {
            for (var i = 0; i < array.Length; i++) { T j = array[i]; }
        }
        static void IterateForOnArrayWithCountOptimization<T>(T[] array)
        {
            int length = array.Length;
            for (var i = 0; i < length; i++) { T j = array[i]; }
        }

        static void IterateParallelForeachOnList<T>(List<T> list)
        {
            Parallel.ForEach(list, i => { T j = i; });
        }
        static void IterateParallelForOnListWithoutCountOptimization<T>(List<T> list)
        {
            Parallel.For(0, list.Count(), i => { T j = list[i]; });
        }
        static void IterateParallelForOnListWithCountOptimization<T>(List<T> list)
        {
            int count = list.Count();
            Parallel.For(0, count, i => { T j = list[i]; });
        }

        static void IterateParallelForeachOnArray<T>(T[] array)
        {
            Parallel.ForEach(array, i => { T j = i; });
        }
        static void IterateParallelForOnArrayWithoutCountOptimization<T>(T[] array)
        {
            Parallel.For(0, array.Count(), i => { T j = array[i]; });
        }
        static void IterateParallelForOnArrayWithCountOptimization<T>(T[] array)
        {
            int count = array.Count();
            Parallel.For(0, count, i => { T j = array[i]; });
        }
    }
}
