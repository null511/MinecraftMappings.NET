using MinecraftMappings.Internal.Models;
using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class Bedrock : JavaBlockModel
    {
        public Bedrock() : base("Bedrock")
        {
            AddVersion("bedrock", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_all")
                .AddTexture("all", "block/bedrock");
        }
    }
}
