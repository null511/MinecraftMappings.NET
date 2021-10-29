using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class LargeFernBottom : JavaBlockTexture
    {
        public LargeFernBottom() : base("Large Fern Bottom")
        {
            AddVersion("large_fern_bottom")
                .WithDefaultModel<Java.Models.Block.LargeFernBottom>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DoublePlant_FernBottom>();
        }
    }
}
