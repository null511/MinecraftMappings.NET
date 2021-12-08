using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Anvil : JavaBlockTexture
    {
        public Anvil() : base("Anvil")
        {
            AddVersion(0, "anvil")
                .WithMinVersion("1.4.2")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AnvilBase>();
        }
    }
}
