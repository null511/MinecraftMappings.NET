using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class BedrockMirrored : JavaBlockModel
    {
        public BedrockMirrored() : base("Bedrock, Mirrored")
        {
            AddVersion("bedrock_mirrored", "1.0.0")
                .WithPath("models/block")
                .WithParent("block/cube_mirrored_all")
                .AddTexture("all", "block/bedrock");
        }
    }
}
