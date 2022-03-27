using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Clay : JavaBlockModel
    {
        public Clay() : base("Clay")
        {
            AddVersion("clay", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/clay");
        }
    }
}
