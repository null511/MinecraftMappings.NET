using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Blackstone : JavaBlockModel
    {
        public Blackstone() : base("Blackstone")
        {
            AddVersion("blackstone", "1.16")
                .WithPath("models/block")
                .WithParent("block/cube_column")
                .AddTexture("end", "block/blackstone_top")
                .AddTexture("side", "block/blackstone");
        }
    }
}
