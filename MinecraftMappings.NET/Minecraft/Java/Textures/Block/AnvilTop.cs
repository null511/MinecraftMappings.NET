using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AnvilTop : JavaBlockTexture
    {
        public AnvilTop() : base("Anvil Top")
        {
            AddVersion(0, "anvil_top")
                .WithMinVersion("1.4.2")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AnvilTop_Damaged0>();
        }
    }
}
