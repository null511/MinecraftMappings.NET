using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmallDripleafStemBottom : JavaBlockTexture
    {
        public SmallDripleafStemBottom() : base("Small Dripleaf Stem Bottom")
        {
            AddVersion(7, "small_dripleaf_stem_bottom")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.SmallDripleafStem>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmallDripleafStemBottom>();
        }
    }
}
