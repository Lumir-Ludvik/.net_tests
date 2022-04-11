// See https://aka.ms/new-console-template for more information

using BenchmarkDotNet.Running;
using Benchmarks;

//Strings strings = new();
//Console.WriteLine(strings.Span("AA472Aabce035aafs-sfsd724afa:fsss0172a$$asfd542 fsdf asfe _ -.___.---.!aeěš&@{0};"));
//BenchmarkRunner.Run<Strings>();
BenchmarkRunner.Run<Splits>();

Console.ReadLine();