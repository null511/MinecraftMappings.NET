using MinecraftMappings.Internal.Blocks;
using BedrockBlocks = MinecraftMappings.Minecraft.Bedrock.Blocks;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AnvilTop : JavaBlockData
    {
        public AnvilTop() : base("Anvil, Top")
        {
            AddVersion("anvil_top", version => {
                version.DefaultModel = typeof(Java.Models.Block.Anvil);
                //version.MapsToBedrockBlock = typeof(BedrockBlocks.AnvilTop);
            });
        }
    }
}
