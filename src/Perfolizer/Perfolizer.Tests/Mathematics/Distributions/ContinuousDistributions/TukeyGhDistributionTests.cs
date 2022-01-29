using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Perfolizer.Mathematics.Distributions.ContinuousDistributions;
using Perfolizer.Tests.Common;
using Xunit;
using Xunit.Abstractions;

namespace Perfolizer.Tests.Mathematics.Distributions.ContinuousDistributions
{
    public class TukeyGhDistributionTests : DistributionTestsBase
    {
        protected override double Eps => 1e-4;

        public TukeyGhDistributionTests(ITestOutputHelper output) : base(output)
        {
        }

        private static readonly double[] DefaultX =
        {
            -5, -4.9, -4.8, -4.7, -4.6, -4.5, -4.4, -4.3, -4.2, -4.1, -4,
            -3.9, -3.8, -3.7, -3.6, -3.5, -3.4, -3.3, -3.2, -3.1, -3, -2.9,
            -2.8, -2.7, -2.6, -2.5, -2.4, -2.3, -2.2, -2.1, -2, -1.9, -1.8,
            -1.7, -1.6, -1.5, -1.4, -1.3, -1.2, -1.1, -1, -0.9, -0.8, -0.7,
            -0.6, -0.5, -0.4, -0.3, -0.2, -0.1, 0, 0.1, 0.2, 0.3, 0.4, 0.5,
            0.6, 0.7, 0.8, 0.9, 1, 1.1, 1.2, 1.3, 1.4, 1.5, 1.6, 1.7, 1.8,
            1.9, 2, 2.1, 2.2, 2.3, 2.4, 2.5, 2.6, 2.7, 2.8, 2.9, 3, 3.1,
            3.2, 3.3, 3.4, 3.5, 3.6, 3.7, 3.8, 3.9, 4, 4.1, 4.2, 4.3, 4.4,
            4.5, 4.6, 4.7, 4.8, 4.9, 5
        };

