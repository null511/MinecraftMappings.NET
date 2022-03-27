using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Glowstone : JavaBlockModel
    {
        public Glowstone() : base("Glowstone")
        {
            AddVersion("glowstone", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/glowstone");
        }
    }
}
