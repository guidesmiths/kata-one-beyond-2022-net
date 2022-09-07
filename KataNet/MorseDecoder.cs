using BenchmarkDotNet.Attributes;

namespace KataNet;

[RankColumn]
public abstract class MorseDecoder
{
	public static string MisteryMessage => ".-- .... .- -   .... .- - ....   --. --- -..   .-- .-. --- ..- --. .... -";

	[Benchmark]
	public abstract string DecodeMisteryMessage();
}