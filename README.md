## MyHadoopMapReduce

This is My HadoopMapReduce Sample,I made a hadoop job sample of Math.Sqrt

## Code Example
<pre>
#mkdir
hadoop fs -mkdir hdfs://localhost:9000/Input
hadoop fs -mkdir hdfs://localhost:9000/Input/sqrt
hadoop fs -mkdir hdfs://localhost:9000/Iutput


#list file via cmd
hadoop fs -ls hdfs://localhost:9000/Input/sqrt
hadoop fs -ls hdfs://localhost:9000/Output/sqrt

##list file via browser,run a browser with url 
http://localhost:50070/explorer.html#/Output/sqrt

##run c# sample and build and run MyHadoopMapReduce


##input
hadoop fs -ls hdfs://localhost:9000/Input/sqrt
-rw-r--r--   1 fij supergroup         22 2016-08-12 23:41 hdfs://localhost:9000/Input/sqrt/input.txt

#content of input.txt
9
45
6
36
49
81

##output result
[dos]
hadoop fs -ls hdfs://localhost:9000/Output/sqrt
Found 3 items
-rw-r--r--   1 fij supergroup          0 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/_SUCCESS
-rw-r--r--   1 fij supergroup         48 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/part-00000
-rw-r--r--   1 fij supergroup         10 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/part-00001
[/dos]
#content of part-00000
9	3
45	6.70820393249937
6	2.44948974278318
36	6

#content of part-00001
49	7
81	9
</pre>


## Motivation
To Test Hadoop Distributed File System (HDFS)

## Installation
1.install hadoop on windows
   https://www.iwwenbo.com/hadoop-installation-on-windows-without-cygwin/
2.install Visual Studio 2015
3.install Nuget Package: MapReduce
  PM>Install-Package Microsoft.Hadoop.MapReduce

## Reference:Intro to Hadoop MapReduce with C#
https://www.youtube.com/watch?v=uyi41nrhlhw

## Tests


## Contributors

MichaelFang 

## License
MIT 
<hr>

