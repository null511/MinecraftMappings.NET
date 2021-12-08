using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beetroots_Stage3 : JavaBlockTexture
    {
        public Beetroots_Stage3() : base("Beetroots, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(2, "beetroots_stage3")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage3>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage3>();
        }
    }
}
