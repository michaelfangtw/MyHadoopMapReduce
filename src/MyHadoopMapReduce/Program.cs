using Microsoft.Hadoop.MapReduce;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyHadoopMapReduce
{
    public class SqrtMapper : MapperBase
    {
        public override void Map(string inputLine, MapperContext context)
        {
            int inputValue = int.Parse(inputLine);
            //perform the work
            double sqrt = Math.Sqrt(inputValue);
            //Write output 
            context.EmitKeyValue(inputValue.ToString(), sqrt.ToString());
        }
    }

    public class SqrtJob : HadoopJob<SqrtMapper>
    {
        public override HadoopJobConfiguration Configure(ExecutorContext context)
        {
            HadoopJobConfiguration config = new HadoopJobConfiguration();
            config.InputPath = "hdfs://localhost:9000/Input/sqrt";
            config.OutputFolder = "hdfs://localhost:9000/Output/sqrt/result";
            return config;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            var hadoop = Hadoop.Connect();
            var result = hadoop.MapReduceJob.ExecuteJob<SqrtJob>();

        }
    }
}
