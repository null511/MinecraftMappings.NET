using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class FireCoral : JavaBlockModel
    {
        public FireCoral() : base("Fire Coral")
        {
            AddVersion("fire_coral", "1.14")
                .WithPath("models/block")
                .WithParent("block/cross")
                .AddTexture("cross", "block/fire_coral");
        }
    }
}
