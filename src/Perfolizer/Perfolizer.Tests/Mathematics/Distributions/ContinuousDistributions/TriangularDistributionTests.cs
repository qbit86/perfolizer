using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Perfolizer.Mathematics.Distributions.ContinuousDistributions;
using Perfolizer.Tests.Common;
using Xunit;
using Xunit.Abstractions;
using static System.Math;

namespace Perfolizer.Tests.Mathematics.Distributions.ContinuousDistributions
{
    public class TriangularDistributionTests : DistributionTestsBase
    {
        public TriangularDistributionTests(ITestOutputHelper output) : base(output)
        {
        }

        private static readonly List<TestData> TestDataList = new()
        {
            new TestData(
                new TriangularDistribution(0, 2, 1),
                new[]
                {
                    -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6,
                    0.7, 0.8, 0.9, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9,
                    2, 2.1, 2.2, 2.3, 2.4, 2.5
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6, 0.7, 0.8, 0.9,
                    1, 0.9, 0.8, 0.7, 0.6, 0.5, 0.4, 0.3, 0.2, 0.0999999999999996,
                    0, 0, 0, 0, 0, 0
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.00500000000000001, 0.02, 0.045, 0.08, 0.125,
                    0.18, 0.245, 0.32, 0.405, 0.5, 0.595, 0.68, 0.755, 0.82, 0.875,
                    0.92, 0.955, 0.98, 0.995, 1, 1, 1, 1, 1, 1
                },
                DefaultProbs,
                new[]
                {
                    0, 0.14142135623731, 0.2, 0.244948974278318, 0.282842712474619,
                    0.316227766016838, 0.346410161513775, 0.374165738677394, 0.4,
                    0.424264068711929, 0.447213595499958, 0.469041575982343, 0.489897948556636,
                    0.509901951359279, 0.529150262212918, 0.547722557505166, 0.565685424949238,
                    0.58309518948453, 0.6, 0.616441400296898, 0.632455532033676,
                    0.648074069840786, 0.66332495807108, 0.678232998312527, 0.692820323027551,
                    0.707106781186548, 0.721110255092798, 0.734846922834953, 0.748331477354788,
                    0.761577310586391, 0.774596669241483, 0.787400787401181, 0.8,
                    0.812403840463596, 0.824621125123532, 0.836660026534076, 0.848528137423857,
                    0.860232526704263, 0.871779788708135, 0.883176086632785, 0.894427190999916,
                    0.905538513813742, 0.916515138991168, 0.92736184954957, 0.938083151964686,
                    0.948683298050514, 0.959166304662544, 0.969535971483266, 0.979795897113271,
                    0.989949493661167, 1, 1.01005050633883, 1.02020410288673, 1.03046402851673,
                    1.04083369533746, 1.05131670194949, 1.06191684803531, 1.07263815045043,
                    1.08348486100883, 1.09446148618626, 1.10557280900008, 1.11682391336722,
                    1.12822021129187, 1.13976747329574, 1.15147186257614, 1.16333997346592,
                    1.17537887487647, 1.1875961595364, 1.2, 1.21259921259882, 1.22540333075852,
                    1.23842268941361, 1.25166852264521, 1.26515307716505, 1.2788897449072,
                    1.29289321881345, 1.30717967697245, 1.32176700168747, 1.33667504192892,
                    1.35192593015921, 1.36754446796632, 1.3835585997031, 1.4, 1.41690481051547,
                    1.43431457505076, 1.45227744249483, 1.47084973778708, 1.49009804864072,
                    1.51010205144336, 1.53095842401766, 1.55278640450004, 1.57573593128807,
                    1.6, 1.62583426132261, 1.65358983848622, 1.68377223398316, 1.71715728752538,
                    1.75505102572168, 1.8, 1.85857864376269, 2
                }),
                        new TestData(
                new TriangularDistribution(0, 2, 0.5),
                new[]
                {
                    -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6,
                    0.7, 0.8, 0.9, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9,
                    2, 2.1, 2.2, 2.3, 2.4, 2.5
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.2, 0.4, 0.6, 0.8, 1, 0.933333333333333, 
                    0.866666666666667, 0.8, 0.733333333333333, 0.666666666666667, 
                    0.6, 0.533333333333333, 0.466666666666667, 0.4, 0.333333333333333, 
                    0.266666666666667, 0.2, 0.133333333333333, 0.0666666666666664, 
                    0, 0, 0, 0, 0, 0
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.01, 0.04, 0.09, 0.16, 0.25, 0.346666666666667, 
                    0.436666666666667, 0.52, 0.596666666666667, 0.666666666666667, 
                    0.73, 0.786666666666667, 0.836666666666667, 0.88, 0.916666666666667, 
                    0.946666666666667, 0.97, 0.986666666666667, 0.996666666666667, 
                    1, 1, 1, 1, 1, 1
                },
                DefaultProbs,
                new[]
                {
                    0, 0.1, 0.14142135623731, 0.173205080756888, 0.2, 0.223606797749979, 
                    0.244948974278318, 0.264575131106459, 0.282842712474619, 0.3, 
                    0.316227766016838, 0.33166247903554, 0.346410161513775, 0.360555127546399, 
                    0.374165738677394, 0.387298334620742, 0.4, 0.412310562561766, 
                    0.424264068711929, 0.435889894354067, 0.447213595499958, 0.458257569495584, 
                    0.469041575982343, 0.479583152331272, 0.489897948556636, 0.5, 
                    0.510033557424866, 0.520135141305126, 0.530306154330093, 0.540548048067358, 
                    0.550862325381056, 0.561250543006184, 0.57171431429143, 0.582255312124218, 
                    0.592875272052971, 0.603575995623106, 0.614359353944898, 0.625227291513248, 
                    0.636181830301414, 0.647225074153132, 0.658359213500126, 0.669586530434993, 
                    0.680909404172708, 0.692330316937798, 0.703851860318428, 0.715476742133487, 
                    0.727207793864215, 0.739047978708151, 0.75100040032032, 0.763068312314702, 
                    0.775255128608411, 0.787564434701786, 0.8, 0.812565791296208, 
                    0.825265987552927, 0.838104996137775, 0.851087470692394, 0.864218330839945, 
                    0.877502783967818, 0.890946349359058, 0.904554884989668, 0.918334617360803, 
                    0.932292174796869, 0.946434624714726, 0.960769515458674, 0.97530492340404, 
                    0.990049506163792, 1.00501256289338, 1.02020410288673, 1.0356349239007, 
                    1.05131670194949, 1.06726209469112, 1.08348486100883, 1.1, 1.11682391336722, 
                    1.13397459621556, 1.15147186257614, 1.16933761370819, 1.1875961595364, 
                    1.20627460668062, 1.22540333075852, 1.24501655647293, 1.26515307716505, 
                    1.28585715714572, 1.30717967697245, 1.32917960675006, 1.35192593015921, 
                    1.37550020016016, 1.4, 1.4255437353462, 1.45227744249483, 1.48038475772934, 
                    1.51010205144336, 1.54174243050442, 1.57573593128807, 1.61270166537926, 
                    1.65358983848622, 1.7, 1.75505102572168, 1.82679491924311, 2
                }),
                          new TestData(
                new TriangularDistribution(0, 2, 1.5),
                new[]
                {
                    -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5, 0.6,
                    0.7, 0.8, 0.9, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8, 1.9,
                    2, 2.1, 2.2, 2.3, 2.4, 2.5
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.0666666666666667, 0.133333333333333, 0.2, 
                    0.266666666666667, 0.333333333333333, 0.4, 0.466666666666667, 
                    0.533333333333333, 0.6, 0.666666666666667, 0.733333333333333, 
                    0.8, 0.866666666666667, 0.933333333333333, 1, 0.8, 0.6, 0.399999999999999, 
                    0.199999999999999, 0, 0, 0, 0, 0, 0
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0.00333333333333334, 0.0133333333333333, 
                    0.03, 0.0533333333333333, 0.0833333333333333, 0.12, 0.163333333333333, 
                    0.213333333333333, 0.27, 0.333333333333333, 0.403333333333333, 
                    0.48, 0.563333333333333, 0.653333333333333, 0.75, 0.84, 0.91, 
                    0.96, 0.99, 1, 1, 1, 1, 1, 1
                },
                DefaultProbs,
                new[]
                {
                    0, 0.173205080756888, 0.244948974278318, 0.3, 0.346410161513775, 
                    0.387298334620742, 0.424264068711929, 0.458257569495584, 0.489897948556636, 
                    0.519615242270663, 0.547722557505166, 0.574456264653803, 0.6, 
                    0.62449979983984, 0.648074069840786, 0.670820393249937, 0.692820323027551, 
                    0.714142842854285, 0.734846922834953, 0.754983443527075, 0.774596669241483, 
                    0.793725393319377, 0.812403840463596, 0.830662386291808, 0.848528137423857, 
                    0.866025403784439, 0.883176086632785, 0.9, 0.916515138991168, 
                    0.932737905308881, 0.948683298050514, 0.964365076099295, 0.979795897113271, 
                    0.99498743710662, 1.00995049383621, 1.02469507659596, 1.03923048454133, 
                    1.05356537528527, 1.06770782520313, 1.0816653826392, 1.09544511501033, 
                    1.10905365064094, 1.12249721603218, 1.13578166916005, 1.14891252930761, 
                    1.16189500386223, 1.17473401244707, 1.18743420870379, 1.2, 1.21243556529821, 
                    1.22474487139159, 1.2369316876853, 1.24899959967968, 1.26095202129185, 
                    1.27279220613579, 1.28452325786651, 1.29614813968157, 1.3076696830622, 
                    1.31909059582729, 1.33041346956501, 1.34164078649987, 1.35277492584687, 
                    1.36381816969859, 1.37477270848675, 1.3856406460551, 1.39642400437689, 
                    1.40712472794703, 1.41774468787578, 1.42828568570857, 1.43874945699382, 
                    1.44913767461894, 1.45945195193264, 1.46969384566991, 1.47986485869487, 
                    1.48996644257513, 1.5, 1.51010205144336, 1.52041684766873, 1.53095842401766, 
                    1.54174243050442, 1.55278640450004, 1.56411010564593, 1.57573593128807, 
                    1.58768943743823, 1.6, 1.61270166537926, 1.62583426132261, 1.6394448724536, 
                    1.65358983848622, 1.66833752096446, 1.68377223398316, 1.7, 1.71715728752538, 
                    1.73542486889354, 1.75505102572168, 1.77639320225002, 1.8, 1.82679491924311, 
                    1.85857864376269, 1.9, 2
                })

        };

