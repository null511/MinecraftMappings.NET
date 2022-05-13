using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WeatheredCutCopper : JavaBlockTexture
    {
        public WeatheredCutCopper() : base("Weathered Cut Copper")
        {
            AddVersion("weathered_cut_copper")
                .WithDefaultModel<Java.Models.Block.WeatheredCutCopper>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WeatheredCutCopper>();
        }
    }
}
