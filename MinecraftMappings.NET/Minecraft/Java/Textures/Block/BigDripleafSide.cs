using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class BigDripleafSide : JavaBlockTexture
    {
        public BigDripleafSide() : base("Big Dripleaf Side")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion(7, "big_dripleaf_side")
                .WithMinVersion("1.17")
                .WithDefaultModel<Java.Models.Block.BigDripleaf>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.BigDripleafSide>();
        }
    }
}
