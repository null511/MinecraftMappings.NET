using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzureBluet : JavaBlockTexture
    {
        public AzureBluet() : base("Azure Bluet")
        {
            AddVersion("azure_bluet")
                .WithMinVersion(new GameVersion(1, 14))
                .WithDefaultModel<Java.Models.Block.AzureBluet>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerHoustonia>();
        }
    }
}
