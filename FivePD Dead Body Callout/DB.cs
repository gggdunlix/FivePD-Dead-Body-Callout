﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitizenFX.Core;
using FivePD.API;
using FivePD.API.Utils;
using CitizenFX.Core.Native;

namespace DeadBody
{
    [CalloutProperties("Dead Body", "GGGDunlix", "0.1.0")]
    public class DeadBody : Callout
    {
        Ped body;
        private Vector3[] coordinates = {
            new Vector3(194.8306f, -1697.532f, 29.40961f),
new Vector3(184.5135f, -1706.264f, 29.40095f),
new Vector3(368.3647f, -2012.062f, 23.49446f),
new Vector3(242.0468f, -2007.625f, 18.97581f),
new Vector3(164.604f, -1861.367f, 24.12285f),
new Vector3(196.3712f, -1854.352f, 27.18941f),
new Vector3(427.6999f, -1907.122f, 25.50183f),
new Vector3(494.2699f, -1968.749f, 24.91532f),
new Vector3(741.4722f, -1831.158f, 29.26769f),
new Vector3(564.4562f, -1611.735f, 27.82919f),
new Vector3(421.8894f, -1526.73f, 29.27665f),
new Vector3(279.7567f, -1356.739f, 31.92541f),
new Vector3(354.5041f, -1262.734f, 32.41825f),
new Vector3(367.2931f, -1241.701f, 32.50347f),
new Vector3(348.1544f, -1214.624f, 30.74306f),
new Vector3(254.134f, -1193.935f, 29.36864f),
new Vector3(171.2001f, -1219.349f, 29.44479f),
new Vector3(97.44859f, -1203.951f, 29.29966f),
new Vector3(-39.0288f, -1221.018f, 29.33259f),
new Vector3(-69.02113f, -1234.353f, 28.99132f),
new Vector3(-69.40932f, -1202.664f, 27.80404f),
new Vector3(-220.2408f, -1195.783f, 26.23387f),
new Vector3(-305.9799f, -1200.22f, 24.68383f),
new Vector3(-344.3672f, -1268.237f, 31.29068f),
new Vector3(-633.798f, -1212.028f, 12.56263f),
new Vector3(-766.6259f, -1178.01f, 10.1247f),
new Vector3(-850.4732f, -1080.412f, 9.257874f),
new Vector3(-985.1086f, -874.2131f, 2.143095f),
new Vector3(-889.1624f, -852.876f, 20.56288f),
new Vector3(-1076.264f, -939.6396f, 2.342556f),
new Vector3(-1120.299f, -969.3402f, 2.150192f),
new Vector3(-1236.52f, -924.0392f, 8.481179f),
new Vector3(-1433.691f, -1038.527f, 4.721096f),
new Vector3(-1335.803f, -1034.949f, 7.750277f),
new Vector3(-1249.884f, -1141.802f, 7.729444f),
new Vector3(-1264.415f, -1140.512f, 7.54163f),
new Vector3(-1631.262f, -1053.783f, 4.907489f),
new Vector3(-1711.048f, -1103.267f, 13.15233f),
new Vector3(-1806.717f, -1208.584f, 14.30475f),
new Vector3(-1812.237f, -1208.37f, 19.16961f),
new Vector3(-1563.209f, -906.9575f, 9.154253f),
new Vector3(-1443.158f, -682.8121f, 26.3095f),
new Vector3(-1407.279f, -636.0478f, 28.67327f),
new Vector3(-1375.947f, -455.4115f, 34.47419f),
new Vector3(-1372.031f, -328.8431f, 39.18433f),
new Vector3(-1495.732f, -22.38493f, 54.64185f),
new Vector3(-1579.005f, 88.91558f, 58.9548f),
new Vector3(-1434.007f, 224.4105f, 58.98721f),
new Vector3(-1483.446f, 347.7967f, 97.5641f),
new Vector3(-1767.252f, 204.9059f, 64.37392f),
new Vector3(-1720.786f, 224.6822f, 61.73586f),
new Vector3(-1559.936f, -55.93185f, 56.49216f),
new Vector3(-926.9901f, 148.1014f, 64.04488f),
new Vector3(-872.1938f, 585.7297f, 99.31324f),
new Vector3(-975.9841f, 660.0412f, 158.0163f),
new Vector3(-1142.498f, 706.345f, 153.5971f),
new Vector3(-1229.865f, 622.3995f, 137.8435f),
new Vector3(-1310.807f, 617.8265f, 133.9483f),
new Vector3(-1438.456f, 478.1299f, 115.243f),
new Vector3(-1780.121f, 318.636f, 88.12899f),
new Vector3(-1921.367f, 268.8429f, 88.42929f),
new Vector3(-2267.975f, 232.4284f, 194.6063f),
new Vector3(-2008.093f, -288.2895f, 31.26258f),
new Vector3(-2041.68f, -373.0347f, 48.10614f),
new Vector3(-2044.341f, -376.1172f, 11.11077f),
new Vector3(-1493.843f, -548.1115f, 32.62042f),
new Vector3(-1253.875f, -857.4979f, 12.32391f),
new Vector3(-1082.688f, -1068.772f, 2.150306f),
new Vector3(-700.8257f, -1517.845f, 4.597232f),
new Vector3(-596.8431f, -1533.69f, 5.41116f),
new Vector3(-117.502f, -1846.445f, 5.411816f),
new Vector3(39.6009f, -2208.876f, 1.606572f),
new Vector3(-89.05101f, -2224.912f, 7.811671f),
new Vector3(-257.828f, -2247.363f, 8.105116f),
new Vector3(-460.6512f, -2175.953f, 10.15686f),
new Vector3(-813.3497f, -2105.982f, 8.80953f),
new Vector3(-434.3199f, -1466.586f, 21.12918f),
new Vector3(-479.0955f, -1052.921f, 52.47662f),
new Vector3(-462.3751f, -947.0111f, 47.98357f),
new Vector3(-334.1825f, -762.9147f, 48.42428f),
new Vector3(307.8366f, -907.1046f, 29.29362f),
new Vector3(371.7222f, -789.8265f, 29.28418f),
new Vector3(374.3587f, -772.0021f, 29.28101f),
new Vector3(450.5085f, -582.7377f, 28.49114f),
new Vector3(460.2195f, -537.1058f, 28.50289f),
new Vector3(480.4199f, -571.9922f, 28.9183f),
new Vector3(494.8138f, -590.9744f, 24.73877f),
new Vector3(522.8327f, -822.5538f, 24.47165f),
new Vector3(523.3926f, -874.7101f, 15.3947f),
new Vector3(47.83046f, -398.6124f, 73.94061f),
new Vector3(-112.2816f, -129.0802f, 93.70219f),
new Vector3(-105.208f, -122.0958f, 58.60808f),
new Vector3(-160.9816f, 75.24532f, 70.69436f),
new Vector3(83.31177f, 182.8947f, 104.79f),
new Vector3(37.45079f, 397.6803f, 117.4737f),
new Vector3(65.91094f, 394.3815f, 116.271f),
new Vector3(292.3093f, 263.5721f, 105.5877f),
new Vector3(696.011f, 247.2526f, 93.31503f),
new Vector3(938.9423f, -4.161302f, 78.9f),
new Vector3(1104.263f, 77.60244f, 80.883f),
new Vector3(999.1356f, -59.7887f, 74.94231f),
new Vector3(1014.825f, -119.9868f, 73.90351f),
new Vector3(958.6683f, -205.4425f, 73.33859f),
new Vector3(1097.246f, -208.6138f, 55.94757f),
new Vector3(1285.226f, -46.20168f, 62.6191f),
new Vector3(1263.157f, 314.3484f, 85.99043f),
new Vector3(1540.828f, 468.9011f, 222.388f),
new Vector3(736.0991f, 584.7528f, 125.9197f),
new Vector3(833.1614f, 496.8398f, 126.8128f),
new Vector3(698.8135f, 1199.501f, 345.5182f),
new Vector3(783.8715f, 1287.908f, 360.2964f),
new Vector3(489.0252f, 1272.726f, 295.778f),
new Vector3(149.5247f, 1672.548f, 228.682f),
new Vector3(-51.23613f, 1895.784f, 195.3618f),
new Vector3(-112.5192f, 1912.634f, 196.8822f),
new Vector3(-147.641f, 1901.725f, 197.2258f),
new Vector3(-734.5779f, 2053.848f, 109.2137f),
new Vector3(-1436.876f, 2148.406f, 33.71978f),
new Vector3(-1611.057f, 2229.886f, 80.99478f),
new Vector3(-1592.746f, 3051.707f, 32.56609f),
new Vector3(-519.5955f, 4473.346f, 89.79462f),
new Vector3(-164.3632f, 4249.758f, 44.92673f),
new Vector3(58.41208f, 3707.525f, 39.74107f),
new Vector3(333.2595f, 3562.381f, 33.74083f),
new Vector3(446.4857f, 3559.783f, 33.23508f),
new Vector3(651.6987f, 3503.63f, 34.17682f),
new Vector3(993.9822f, 3568.147f, 33.63492f),
new Vector3(1390.204f, 3618.42f, 38.92102f),
new Vector3(1432.696f, 3647.797f, 37.88709f),
new Vector3(1528.847f, 3696.367f, 34.58619f),
new Vector3(1829.271f, 3743.59f, 33.26161f),
new Vector3(1907.563f, 3900.043f, 32.60086f),
new Vector3(2488.097f, 3755.738f, 41.98464f),
new Vector3(2483.108f, 4102.696f, 38.12518f),
new Vector3(2513.314f, 4216.271f, 40.28469f),
new Vector3(2911.653f, 4306.729f, 50.40862f),
new Vector3(2939.927f, 4622.09f, 48.72093f),
new Vector3(2916.941f, 4643.989f, 48.54083f),
new Vector3(2487.277f, 4959.744f, 44.82774f),
new Vector3(2134.674f, 4999.725f, 41.41489f),
new Vector3(1940.914f, 5022.17f, 42.74247f),
new Vector3(1643.781f, 4866.208f, 42.02291f),
new Vector3(1668.208f, 4747.982f, 41.89182f),
new Vector3(1735.288f, 4684.381f, 43.34874f),
new Vector3(1721.794f, 4639.072f, 43.3143f),
new Vector3(1345.795f, 4388.532f, 44.34375f),
new Vector3(860.7209f, 4454.324f, 41.29826f),
new Vector3(357.3269f, 4418.707f, 63.43797f),
new Vector3(-488.1913f, 4941.69f, 144.8903f),
new Vector3(-528.6129f, 5302.675f, 75.34357f),
new Vector3(-544.9193f, 5364.231f, 70.70485f),
new Vector3(-666.7239f, 5801.801f, 17.51829f),
new Vector3(-685.9896f, 5793.793f, 17.33097f),
new Vector3(-435.2327f, 6213.563f, 29.6872f),
new Vector3(-217.565f, 6365.315f, 31.49236f),
new Vector3(-206.1148f, 6367.024f, 31.49533f),
new Vector3(-94.82183f, 6251.727f, 31.3482f),
new Vector3(32.58915f, 6231.255f, 31.81238f),
new Vector3(226.0136f, 6387.214f, 31.40311f),
new Vector3(164.7247f, 6653.003f, 32.56361f),
new Vector3(437.6944f, 6461.488f, 35.86514f),
new Vector3(428.9469f, 6477.097f, 28.78503f),
new Vector3(759.6691f, 6461.468f, 31.57145f),
new Vector3(754.0011f, 6466.709f, 42.27417f),
new Vector3(1483.354f, 6397.502f, 22.80187f),
new Vector3(2139.201f, 4779.23f, 40.97029f),
new Vector3(3606.565f, 3616.895f, 49.17775f),
new Vector3(3564.807f, 3693.589f, 40.80854f),
new Vector3(3945.225f, 3728.2f, 1.298444f),
new Vector3(3293.23f, 3146.624f, 253.1428f),
new Vector3(2947.351f, 2740.778f, 43.99383f),
new Vector3(2622.058f, 2808.805f, 33.58532f),
new Vector3(2328.856f, 2533.702f, 46.89039f),
new Vector3(2350.133f, 2610.429f, 46.59972f),
new Vector3(2280.393f, 2956.777f, 46.59579f),
new Vector3(2002.716f, 2931.256f, 56.97069f),
new Vector3(2103.553f, 2328.878f, 94.33661f),
new Vector3(2135.7f, 1945.318f, 93.78584f),
new Vector3(2291.085f, 1714.056f, 68.03069f),
new Vector3(2448.077f, 1586.273f, 32.71779f),
new Vector3(2765.186f, 1577.622f, 24.49854f),
new Vector3(2755.185f, 1508.574f, 30.78898f),
new Vector3(2659.166f, 1380.027f, 34.25811f),
new Vector3(2589.284f, 488.5549f, 108.5501f),
new Vector3(2483.241f, -362.362f, 93.73384f),
new Vector3(1698.063f, -1506.704f, 112.9722f),
new Vector3(1698.453f, -1706.591f, 112.5179f),
new Vector3(1544.377f, -2142.748f, 77.81533f),
new Vector3(1561.146f, -2209.141f, 77.89844f),
new Vector3(1011.557f, -2326.358f, 30.50335f),
new Vector3(825.0809f, -2340.658f, 30.33867f),
new Vector3(696.3788f, -2390.323f, 26.62175f),
new Vector3(108.6533f, -2137.074f, 28.34219f),
new Vector3(2.453212f, -2142.617f, 25.57415f),
new Vector3(-222.3739f, -2366.587f, 29.68058f),
new Vector3(-122.6774f, -2595.256f, 5.984539f),
new Vector3(32.66628f, -2728f, 2.136926f),
new Vector3(338.1417f, -2763.818f, 43.63188f),
new Vector3(238.5829f, -2999.47f, 5.747212f),
new Vector3(-554.7185f, -1797.85f, 22.53198f),
new Vector3(-589.8955f, -1777.23f, 22.74914f),
new Vector3(-1007.715f, -988.6847f, 2.125324f),
new Vector3(-1154.746f, -596.6807f, 27.33954f),
new Vector3(-1049.315f, -528.5356f, 36.77925f),
new Vector3(-622.608f, -271.4423f, 38.70083f),
new Vector3(-324.4347f, -257.2682f, 34.39084f),
new Vector3(-233.4641f, -359.1675f, 66.04935f),
new Vector3(-180.7209f, -1011.147f, 27.35233f),
new Vector3(-163.2766f, -1016.023f, 21.27683f),
new Vector3(-1.601244f, -1081.686f, 26.6716f),
new Vector3(23.83825f, -1103.137f, 38.14706f),
new Vector3(-478.4128f, -764.5854f, 30.56296f),
new Vector3(-1016.097f, 217.2731f, 64.98073f),
new Vector3(-1046.679f, 358.7034f, 69.9129f),
new Vector3(-1031.246f, 560.8202f, 100.5142f),
new Vector3(-816.531f, -751.734f, 22.84326f),
new Vector3(-1771.968f, -690.9758f, 10.45684f),
new Vector3(-793.5997f, 149.0899f, 71.04284f),
new Vector3(-803.9176f, 169.868f, 76.74026f),
World.GetNextPositionOnStreet(Vector3Extension.Around(Game.PlayerPed.Position, 200)),
        };

        public DeadBody()
        {

            Vector3 location = coordinates.OrderBy(x => World.GetDistance(x, Game.PlayerPed.Position)).Skip(3).First();

            InitInfo(location);
            ShortName = "Dead Body";
            CalloutDescription = "Someone found a dead body. Respond in Code 2.";
            ResponseCode = 2;
            StartDistance = 100f;
        }
        public async override Task OnAccept()
        {
            InitBlip(20);
            UpdateData();
            
        }
        public async override void OnStart(Ped player)
        {
            base.OnStart(player);
            body = await SpawnPed(RandomUtils.GetRandomPed(), Location);
            body.Kill();
            body.AttachBlip();
        }

    }
}
