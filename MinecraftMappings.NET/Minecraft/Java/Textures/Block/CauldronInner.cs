using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronInner : JavaBlockTexture
    {
        public CauldronInner() : base("Cauldron, Inner")
        {
            AddVersion("cauldron_inner")
                .WithDefaultModel<Java.Models.Block.Cauldron>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CauldronInner>();
        }
    }
}
