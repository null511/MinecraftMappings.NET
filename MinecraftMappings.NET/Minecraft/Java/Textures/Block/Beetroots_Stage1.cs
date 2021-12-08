using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beetroots_Stage1 : JavaBlockTexture
    {
        public Beetroots_Stage1() : base("Beetroots, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(2, "beetroots_stage1")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage1>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage1>();
        }
    }
}
