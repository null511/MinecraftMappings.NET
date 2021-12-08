using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beetroots_Stage0 : JavaBlockTexture
    {
        public Beetroots_Stage0() : base("Beetroots, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(2, "beetroots_stage0")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage0>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage0>();
        }
    }
}
