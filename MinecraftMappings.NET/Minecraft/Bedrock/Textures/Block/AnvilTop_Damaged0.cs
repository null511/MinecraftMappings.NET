using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AnvilTop_Damaged0 : BedrockBlockTexture
    {
        public AnvilTop_Damaged0() : base("Anvil Top, Damaged 0")
        {
            AddVersion("anvil_top_damaged_0")
                .MapsToJavaBlock<Java.Textures.Block.AnvilTop>();
        }
    }
}
