using BenchmarkDotNet.Attributes;

namespace Benchmarks;

[MinColumn, MaxColumn]
[MemoryDiagnoser]
public class Conditions
{

    private readonly int a = 5;
    private readonly int b = 10;
    enum testValues
    {
        first = 1,
        second,
        third,
        fourth,
        fifth,
        sixth,
        seventh,
        eighth,
        ninth,
        ten,
        eleven,
        twelve,
        thrteen,
        fourtheen,
        fiftheen,
        sixtheen,
        seventheen,
        egthteen,
        ninetheen,
        twenty

    }

    [Benchmark]
    public string IfEnumStatement()
    {
        var random = MersenneTwister.MT64Random.Create();
        int value = random.Next(10);
        string res;

        if (value == (int)testValues.first)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.second)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.third)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.fourth)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.fifth)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.sixth)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.seventh)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.eighth)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.ten)
        {
            res = testValues.first.ToString();
        }

        if (value == (int)testValues.eleven)
        {
            res = testValues.eleven.ToString();
        }

        if (value == (int)testValues.twelve)
        {
            res = testValues.twelve.ToString();
        }

        if (value == (int)testValues.thrteen)
        {
            res = testValues.thrteen.ToString();
        }

        if (value == (int)testValues.fourtheen)
        {
            res = testValues.fourtheen.ToString();
        }

        if (value == (int)testValues.fiftheen)
        {
            res = testValues.fiftheen.ToString();
        }

        if (value == (int)testValues.sixtheen)
        {
            res = testValues.sixtheen.ToString();
        }

        if (value == (int)testValues.seventheen)
        {
            res = testValues.seventheen.ToString();
        }

        if (value == (int)testValues.egthteen)
        {
            res = testValues.egthteen.ToString();
        }

        if (value == (int)testValues.twenty)
        {
            res = testValues.twenty.ToString();
        }
        return "none";
    }

    [Benchmark]
    public string ElseIfEnumStatement()
    {
        var random = MersenneTwister.MT64Random.Create();
        int value = random.Next(10);
        string res;

        if (value == (int)testValues.first)
        {
            res = testValues.first.ToString();
        }
        else if (value == (int)testValues.second)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.third)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.fourth)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.fifth)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.sixth)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.seventh)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.eighth)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.ten)
        {
            res = testValues.first.ToString();
        }

        else if (value == (int)testValues.eleven)
        {
            res = testValues.eleven.ToString();
        }

        else if (value == (int)testValues.twelve)
        {
            res = testValues.twelve.ToString();
        }

        else if (value == (int)testValues.thrteen)
        {
            res = testValues.thrteen.ToString();
        }

        else if (value == (int)testValues.fourtheen)
        {
            res = testValues.fourtheen.ToString();
        }

        else if (value == (int)testValues.fiftheen)
        {
            res = testValues.fiftheen.ToString();
        }

        else if (value == (int)testValues.sixtheen)
        {
            res = testValues.sixtheen.ToString();
        }

        else if (value == (int)testValues.seventheen)
        {
            res = testValues.seventheen.ToString();
        }

        else if (value == (int)testValues.egthteen)
        {
            res = testValues.egthteen.ToString();
        }

        else if (value == (int)testValues.twenty)
        {
            res = testValues.twenty.ToString();
        }

        return "none";
    }


    [Benchmark]
    public string SwitchEnumStatement()
    {
        var random = MersenneTwister.MT64Random.Create();
        int value = random.Next(10);
        string res = value switch
        {
            (int)testValues.first => testValues.first.ToString(),
            (int)testValues.second => testValues.second.ToString(),
            (int)testValues.third => testValues.third.ToString(),
            (int)testValues.fourth => testValues.fourth.ToString(),
            (int)testValues.fifth => testValues.fifth.ToString(),
            (int)testValues.sixth => testValues.sixth.ToString(),
            (int)testValues.seventh => testValues.seventh.ToString(),
            (int)testValues.eighth => testValues.eighth.ToString(),
            (int)testValues.ninth => testValues.ninth.ToString(),
            (int)testValues.ten => testValues.ten.ToString(),
            (int)testValues.eleven => testValues.eleven.ToString(),
            (int)testValues.twelve => testValues.twelve.ToString(),
            (int)testValues.thrteen => testValues.thrteen.ToString(),
            (int)testValues.fourtheen => testValues.fourtheen.ToString(),
            (int)testValues.fiftheen => testValues.fiftheen.ToString(),
            (int)testValues.sixtheen => testValues.sixtheen.ToString(),
            (int)testValues.seventheen => testValues.seventheen.ToString(),
            (int)testValues.egthteen => testValues.egthteen.ToString(),
            (int)testValues.ninetheen => testValues.ninetheen.ToString(),
            (int)testValues.twenty => testValues.twenty.ToString(),
            _ => "none"
        };
        return res;
    }

    [Benchmark]
    public string LinqEnumStatement()
    {
        var random = MersenneTwister.MT64Random.Create();
        int value = random.Next(10);

        return Enum.GetValues(typeof(testValues)).Cast<int>().Where(t => t == value).ToString()!;
    }

    [Benchmark]
    public string ArrayIndexEnumStatement()
    {
        var random = MersenneTwister.MT64Random.Create();
        int value = random.Next(10) + 1;

        return Enum.GetNames(typeof(testValues))[value - 1];
    }

    [Benchmark]
    public int GetBiggerIFStatement()
    {
        int res = 0;

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        if (a > b)
        {
            res = a;
        }
        else
        {
            res = b;
        }

        return res;
    }

    [Benchmark]
    public int GetBiggerTernaryStatement()
    {
        int res = 0;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        res = a > b ? a : b;

        return res;
    }

    [Benchmark]
    public int GetBiggerBranchlessStatement()
    {
        int res = 0;
        int diff = 0;
        int dsgn = 0;

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        diff = a - b;
        dsgn = diff >> 31;
        res = a - (diff & dsgn);

        return res;
    }
}

