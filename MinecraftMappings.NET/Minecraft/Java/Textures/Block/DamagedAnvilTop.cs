using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DamagedAnvilTop : JavaBlockTexture
    {
        public DamagedAnvilTop() : base("Damaged Anvil Top")
        {
            AddVersion("damaged_anvil_top")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AnvilTop_Damaged2>();
        }
    }
}
