using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
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
