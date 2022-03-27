using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Glass : JavaBlockModel
    {
        public Glass() : base("Glass")
        {
            AddVersion("glass", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/glass");
        }
    }
}
