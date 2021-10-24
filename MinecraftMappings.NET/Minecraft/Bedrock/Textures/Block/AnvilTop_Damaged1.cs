using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AnvilTop_Damaged1 : BedrockBlockTexture
    {
        public AnvilTop_Damaged1() : base("Anvil Top, Damaged 1")
        {
            AddVersion("anvil_top_damaged_1")
                .MapsToJavaBlock<Java.Textures.Block.ChippedAnvilTop>();
        }
    }
}
