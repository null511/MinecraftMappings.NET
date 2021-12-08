using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BigDripleafTip : JavaBlockTexture
    {
        public BigDripleafTip() : base("Big Dripleaf Tip")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "big_dripleaf_tip")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.BigDripleaf>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BellTop>();
        }
    }
}
