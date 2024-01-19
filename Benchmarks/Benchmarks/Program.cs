// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Benchmarks;

//BenchmarkRunner.Run<Strings>();
//BenchmarkRunner.Run<Splits>();
//BenchmarkRunner.Run<Increments>();
BenchmarkRunner.Run<Cycle>();
//BenchmarkRunner.Run<BenchProperties>();
//BenchmarkRunner.Run<Conditions>();
Console.ReadLine();