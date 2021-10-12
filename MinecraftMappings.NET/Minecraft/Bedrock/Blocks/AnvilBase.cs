using MinecraftMappings.Internal.Blocks;

namespace MinecraftMappings.Minecraft.Bedrock.Blocks
{
    public class AnvilBase : BedrockBlockData
    {
        public AnvilBase() : base("Anvil Base")
        {
            AddVersion("anvil_base")
                .MapsToJavaBlock<Java.Textures.Block.Anvil>();
        }
    }
}
