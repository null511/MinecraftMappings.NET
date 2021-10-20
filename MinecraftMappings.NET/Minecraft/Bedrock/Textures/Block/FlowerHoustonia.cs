using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class FlowerHoustonia : BedrockBlockTexture
    {
        public FlowerHoustonia() : base("Flower Houstonia")
        {
            AddVersion("flower_houstonia")
                .MapsToJavaBlock<Java.Textures.Block.AzureBluet>();
        }
    }
}
