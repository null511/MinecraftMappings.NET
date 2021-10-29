using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CoarseDirt : JavaBlockModel
    {
        public CoarseDirt() : base("Coarse Dirt")
        {
            AddVersion("coarse_dirt", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/coarse_dirt");
        }
    }
}
