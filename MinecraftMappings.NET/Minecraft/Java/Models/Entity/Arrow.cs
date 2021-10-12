using MinecraftMappings.Internal.Entities;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Arrow : JavaEntityData
    {
        public const string EntityId = "arrow";
        public const string EntityName = "Arrow";


        public Arrow() : base(EntityName)
        {
            Versions.Add(new JavaEntityDataVersion {
                Id = EntityId,
            });
        }
    }
}
