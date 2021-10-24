using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PistonTopSticky : JavaBlockTexture
    {
        public PistonTopSticky() : base("Piston Top, Sticky")
        {
            AddVersion("piston_top_sticky")
                .WithDefaultModel<Java.Models.Block.StickyPiston>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PistonTopSticky>();
        }
    }
}
