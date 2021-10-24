using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronBottom : JavaBlockTexture
    {
        public CauldronBottom() : base("Cauldron, Bottom")
        {
            AddVersion("cauldron_bottom")
                .WithDefaultModel<Java.Models.Block.Cauldron>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CauldronBottom>();
        }
    }
}
