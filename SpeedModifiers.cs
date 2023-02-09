using Kitchen;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace KitchenLogger
{
    /*
    public class SpeedModifiers : GameSystemBase
    {
        EntityQuery SlowPlayer;
        EntityQuery SlowPlayerTools;
        EntityQuery Shoes;

        protected override void Initialise()
        {
            base.Initialise();
            SlowPlayer = GetEntityQuery(new QueryHelper().All(typeof(CPosition), typeof(CSlowPlayer)).None(typeof(CToolInUse)));
            SlowPlayerTools = GetEntityQuery(typeof(CToolInUse), typeof(CSlowPlayer));
            Shoes = GetEntityQuery(typeof(CShoeEffect));
        }

        protected override void OnUpdate()
        {
            NativeArray<Entity> slowPlayers = SlowPlayer.ToEntityArray(Allocator.Temp);
            NativeArray<CSlowPlayer> cSlowPlayers = SlowPlayer.ToComponentDataArray<CSlowPlayer>(Allocator.Temp);

            NativeArray<Entity> slowPlayerTools = SlowPlayerTools.ToEntityArray(Allocator.Temp);
            NativeArray<CSlowPlayer> cSlowPlayerTools = SlowPlayerTools.ToComponentDataArray<CSlowPlayer>(Allocator.Temp);

            NativeArray<Entity> shoes = Shoes.ToEntityArray(Allocator.Temp);
            NativeArray<CShoeEffect> cShoeEffects = Shoes.ToComponentDataArray<CShoeEffect>(Allocator.Temp);

            int slowersCount = SlowPlayer.CalculateEntityCount();
            if (slowersCount > 0)
            {
                Main.LogInfo($"Slowers Count = {slowersCount}");
                for (int i = 0; i < slowPlayers.Length; i++)
                {
                    Main.LogInfo($"Entity ID = {slowPlayers[i].Index}");
                    Main.LogInfo($"Slow Factor = {cSlowPlayers[i].Factor}");
                    Main.LogInfo($"Slow Radius = {cSlowPlayers[i].Radius}");
                }
            }


            int slowerToolsCount = SlowPlayerTools.CalculateEntityCount();
            if (slowerToolsCount > 0)
            {
                Main.LogInfo($"Slower Tools Count = {SlowPlayerTools.CalculateEntityCount()}");
                for (int i = 0; i < slowPlayerTools.Length; i++)
                {
                    Main.LogInfo($"Entity ID = {slowPlayerTools[i].Index}");
                    Main.LogInfo($"Slow Factor = {cSlowPlayerTools[i].Factor}");
                    Main.LogInfo($"Slow Radius = {cSlowPlayerTools[i].Radius}");
                }
            }


            //int shoesCount = Shoes.CalculateEntityCount();
            //if (shoesCount > 0)
            //{
            //    Main.LogInfo($"Shoes Count = {shoesCount}");
            //    for (int i = 0; i < shoes.Length; i++)
            //    {
            //        Main.LogInfo($"Entity ID = {shoes[i].Index}");
            //        Main.LogInfo($"Speed Modifier = {cShoeEffects[i].SpeedModifier}");
            //        Main.LogInfo($"Ignore Mess = {cShoeEffects[i].IgnoreMess}");
            //    }
            //}
            //if (slowersCount > 0 || slowerToolsCount > 0 || shoesCount > 0)
            //    Main.LogInfo("-------------------------------------------------------------------------------------------------------------");
            if (slowersCount > 0 || slowerToolsCount > 0)
                Main.LogInfo("-------------------------------------------------------------------------------------------------------------");
        }
    }
    */
}
