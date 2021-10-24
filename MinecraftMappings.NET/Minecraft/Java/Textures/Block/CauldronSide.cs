using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class CauldronSide : JavaBlockTexture
    {
        public CauldronSide() : base("Cauldron, Side")
        {
            AddVersion("cauldron_side")
                .WithDefaultModel<Java.Models.Block.Cauldron>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.CauldronSide>();
        }
    }
}
