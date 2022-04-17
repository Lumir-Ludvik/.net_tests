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
        string res;
        switch (value)
        {
            case (int)testValues.first:
                res = testValues.first.ToString();
                break;
            case (int)testValues.second:
                res = testValues.second.ToString();
                break;

            case (int)testValues.third:
                res = testValues.third.ToString();
                break;

            case (int)testValues.fourth:
                res = testValues.fourth.ToString();
                break;

            case (int)testValues.fifth:
                res = testValues.fifth.ToString();
                break;

            case (int)testValues.sixth:
                res = testValues.sixth.ToString();
                break;

            case (int)testValues.seventh:
                res = testValues.seventh.ToString();
                break;

            case (int)testValues.eighth:
                res = testValues.eighth.ToString();
                break;

            case (int)testValues.ninth:
                res = testValues.ninth.ToString();
                break;

            case (int)testValues.ten:
                res = testValues.ten.ToString();
                break;

            case (int)testValues.eleven:
                res = testValues.eleven.ToString();
                break;
            case (int)testValues.twelve:
                res = testValues.twelve.ToString();
                break;

            case (int)testValues.thrteen:
                res = testValues.thrteen.ToString();
                break;

            case (int)testValues.fourtheen:
                res = testValues.fourtheen.ToString();
                break;

            case (int)testValues.fiftheen:
                res = testValues.fiftheen.ToString();
                break;

            case (int)testValues.sixtheen:
                res = testValues.sixtheen.ToString();
                break;

            case (int)testValues.seventheen:
                res = testValues.seventheen.ToString();
                break;

            case (int)testValues.egthteen:
                res = testValues.egthteen.ToString();
                break;

            case (int)testValues.ninetheen:
                res = testValues.ninetheen.ToString();
                break;

            case (int)testValues.twenty:
                res = testValues.twenty.ToString();
                break;

            default:
                res = "none";
                break;
        }
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

