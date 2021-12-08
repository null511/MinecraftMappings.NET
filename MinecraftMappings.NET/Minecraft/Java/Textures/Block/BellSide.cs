using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BellSide : JavaBlockTexture
    {
        public BellSide() : base("Bell Side")
        {
            AddVersion(4, "bell_side")
                .WithMinVersion("1.14")
                .WithDefaultModel<Java.Models.Block.BellFloor>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellSide>();
        }
    }
}
