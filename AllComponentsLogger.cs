using Kitchen;
using KitchenData;
using KitchenLib.References;
using KitchenLib.Utils;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Entities;

namespace KitchenLogger
{
    public class AllComponentsLogger : GameSystemBase
    {
        EntityQuery eq;

        HashSet<int> idslogged = new HashSet<int>();

        protected override void Initialise()
        {
            base.Initialise();
            eq = GetEntityQuery(new QueryHelper()
                .All(typeof(CAppliance), typeof(CItemHolder))
                .Any()
                .None(typeof(CLetterBlueprint)));
        }

        protected override void OnUpdate()
        {
            if (eq.IsEmpty)
            {
                return;
            }
            NativeArray<Entity> entities = eq.ToEntityArray(Allocator.Temp);
            foreach (Entity entity in entities)
            {
                if (Require(entity, out CAppliance appliance) && (appliance.ID == ApplianceReferences.SinkStarting))
                {
                    if (Require(entity, out CItemHolder holder) && holder.HeldItem != default(Entity))
                    {
                        if (Require(holder.HeldItem, out CItem item))
                        {
                            Main.LogInfo($"{GDOUtils.GetExistingGDO(item.ID).name} ({item.ID})");
                        }
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
                Main.LogInfo($"{componentType.GetManagedType().Name}");
            }
            componentTypes.Dispose();
        }
    }
}
