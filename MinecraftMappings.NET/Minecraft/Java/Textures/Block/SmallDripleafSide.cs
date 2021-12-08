using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class SmallDripleafSide : JavaBlockTexture
    {
        public SmallDripleafSide() : base("Small Dripleaf Side")
        {
            AddVersion(7, "small_dripleaf_side")
                .WithMinVersion("1.17");
                //.WithDefaultModel<Java.Models.Block.SmallDripleafSide>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.SmallDripleafSide>();
        }
    }
}