        private static readonly List<TestData> TestDataList = new()
        {
            new TestData(new TukeyGhDistribution(0, 1, 0, 0),
                DefaultX,
                new[]
                {
                    1.4867195147343e-06, 2.43896074589335e-06, 3.96129909103208e-06,
                    6.36982517886709e-06, 1.01408520654868e-05, 1.59837411069055e-05,
                    2.49424712900535e-05, 3.85351967420871e-05, 5.89430677565399e-05,
                    8.92616571771329e-05, 0.000133830225764885, 0.000198655471392773,
                    0.00029194692579146, 0.000424780270550751, 0.000611901930113773,
                    0.00087268269504576, 0.00123221916847302, 0.00172256893905368,
                    0.00238408820146484, 0.00326681905619992, 0.00443184841193801,
                    0.00595253241977585, 0.00791545158297997, 0.0104209348144226,
                    0.0135829692336856, 0.0175283004935685, 0.0223945302948429, 0.0283270377416012,
                    0.0354745928462315, 0.0439835959804272, 0.0539909665131881, 0.0656158147746766,
                    0.0789501583008942, 0.094049077376887, 0.110920834679456, 0.129517595665892,
                    0.149727465635745, 0.171368592047807, 0.194186054983213, 0.217852177032551,
                    0.241970724519143, 0.266085249898755, 0.289691552761483, 0.312253933366761,
                    0.3332246028918, 0.3520653267643, 0.368270140303323, 0.381387815460524,
                    0.391042693975456, 0.396952547477012, 0.398942280401433, 0.396952547477012,
                    0.391042693975456, 0.381387815460524, 0.368270140303323, 0.3520653267643,
                    0.3332246028918, 0.312253933366761, 0.289691552761483, 0.266085249898755,
                    0.241970724519143, 0.21785217703255, 0.194186054983213, 0.171368592047807,
                    0.149727465635745, 0.129517595665892, 0.110920834679455, 0.0940490773768869,
                    0.0789501583008941, 0.0656158147746766, 0.0539909665131881, 0.0439835959804272,
                    0.0354745928462314, 0.0283270377416011, 0.0223945302948429, 0.0175283004935685,
                    0.0135829692336856, 0.0104209348144226, 0.00791545158297995,
                    0.00595253241977585, 0.00443184841193801, 0.00326681905619992,
                    0.00238408820146483, 0.00172256893905368, 0.00123221916847302,
                    0.00087268269504576, 0.000611901930113773, 0.00042478027055075,
                    0.00029194692579146, 0.000198655471392772, 0.000133830225764885,
                    8.92616571771329e-05, 5.89430677565396e-05, 3.8535196742087e-05,
                    2.49424712900535e-05, 1.59837411069055e-05, 1.01408520654867e-05,
                    6.36982517886707e-06, 3.96129909103206e-06, 2.43896074589335e-06,
                    1.4867195147343e-06
                },
                new[]
                {
                    2.86651571879194e-07, 4.79183276590319e-07, 7.93328151975595e-07,
                    1.30080745391728e-06, 2.11245470250285e-06, 3.39767312473006e-06,
                    5.41254390770385e-06, 8.53990547099181e-06, 1.33457490159063e-05,
                    2.06575069125468e-05, 3.16712418331199e-05, 4.80963440176027e-05,
                    7.23480439251201e-05, 0.000107799733477388, 0.000159108590157534,
                    0.000232629079035525, 0.000336929265676881, 0.000483424142383777,
                    0.000687137937915848, 0.000967603213218358, 0.00134989803163009,
                    0.00186581330038404, 0.00255513033042793, 0.00346697380304067,
                    0.00466118802371875, 0.00620966532577613, 0.00819753592459613,
                    0.0107241100216758, 0.0139034475134986, 0.0178644205628166, 0.0227501319481792,
                    0.0287165598160018, 0.0359303191129258, 0.0445654627585431, 0.054799291699558,
                    0.0668072012688581, 0.0807566592337711, 0.0968004845856104, 0.115069670221708,
                    0.135666060946383, 0.158655253931457, 0.18406012534676, 0.211855398583397,
                    0.241963652223073, 0.274253117750074, 0.308537538725987, 0.344578258389676,
                    0.382088577811047, 0.420740290560897, 0.460172162722971, 0.5,
                    0.539827837277029, 0.579259709439103, 0.617911422188953, 0.655421741610324,
                    0.691462461274013, 0.725746882249927, 0.758036347776927, 0.788144601416603,
                    0.815939874653241, 0.841344746068543, 0.864333939053617, 0.884930329778292,
                    0.90319951541439, 0.919243340766229, 0.933192798731142, 0.945200708300442,
                    0.955434537241457, 0.964069680887074, 0.971283440183998, 0.977249868051821,
                    0.982135579437183, 0.986096552486501, 0.989275889978324, 0.991802464075404,
                    0.993790334674224, 0.995338811976281, 0.996533026196959, 0.997444869669572,
                    0.998134186699616, 0.99865010196837, 0.999032396786782, 0.999312862062084,
                    0.999516575857616, 0.999663070734323, 0.999767370920964, 0.999840891409842,
                    0.999892200266523, 0.999927651956075, 0.999951903655982, 0.999968328758167,
                    0.999979342493088, 0.999986654250984, 0.999991460094529, 0.999994587456092,
                    0.999996602326875, 0.999997887545298, 0.999998699192546, 0.999999206671848,
                    0.999999520816723, 0.999999713348428
                },
                DefaultProbs,
                new[]
                {
                    double.NegativeInfinity, -2.32634787404084, -2.05374891063182, -1.88079360815125,
                    -1.75068607125217, -1.64485362695147, -1.55477359459685, -1.47579102817917,
                    -1.40507156030963, -1.34075503369022, -1.2815515655446, -1.22652812003661,
                    -1.17498679206609, -1.1263911290388, -1.08031934081496, -1.03643338949379,
                    -0.994457883209753, -0.954165253146194, -0.915365087842814, -0.877896295051228,
                    -0.841621233572914, -0.80642124701824, -0.772193214188685, -0.738846849185214,
                    -0.706302562840088, -0.674489750196082, -0.643345405392917, -0.612812991016627,
                    -0.582841507271216, -0.553384719555673, -0.524400512708041, -0.495850347347453,
                    -0.467698799114508, -0.439913165673234, -0.412463129441405, -0.385320466407568,
                    -0.358458793251194, -0.331853346436817, -0.305480788099397, -0.279319034447454,
                    -0.2533471031358, -0.227544976641149, -0.201893479141851, -0.176374164780861,
                    -0.150969215496777, -0.125661346855074, -0.10043372051147, -0.0752698620998298,
                    -0.0501535834647337, -0.0250689082587111, 0, 0.0250689082587111,
                    0.0501535834647337, 0.0752698620998299, 0.10043372051147, 0.125661346855074,
                    0.150969215496777, 0.176374164780861, 0.201893479141851, 0.227544976641149,
                    0.2533471031358, 0.279319034447454, 0.305480788099397, 0.331853346436817,
                    0.358458793251194, 0.385320466407568, 0.412463129441405, 0.439913165673234,
                    0.467698799114508, 0.495850347347453, 0.524400512708041, 0.553384719555673,
                    0.582841507271216, 0.612812991016627, 0.643345405392917, 0.674489750196082,
                    0.706302562840088, 0.738846849185214, 0.772193214188685, 0.80642124701824,
                    0.841621233572914, 0.877896295051229, 0.915365087842814, 0.954165253146195,
                    0.994457883209753, 1.03643338949379, 1.08031934081496, 1.1263911290388,
                    1.17498679206609, 1.22652812003661, 1.2815515655446, 1.34075503369022,
                    1.40507156030963, 1.47579102817917, 1.55477359459685, 1.64485362695147,
                    1.75068607125217, 1.88079360815125, 2.05374891063182, 2.32634787404084,
                    double.PositiveInfinity
                }),
            new TestData(new TukeyGhDistribution(0, 1, 0, 0.5),
                DefaultX,
                new[]
                {
                    0.00811393388656697, 0.00851886243863056, 0.00895155110954898,
                    0.00941443113720513, 0.00991019355431186, 0.0104418219850846,
                    0.0110126302140829, 0.0116263053110878, 0.0122869572384693, 0.0129991760382728,
                    0.0137680979011367, 0.0145994816653428, 0.0154997975905357, 0.0164763306074728,
                    0.0175373006753168, 0.0186920033966452, 0.0199506628575494, 0.0213243934602775,
                    0.0228326129637901, 0.0244823935413945, 0.0262956957342032, 0.0282924632707709,
                    0.0304976050023166, 0.0329361105019203, 0.035640267726926, 0.0386460111910921,
                    0.0419952206750821, 0.0457365134202285, 0.049926421133322, 0.0546398296544311,
                    0.0599383662792662, 0.0659233154105165, 0.0726975872890366, 0.0803837692017814,
                    0.089123689297401, 0.0990801307759625, 0.110437588582616, 0.123401091072968,
                    0.138188179254258, 0.15503002481843, 0.174135469304923, 0.195664298404647,
                    0.219667990672693, 0.246004713220508, 0.274219479417545, 0.30343953389379,
                    0.332207950102873, 0.358513938475217, 0.379926992357418, 0.394015928651721,
                    0.398942280401433, 0.394015928651721, 0.379926992357418, 0.358513938475217,
                    0.332207950102872, 0.30343953389379, 0.274219479417545, 0.246004713220508,
                    0.219667990672692, 0.195664298404647, 0.174135469304923, 0.155030024818429,
                    0.138188179254257, 0.123401091072967, 0.110437588582616, 0.0990801307759625,
                    0.0891236892974009, 0.0803837692017814, 0.0726975872890365, 0.0659233154105165,
                    0.0599383662792662, 0.0546398296544311, 0.0499264211333219, 0.0457365134202284,
                    0.0419952206750821, 0.0386460111910921, 0.035640267726926, 0.0329361105019203,
                    0.0304976050023166, 0.0282924632707709, 0.0262956957342032, 0.0244823935413945,
                    0.0228326129637901, 0.0213243934602775, 0.0199506628575494, 0.0186920033966452,
                    0.0175373006753168, 0.0164763306074728, 0.0154997975905357, 0.0145994816653428,
                    0.0137680979011367, 0.0129991760382728, 0.0122869572384693, 0.0116263053110878,
                    0.0110126302140829, 0.0104418219850846, 0.00991019355431184,
                    0.00941443113720513, 0.00895155110954898, 0.00851886243863056,
                    0.00811393388656697
                },
                new[]
                {
                    0.0259515074187451, 0.0267829272972315, 0.0276562090931219,
                    0.028574248295592, 0.0295401962368656, 0.0305574876767645, 0.0316298719008292,
                    0.0327614478472699, 0.0339567038631567, 0.0352205627910224, 0.0365584332065345,
                    0.0379762677698988, 0.0394806298227589, 0.0410787695641104, 0.0427787113798723,
                    0.0445893541893404, 0.0465201139334406, 0.0485807665948705, 0.0507921104375649,
                    0.0531554099133253, 0.0556922149926, 0.0584191725558359, 0.0613576910959593,
                    0.0645270165673663, 0.067953446600312, 0.0716649341580345, 0.0756935274851275,
                    0.0800757059974739, 0.0848531024596579, 0.0900832812196607, 0.0958040351177374,
                    0.102091088692628, 0.109015218008592, 0.116661358082705, 0.12512764587301,
                    0.134527425104717, 0.144991376439042, 0.156669634895842, 0.169730734235602,
                    0.184373166988492, 0.200811321641291, 0.219280261032708, 0.240026173419099,
                    0.263291513955658, 0.289284884507786, 0.318169686717897, 0.349963595291896,
                    0.384531270388485, 0.421504788164816, 0.460271137816096, 0.5,
                    0.539728862183904, 0.578495211835184, 0.615468729611515, 0.650036404708104,
                    0.681830313282103, 0.710715115492214, 0.736708486044342, 0.759973826580901,
                    0.780719738967293, 0.799188678358709, 0.815626833011508, 0.830269265764398,
                    0.843330365104158, 0.855008623560958, 0.865472574895283, 0.87487235412699,
                    0.883338641917295, 0.890984781991408, 0.897908911307372, 0.904195964882263,
                    0.909916718780339, 0.915146897540342, 0.919924294002526, 0.924306472514873,
                    0.928335065841966, 0.932046553399688, 0.935472983432634, 0.938642308904041,
                    0.941580827444164, 0.9443077850074, 0.946844590086675, 0.949207889562435,
                    0.95141923340513, 0.953479886066559, 0.95541064581066, 0.957221288620128,
                    0.95892123043589, 0.960519370177241, 0.962023732230101, 0.963441566793465,
                    0.964779437208978, 0.966043296136843, 0.96723855215273, 0.968370128099171,
                    0.969442512323236, 0.970459803763134, 0.971425751704408, 0.972343790906878,
                    0.973217072702768, 0.974048492581255
                },
                DefaultProbs,
                new[]
                {
                    double.NegativeInfinity, -9.00043770096488, -5.89519732623313, -4.5541548442733,
                    -3.76682767549087, -3.23502696465488, -2.84527626785273, -2.54386334143095,
                    -2.30169257966176, -2.101473842553, -1.93221131910409, -1.78653916111729,
                    -1.65931588029706, -1.54683061771748, -1.44632976777322, -1.35572169489874,
                    -1.27338548392144, -1.19804304692235, -1.12867121044769, -1.06443981866704,
                    -1.00466722561602, -0.948787688096272, -0.896327075663251, -0.846884503197747,
                    -0.800118252620717, -0.755734848499196, -0.713480485083916, -0.673134228755354,
                    -0.63450257653081, -0.597415061369659, -0.561720673460735, -0.527284923308953,
                    -0.493987413817572, -0.461719819135025, -0.4303841908578, -0.399891529382399,
                    -0.370160571280488, -0.341116753601673, -0.312691323758499, -0.284820569678939,
                    -0.257445149634453, -0.230509504871422, -0.203961341117983, -0.177751167377927,
                    -0.151831882287804, -0.12615839980102, -0.100687307148734, -0.0753765489690807,
                    -0.0501851322377933, -0.0250728472079917, 0, 0.0250728472079917,
                    0.0501851322377933, 0.0753765489690808, 0.100687307148734, 0.12615839980102,
                    0.151831882287804, 0.177751167377928, 0.203961341117982, 0.230509504871422,
                    0.257445149634453, 0.284820569678939, 0.312691323758499, 0.341116753601673,
                    0.370160571280488, 0.399891529382399, 0.4303841908578, 0.461719819135025,
                    0.493987413817572, 0.527284923308954, 0.561720673460736, 0.597415061369658,
                    0.63450257653081, 0.673134228755354, 0.713480485083916, 0.755734848499196,
                    0.800118252620717, 0.846884503197747, 0.896327075663251, 0.948787688096272,
                    1.00466722561602, 1.06443981866704, 1.12867121044769, 1.19804304692235,
                    1.27338548392144, 1.35572169489874, 1.44632976777322, 1.54683061771748,
                    1.65931588029706, 1.78653916111729, 1.93221131910409, 2.101473842553,
                    2.30169257966176, 2.54386334143095, 2.84527626785273, 3.23502696465489,
                    3.76682767549087, 4.5541548442733, 5.89519732623313, 9.00043770096488,
                    double.PositiveInfinity
                }),
            new TestData(new TukeyGhDistribution(0, 1, 0.5, 0),
                DefaultX,
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 1.27898357657518e-07, 9.90238664959184e-05,
                    0.00198935060544324, 0.0112197303883959, 0.0341747475482161,
                    0.073236103968838, 0.125761327456803, 0.186034114282143, 0.247669540633981,
                    0.305227652095092, 0.354899832464414, 0.394554284356719, 0.423456934858509,
                    0.441888531214149, 0.45077885186472, 0.451409183249523, 0.445194324174099,
                    0.43353632392117, 0.417735324111791, 0.398942280401433, 0.378140425010272,
                    0.356145197278442, 0.333615123046187, 0.311068420266643, 0.288901877279695,
                    0.267409841063426, 0.246802055476517, 0.227219696884344, 0.208749347172241,
                    0.191434885994296, 0.175287423368283, 0.160293465328633, 0.146421533856925,
                    0.133627464564745, 0.121858592867371, 0.111057018988409, 0.101162118696969,
                    0.0921124429936861, 0.0838471276150945, 0.0763069130237729, 0.0694348578122374,
                    0.0631768131968912, 0.0574817133737093, 0.0523017257253969, 0.0475922959532098,
                    0.0433121158958498, 0.0394230358479693, 0.0358899383803678, 0.0326805867982435,
                    0.0297654582851429, 0.0271175693262293, 0.024712299065863, 0.0225272147321473,
                    0.0205419020733852, 0.0187378028314166, 0.0170980605701028, 0.0156073756396461,
                    0.0142518696533365, 0.0130189595540789, 0.0118972411307183, 0.0108763816904548,
                    0.00994702148895547, 0.00910068345260729, 0.00832969068860097,
                    0.00762709126104431, 0.00698658970947191, 0.00640248479559428,
                    0.00586961298153814, 0.00538329716558166, 0.00493930022750871
                },
                new[]
                {
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                    0, 0, 0, 0, 0, 0, 1.03979832145433e-09, 2.06064339597173e-06,
                    7.40481963826194e-05, 0.00064347101291388, 0.00278061786230952,
                    0.00802128545598512, 0.0178800736171477, 0.0334324184089169,
                    0.0551311380840721, 0.0828285190016985, 0.115911900378989, 0.15347299656473,
                    0.194463239956215, 0.23781463705461, 0.282522523985944, 0.327694935711543,
                    0.372576209340124, 0.416552481228995, 0.459145543642043, 0.5,
                    0.538867227171026, 0.575588480994146, 0.610078594582459, 0.64231108623684,
                    0.672305064288457, 0.700114039009087, 0.725816583430655, 0.749508691386811,
                    0.771297636956535, 0.791297126615529, 0.809623541240417, 0.826393081249728,
                    0.841719649141113, 0.85571332608373, 0.868479321024816, 0.880117290864619,
                    0.890720948127397, 0.900377888056081, 0.909169580247017, 0.917171480998301,
                    0.924453231704043, 0.931078916136731, 0.937107355563645, 0.942592425564619,
                    0.947583382357198, 0.952125189564678, 0.956258838830863, 0.960021659617489,
                    0.963447615020049, 0.966567581591083, 0.969409612037338, 0.971999180315758,
                    0.974359409139544, 0.97651128025692, 0.97847382811175, 0.980264317660727,
                    0.981898407225558, 0.983390297315459, 0.984752866377178, 0.985997794426055,
                    0.987135675489468, 0.988176119759057, 0.989127846304636, 0.98999876715404,
                    0.990796063491644, 0.991526254675959, 0.992195260724712, 0.992808458865223,
                    0.993370734699334, 0.993886528486001
                },
                DefaultProbs,
                new[]
                {
                    double.NegativeInfinity, -1.37501445434207, -1.28375090519817, -1.21905427321963,
                    -1.16656190864283, -1.12127179014502, -1.08078902863071, -1.0437618953779,
                    -1.00934466429817, -0.976969128723714, -0.946232963407927, -0.91683953893176,
                    -0.888562986803786, -0.861226716368722, -0.834689575697682, -0.80883658902173,
                    -0.7835725551106, -0.75881750030665, -0.734503371748787, -0.710571582419802,
                    -0.686971155104598, -0.663657296186218, -0.640590283605922, -0.617734588197808,
                    -0.595058170918107, -0.572531914383684, -0.550129158172346, -0.527825315131175,
                    -0.505597551525369, -0.483424517919642, -0.461286120671482, -0.439163326139151,
                    -0.417037991379763, -0.394892716382695, -0.372710713856006, -0.350475693333805,
                    -0.328171756954976, -0.305783304718252, -0.283294947374515, -0.260691425396406,
                    -0.237957532683902, -0.215078043834966, -0.192037643941691, -0.168820859971641,
                    -0.145411992866456, -0.121795049539035, -0.0979536739795552,
                    -0.073871076690964, -0.0495299616675868, -0.0249124501064835,
                    0, 0.0252266793012055, 0.0507877185439192, 0.0767041871361922,
                    0.102998200032802, 0.129693034308256, 0.156813256968274, 0.184384865774549,
                    0.212435445127706, 0.240994339379486, 0.270092846339116, 0.299764434215843,
                    0.330044985818911, 0.360973074542156, 0.392590277524266, 0.424941532437483,
                    0.458075545669175, 0.492045261289645, 0.526908402234198, 0.562728097684746,
                    0.599573613871325, 0.637521209635416, 0.676655143387169, 0.717068864933248,
                    0.758866434583751, 0.802164223708708, 0.847092966556442, 0.893800254167408,
                    0.942453589790618, 0.993244164527871, 1.04639156675849, 1.1021497164663,
                    1.16081442708195, 1.2227331605048, 1.28831778402015, 1.35806150787901,
                    1.43256175915086, 1.51255167072848, 1.59894438686813, 1.69289698412283,
                    1.79590541466942, 1.90995043483858, 2.037731242992, 2.18305857156861,
                    2.35155815649313, 2.55203321702864, 2.79939666962712, 3.12199486191047,
                    3.58464929174772, 4.40014801588592,
                    double.PositiveInfinity
                }),
            new TestData(new TukeyGhDistribution(0, 1, 0.5, 0.5),
                DefaultX,
                new[]
                {
                    0.00429625491174148, 0.00454979174600079, 0.00482218934429408,
                    0.00511693970108107, 0.00543604638465328, 0.00578198418063672,
                    0.00615760904233963, 0.00656614754288597, 0.00701125419510329,
                    0.00749712738725048, 0.00802843729368834, 0.00860870129383002,
                    0.00924780613814223, 0.00995032610757445, 0.0107245790978366,
                    0.0115799390869814, 0.0125272411262292, 0.0135788866343492, 0.0147493549053697,
                    0.0160555453423736, 0.0175189761423141, 0.0191594320118831, 0.021006051700437,
                    0.023091309510012, 0.0254537768564277, 0.0281394203390711, 0.0312031950290181,
                    0.0347109985344471, 0.0387423727561234, 0.0433918762570136, 0.048775822204214,
                    0.0550333961211701, 0.0623330931830845, 0.0708779072082562, 0.0809110605812921,
                    0.0927211299396447, 0.106660327767083, 0.123084300893595, 0.142421429170543,
                    0.165074584252756, 0.191371827448128, 0.221436803309989, 0.254996992050804,
                    0.291125531698353, 0.327978423565865, 0.362689214467728, 0.391637717316299,
                    0.411227429826134, 0.418977591340157, 0.414372761949623, 0.398937039593738,
                    0.37555901643099, 0.347442180281499, 0.317440412019212, 0.287601521624644,
                    0.25925043343949, 0.233095099603472, 0.209421001980544, 0.188249951172332,
                    0.169455365266721, 0.152837993157284, 0.138172110482637, 0.125228094750619,
                    0.113802300445018, 0.103697050792812, 0.0947416736510233, 0.0867870038518861,
                    0.0797030171179512, 0.0733781390827516, 0.0677158247219683, 0.062633181202838,
                    0.058056812460543, 0.0539272151067574, 0.0502005413059827, 0.0468132191828998,
                    0.0437344197777637, 0.0409295459564546, 0.0383685054202491, 0.0360250606657815,
                    0.0338762780677306, 0.031902061072773, 0.0300861721657756, 0.0284066342323608,
                    0.0268594663938303, 0.0254272371064203, 0.0240993851980541, 0.0228664731058841,
                    0.0217202726696025, 0.0206540402120983, 0.0196586017340797, 0.0187278363820363,
                    0.0178593024600722, 0.0170467019791881, 0.0162823415741903, 0.0155675296543303,
                    0.0148954849362325, 0.0142626915994092, 0.0136672946572295, 0.0131087937320075,
                    0.0125791325064811, 0.0120793526554497
                },
                new[]
                {
                    0.0112582564284559, 0.0117018083486267, 0.0121695725309272,
                    0.0126662421698646, 0.0131936960136832, 0.0137543920005132, 0.0143511605434364,
                    0.0149871393843779, 0.0156658148881713, 0.0163911412804273, 0.0171673687599788,
                    0.0179966940980014, 0.0188898638832289, 0.0198494226674873, 0.020882531952546,
                    0.0219969620657893, 0.0232014857185619, 0.0245058387532202, 0.0259211590440461,
                    0.0274601491798096, 0.0291392979565074, 0.0309713020643362, 0.0329773667446971,
                    0.0351797126773016, 0.0376041110728012, 0.0402805517384841, 0.0432440515232357,
                    0.0465356351335374, 0.0502038063593282, 0.054304620745448, 0.0589063344315477,
                    0.0640887870096729, 0.0699473939178474, 0.0765960293373579, 0.0841707783716837,
                    0.0928342869136064, 0.102791519745375, 0.114253895341186, 0.127503229774931,
                    0.14284886482798, 0.160639855928763, 0.181248611350867, 0.205043336705015,
                    0.232335444140612, 0.263297577267417, 0.297865283984401, 0.33564545659582,
                    0.375877453343144, 0.417489407424393, 0.459254988826006, 0.500010480995848,
                    0.538777911247949, 0.574965375552585, 0.608204995628472, 0.638448260648899,
                    0.665773496702256, 0.69036946732385, 0.712473119313461, 0.732335487766182,
                    0.750201438307137, 0.766298951556873, 0.780834429824689, 0.79399539078761,
                    0.805934709246529, 0.816799114062917, 0.826711918733217, 0.835780245128566,
                    0.844097979953166, 0.851746068635136, 0.858795626464369, 0.865308571750124,
                    0.871341873258924, 0.876940672385354, 0.882133909030492, 0.886983249841233,
                    0.891509178506788, 0.895740878334708, 0.899704288051715, 0.903422517899409,
                    0.906916207748116, 0.910203835523001, 0.913299537809641, 0.916229402830689,
                    0.918989885721188, 0.921602308448424, 0.924077324026051, 0.926424667102343,
                    0.928652814415964, 0.930768237519183, 0.932783148662799, 0.934704592839092,
                    0.936532534546563, 0.938275459515525, 0.939945746765081, 0.941536619902304,
                    0.943059425281633, 0.944518860524098, 0.945916127858954, 0.947249348262941,
                    0.948535111577646, 0.949768572155963
                },
                DefaultProbs,
                new[]
                {
                    double.NegativeInfinity, -5.31981139722473, -3.68495139045277, -2.95181879593498,
                    -2.51000893581469, -2.20526885577582, -1.97787213804331, -1.79916232863286,
                    -1.65343971777803, -1.53128276038906, -1.42664727004508, -1.33545225258546,
                    -1.25482829645695, -1.18269029232522, -1.11748103969966, -1.05801040614895,
                    -1.00335060350325, -0.952765809829892, -0.905663566024019, -0.861560403665613,
                    -0.820057024401788, -0.780820041715124, -0.743568325974034, -0.708062638977056,
                    -0.674097658669366, -0.64149576691406, -0.610102155609385, -0.579780930931236,
                    -0.550411981865311, -0.521888440057488, -0.494114601497227, -0.467004212021101,
                    -0.440479041672556, -0.414467690019967, -0.388904577299286, -0.363729085883457,
                    -0.338884823917403, -0.314318988586547, -0.289981810835869, -0.265826066736555,
                    -0.241806643337126, -0.217880148904796, -0.194004559087147, -0.170138891798518,
                    -0.14624290463115, -0.122276809361686, -0.0982009987093936, -0.0739757809335452,
                    -0.0495611181555655, -0.0249163644722952, 0, 0.0252306430402428,
                    0.0508196662153689, 0.0768129070056818, 0.103258261763639, 0.130206034577511,
                    0.157709317723006, 0.185824410162168, 0.214611281520388, 0.244134090179404,
                    0.274461765618442, 0.305668666984108, 0.337835332158402, 0.371049334435081,
                    0.405406267452651, 0.441010883457158, 0.477978415529091, 0.516436121435962,
                    0.556525095705224, 0.598402407941801, 0.642243640140368, 0.688245914857583,
                    0.736631531120855, 0.787652357957637, 0.841595179388963, 0.898788243853579,
                    0.959609351384859, 1.02449592231913, 1.09395764500845, 1.1685925167051,
                    1.24910740169934, 1.33634468097494, 1.4313172327856, 1.535254984767,
                    1.64966781655354, 1.77643200991211, 1.91791134172461, 2.07713038113065,
                    2.25802862700853, 2.46584379800645, 2.70770904859374, 2.993619847422,
                    3.33807260343812, 3.76300070021553, 4.30341281740144, 5.01922854198513,
                    6.02326426364165, 7.55960035303486, 10.2895805864084, 17.0237901794176,
                    double.PositiveInfinity
                })
        };

        [UsedImplicitly]
        public static TheoryData<string> TestDataKeys = TheoryDataHelper.Create(TestDataList.Select(it => it.Distribution.ToString()!));

        [Theory]
        [MemberData(nameof(TestDataKeys))]
        public void TukeyGhDistributionTest(string testKey)
        {
            Check(TestDataList.First(it => it.Distribution.ToString() == testKey),
                skipStdDev: true, skipPdf: true, skipCdf: true);
        }
    }
}