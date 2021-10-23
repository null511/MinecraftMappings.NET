using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FurnaceSide : JavaBlockTexture
    {
        public FurnaceSide() : base("Furnace Side")
        {
            AddVersion("furnace_side")
                .WithDefaultModel<Java.Models.Block.Furnace>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FurnaceSide>();
        }
    }
}
