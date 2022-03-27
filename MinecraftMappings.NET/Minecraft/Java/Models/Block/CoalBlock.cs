using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class CoalBlock : JavaBlockModel
    {
        public CoalBlock() : base("Coal Block")
        {
            AddVersion("coal_block", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/coal_block");
        }
    }
}
