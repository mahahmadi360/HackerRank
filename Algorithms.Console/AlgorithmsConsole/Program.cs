﻿// See https://aka.ms/new-console-template for more information
using Algorithms.Benchmark;
using BenchmarkDotNet.Running;

var summary = BenchmarkRunner.Run<ClimbingTheLeaderboardBenchmark>();
