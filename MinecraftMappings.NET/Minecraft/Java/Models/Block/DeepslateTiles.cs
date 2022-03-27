using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class DeepslateTiles : JavaBlockModel
    {
        public DeepslateTiles() : base("Deepslate Tiles")
        {
            AddVersion("deepslate_tiles", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/deepslate_tiles");
        }
    }
}
