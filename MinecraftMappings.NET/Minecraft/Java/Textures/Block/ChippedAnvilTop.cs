using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ChippedAnvilTop : JavaBlockTexture
    {
        public ChippedAnvilTop() : base("Chipped Anvil Top")
        {
            AddVersion("chipped_anvil_top")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AnvilTop_Damaged1>();
        }
    }
}
