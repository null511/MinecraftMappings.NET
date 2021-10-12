using MinecraftMappings.Internal.Entities;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Alex : JavaEntityData
    {
        public const string EntityId = "alex";
        public const string EntityName = "Alex";


        public Alex() : base(EntityName)
        {
            Versions.Add(new JavaEntityDataVersion {
                Id = EntityId,
            });
        }
    }
}
