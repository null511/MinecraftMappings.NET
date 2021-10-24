using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FurnaceFrontOn : JavaBlockTexture
    {
        public FurnaceFrontOn() : base("Furnace Front, On")
        {
            AddVersion("furnace_front_on")
                .WithDefaultModel<Java.Models.Block.FurnaceOn>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FurnaceFrontOn>();
        }
    }
}
