using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class AncientDebris : JavaBlockModel
    {
        public AncientDebris() : base("Ancient Debris")
        {
            AddVersion("ancient_debris", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/ancient_debris_top")
                .AddTexture("side", "block/ancient_debris_side");
        }
    }
}