        [UsedImplicitly]
        public static TheoryData<string> TestDataKeys = TheoryDataHelper.Create(TestDataList.Select(it => it.Distribution.ToString()));

        [Theory]
        [MemberData(nameof(TestDataKeys))]
        public void TriangularDistributionTest([NotNull] string testKey)
        {
            Check(TestDataList.First(it => it.Distribution.ToString() == testKey));
        }

        [Fact]
        public void TriangularDistributionTest1()
        {
            var distribution = new TriangularDistribution(0, 2, 1);
            AssertEqual("Min", 0, distribution.Min);
            AssertEqual("Max", 2, distribution.Max);
            AssertEqual("Mean", 1, distribution.Mean);
            AssertEqual("Median", 1, distribution.Median);
            AssertEqual("Variance", 3.0 / 18, distribution.Variance);
        }

        [Fact]
        public void TriangularDistributionTest2()
        {
            var distribution = new TriangularDistribution(0, 2, 0);
            AssertEqual("Min", 0, distribution.Min);
            AssertEqual("Max", 2, distribution.Max);
            AssertEqual("Mean", 2.0 / 3, distribution.Mean);
            AssertEqual("Median", 2 - Sqrt(2), distribution.Median);
            AssertEqual("Variance", 4.0 / 18, distribution.Variance);
        }

        [Theory]
        [InlineData(3, 1, 2)]
        [InlineData(1, 3, 0)]
        [InlineData(1, 3, 4)]
        [InlineData(0, 0, 0)]
        public void TriangularDistributionInvalidTest(double min, double max, double mode)
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new TriangularDistribution(min, max, mode));
        }
    }
}