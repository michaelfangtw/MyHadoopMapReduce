#MyHadoopMapReduce
##This is My HadoopMapReduce Sample
##I make a hadoop job sample of Math.Sqrt

#mkdir
hadoop fs -mkdir hdfs://localhost:9000/Input
hadoop fs -mkdir hdfs://localhost:9000/Input/sqrt
hadoop fs -mkdir hdfs://localhost:9000/Iutput

#list file via cmd
hadoop fs -ls hdfs://localhost:9000/Input/sqrt
hadoop fs -ls hdfs://localhost:9000/Output/sqrt
#list file via browser
#run a browser with url 
http://localhost:50070/explorer.html#/Output/sqrt

#run c# sample 
compile MyHadoopMapReduce

#result
hadoop fs -ls hdfs://localhost:9000/Output/sqrt

#Found 3 items
-rw-r--r--   1 fij supergroup          0 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/_SUCCESS
-rw-r--r--   1 fij supergroup         48 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/part-00000
-rw-r--r--   1 fij supergroup         10 2016-08-12 23:57 hdfs://localhost:9000/Output/sqrt/part-00001

#content of part-00000
9	3
45	6.70820393249937
6	2.44948974278318
36	6

#content of part-00001
49	7
81	9


hadoop fs -ls hdfs://localhost:9000/Input/sqrt
#Found 1 items
-rw-r--r--   1 fij supergroup         22 2016-08-12 23:41 hdfs://localhost:9000/Input/sqrt/input.txt

#content of input.txt
9
45
6
36
49
81
