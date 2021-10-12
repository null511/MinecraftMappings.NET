using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class Beacon : BedrockBlockData
    {
        public Beacon() : base("Beacon")
        {
            AddVersion("beacon")
                //.WithDefaultModel<Bedrock.Models.Block.Beacon>()
                .MapsToJavaBlock<Java.Textures.Block.Beacon>();
        }
    }
}
