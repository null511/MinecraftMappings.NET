using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Beetroots_Stage2 : JavaBlockTexture
    {
        public Beetroots_Stage2() : base("Beetroots, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(2, "beetroots_stage2")
                .WithMinVersion("1.9")
                .WithDefaultModel<Java.Models.Block.BeetrootsStage2>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BeetrootsStage2>();
        }
    }
}
