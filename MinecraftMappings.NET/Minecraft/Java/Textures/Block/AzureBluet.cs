using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class AzureBluet : JavaBlockTexture
    {
        public AzureBluet() : base("Azure Bluet")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(1, "azure_bluet")
                .WithMinVersion("1.7.2")
                .WithDefaultModel<Java.Models.Block.AzureBluet>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FlowerHoustonia>();
        }
    }
}
