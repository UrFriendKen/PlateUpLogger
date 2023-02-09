using Kitchen;
using KitchenData;
using Unity.Collections;
using Unity.Entities;

namespace KitchenLogger
{
    /*
    public class FindingSinkToFixPotDupe : GameSystemBase
    {
        EntityQuery eq;

        protected override void Initialise()
        {
            base.Initialise();
            eq = GetEntityQuery(new QueryHelper()
                .All(typeof(CAppliance))
                .Any()
                .None());
        }

        protected override void OnUpdate()
        {
            NativeArray<Entity> entities = eq.ToEntityArray(Allocator.Temp);

            foreach (Entity entity in entities)
            {
                if (Require(entity, out CAppliance appliance) && (appliance.ID == AssetReference.Sink))
                {
                    Main.LogInfo("Sink");
                    //LogAllECSComponents(entity);
                    //if (Require(entity, out CItemProvider provider))
                    //{
                    //    Main.LogInfo($"provider.Available = {provider.Available}");
                    //    Main.LogInfo($"provider.Maximum = {provider.Maximum}");
                    //    Main.LogInfo($"provider.DirectInsertionOnly = {provider.DirectInsertionOnly}");
                    //    Main.LogInfo($"provider.EmptyAtNight = {provider.EmptyAtNight}");
                    //    Main.LogInfo($"provider.PreventReturns = {provider.PreventReturns}");
                    //    Main.LogInfo($"provider.DestroyOnEmpty = {provider.DestroyOnEmpty}");
                    //    Main.LogInfo($"provider.AutoGrabFromHolder = {provider.AutoGrabFromHolder}");
                    //    Main.LogInfo($"provider.AutoPlaceOnHolder = {provider.AutoPlaceOnHolder}");
                    //    Main.LogInfo($"provider.AllowRefreshes = {provider.AllowRefreshes}");
                    //    Main.LogInfo($"provider.ProvidedItem = {provider.ProvidedItem}");
                    //    Main.LogInfo($"provider.MDefaultProvidedItemaximum = {provider.DefaultProvidedItem}");
                    //}

                    if (Require(entity, out CItemHolder held) && Require<CItem>(held.HeldItem, out CItem item))
                    {
                        Main.LogInfo($"{item.ID}");
                    }
                }
            }
            entities.Dispose();
        }

        private void LogAllECSComponents(Entity entity)
        {
            NativeArray<ComponentType> componentTypes = EntityManager.GetComponentTypes(entity);
            foreach (ComponentType componentType in componentTypes)
            {
                Main.LogInfo($"{componentType.GetManagedType().Name} ({componentType.GetManagedType().GUID})");
            }
            componentTypes.Dispose();
        }
    }
    */
}
