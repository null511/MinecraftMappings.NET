using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LargeFern : JavaBlockTexture
    {
        public LargeFern() : base("Large Fern")
        {
            AddVersion("large_fern")
                .WithDefaultModel<Java.Models.Block.LargeFern>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_Fern>();
        }
    }
}
