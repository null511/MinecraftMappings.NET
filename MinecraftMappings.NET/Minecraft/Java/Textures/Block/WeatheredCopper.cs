using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class WeatheredCopper : JavaBlockTexture
    {
        public WeatheredCopper() : base("Weathered Copper")
        {
            AddVersion("weathered_copper");
                //.WithDefaultModel<Java.Models.Block.WeatheredCopper>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.WeatheredCopper>();
        }
    }
}
