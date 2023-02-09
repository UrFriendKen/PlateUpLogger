using Kitchen;
using KitchenData;
using System;
using System.ComponentModel;
using Unity.Collections;
using Unity.Entities;
using UnityEngine;
using static Kitchen.UpdateQueuePatience;

namespace KitchenLogger
{
    /*
    public class Logger : GameSystemBase
    {
        EntityQuery eq;
        EntityQuery eq2;
        int MaxEffectiveQueuersCount;
        protected override void Initialise()
        {
            base.Initialise();
            eq = GetEntityQuery(new QueryHelper()
                .All(typeof(CQueuePosition))
                .Any()
                .None()
                );

            eq2 = GetEntityQuery(new QueryHelper()
                .All(typeof(UpdateQueuePatience.CQueuePatienceBoost))
                .Any()
                .None()
                );

            MaxEffectiveQueuersCount = Mathf.CeilToInt(Mathf.Log10(5f) / Mathf.Log10(1.1f));
        }

        protected override void OnUpdate()
        {

            NativeArray<CQueuePatienceBoost> nativeArray = eq2.ToComponentDataArray<CQueuePatienceBoost>(Allocator.Temp);
            foreach (CQueuePatienceBoost item in nativeArray)
            {
                Main.LogInfo($"Boost Queue Patience Time (Seconds) = {item.Seconds}");
            }
            nativeArray.Dispose();


            //Number of Entities In Queue (int)
            //int num2 = Queuers.CalculateEntityCount();

            //Queuer Count Queue Patience Decrease Factor (float)
            //float num3 = Mathf.Min(5f, Mathf.Pow(1.1f, num2));
            NativeArray<Entity> entities = eq.ToEntityArray(Allocator.Temp);
            int num2 = eq.CalculateEntityCount();
            float num3 = Mathf.Min(5f, Mathf.Pow(1.1f, num2));
            Main.LogInfo($"Entities In Queue = {num2}");
            Main.LogInfo($"Queuer Count Queue Patience Decrease Factor = {num3}");

            int effectiveQueuerCount = Mathf.Pow(1.1f, num2) > 5f ? MaxEffectiveQueuersCount : num2;
            Main.LogInfo($"Effective Queuer Count = {effectiveQueuerCount}");


            //num4 = DifficultyHelpers.PatiencePlayerCountModifier(player_count)
            //From DifficultyHelpers.PatiencePlayerCountModifier
            //0 => 0.5f, 
            //1 => 0.75f, 
            //2 => 1f, 
            //3 => 1.1f, 
            //_ => 1.15f,

            //Exclusive Tier 1
            //float num5 = (HasStatus(RestaurantStatus.HasQueuePatienceBoost) ? 0.75f : 1f);
            Main.LogInfo($"RestaurantStatus.HasQueuePatienceBoost = {HasStatus(RestaurantStatus.HasQueuePatienceBoost)}");

            //Time passed since last update - Patience Boost Total (Negative value means remaining patience boost after accounting for time passed)
            //float num6 = base.Time.DeltaTime - num;

            //Time passed since last update - Patience Boost Total (Negative value means remaining patience boost after accounting for time passed)
            //float num7 = ((!HasSingleton<SWeatherDarkness>()) ? 1 : 2);
            //float num8 = num7;

            //Weather Impatience Rate
            //num7 = num8 * GetWeather() switch
            //{
            //    WeatherMode.None => 1f,
            //    WeatherMode.Rain => 1.5f,
            //    WeatherMode.Snow => 2f,
            //    _ => 1f,
            //};
            //num7 *= num5;

            //num7 /= GameData.Main.Difficulty.QueuePatienceTime; (GameData.Main.Difficulty.QueuePatienceTime = 100f)
            Main.LogInfo($"Some unknown calculation factor (num7/(x?)). x = {GameData.Main.Difficulty.QueuePatienceTime}");


            //component.RemainingTime -= num6 * num7 * num4 * num3;
            //component.RemainingTime -= ((Time Passed in Seconds) - (Boost Amount in Seconds)) * (DarknessFactor If Present) * (Weather Factor) * (Player Count Factor) * (Queuers Factor)
            //Queue Patience Remaining = [(Starting Queue Patience) - (Number of Groups In Queue Satisfied) * (Patience Recovery Amount = 10s)] * (Darkness Factor) * (Weather Factor) * (Player Count Factor) * (Queuers Factor)



        }

    }
    */
}
