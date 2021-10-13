using MinecraftMappings.Internal.Models.Entity;

namespace MinecraftMappings.Minecraft.Java.Models.Entity
{
    public class Arrow : JavaEntityModel
    {
        public Arrow() : base("Arrow")
        {
            AddVersion("arrow", "1.0");
        }
    }
}
