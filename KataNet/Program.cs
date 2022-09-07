using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Order;
using BenchmarkDotNet.Running;
using KataNet;
using System.Reflection;

Console.WriteLine("Initializing...");

var types = Assembly.GetExecutingAssembly()
					.GetTypes()
					.Where(x => x.IsSubclassOf(typeof(MorseDecoder)))
					.ToArray();

var instances = types.Select(x => (MorseDecoder)Activator.CreateInstance(x)!)
					 .ToArray();

var config = ManualConfig.Create(DefaultConfig.Instance)
						 .WithOrderer(new DefaultOrderer(SummaryOrderPolicy.FastestToSlowest))
						 .WithOptions(ConfigOptions.JoinSummary | ConfigOptions.DisableLogFile);

var benchmarks = types.Select(x => BenchmarkConverter.TypeToBenchmarks(x, config))
					  .ToArray();

BenchmarkRunner.Run(benchmarks);

Console.WriteLine("\r\nDecoders results:");
foreach (var decoder in instances)
	Console.WriteLine($"{decoder.GetType().Name} => {decoder.DecodeMisteryMessage()}");