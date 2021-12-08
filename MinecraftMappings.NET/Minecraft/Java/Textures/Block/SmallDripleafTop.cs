using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmallDripleafTop : JavaBlockTexture
    {
        public SmallDripleafTop() : base("Small Dripleaf Top")
        {
            AddVersion(7, "small_dripleaf_top")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.SmallDripleaf>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmallDripleafTop>();
        }
    }
}
