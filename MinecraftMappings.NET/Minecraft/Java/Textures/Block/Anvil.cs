using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Anvil : JavaBlockTexture
    {
        public Anvil() : base("Anvil")
        {
            AddVersion("anvil")
                .WithDefaultModel<Java.Models.Block.Anvil>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.AnvilBase>();
        }
    }
}
