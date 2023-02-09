using Kitchen;
using KitchenData;
using static Kitchen.UpdateQueuePatience;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;

namespace KitchenLogger
{
    /*
    public class Logger : GameSystemBase
    {
        EntityQuery eq;
        EntityQuery eq2;
        
        protected override void Initialise()
        {
            base.Initialise();
            eq = GetEntityQuery(new QueryHelper()
                .All(typeof(CCausesSpills))
                .Any()
                .None()
                );

            eq2 = GetEntityQuery(new QueryHelper()
                .All(typeof(CCustomerSettings))
                .Any()
                .None()
                );
        }

        protected override void OnUpdate()
        {
            NativeArray<Entity> entityArray = eq.ToEntityArray(Allocator.Temp);
            NativeArray<CCausesSpills> nativeArray = eq.ToComponentDataArray<CCausesSpills>(Allocator.Temp);
            if (entityArray.Length > 0)
            {
                Main.LogInfo("Spills");
                for (int i = 0; i < entityArray.Length; i++)
                {
                    Main.LogInfo($"Entity Index = {entityArray[i].Index}");
                    Main.LogInfo($"Mess ID = {nativeArray[i].ID}");
                    Main.LogInfo($"Mess Rate = {nativeArray[i].Rate}");
                }
            }



            NativeArray<Entity> entityArray2 = eq2.ToEntityArray(Allocator.Temp);
            NativeArray<CCustomerSettings> nativeArray2 = eq2.ToComponentDataArray<CCustomerSettings>(Allocator.Temp);
            if (entityArray2.Length > 0)
            {
                for (int i = 0; i < entityArray2.Length; i++)
                {
                    Main.LogInfo($"Entity Index = {entityArray2[i].Index}");
                    Main.LogInfo($"Mess Factor = {nativeArray2[i].Ordering.MessFactor}");
                }
            }

            if (entityArray.Length > 0 || entityArray2.Length > 0)
                Main.LogInfo("-----------------------------------------------------------------------------");
            entityArray.Dispose();
            nativeArray.Dispose();
            entityArray2.Dispose();
            nativeArray2.Dispose();
        }
    }
    */
}
