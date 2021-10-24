using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Bedrock.Textures.Block
{
    public class AnvilTop_Damaged2 : BedrockBlockTexture
    {
        public AnvilTop_Damaged2() : base("Anvil Top, Damaged 2")
        {
            AddVersion("anvil_top_damaged_2")
                .MapsToJavaBlock<Java.Textures.Block.DamagedAnvilTop>();
        }
    }
}
