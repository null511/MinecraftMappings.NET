using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PistonInner : JavaBlockTexture
    {
        public PistonInner() : base("Piston Inner")
        {
            AddVersion("piston_inner")
                .WithDefaultModel<Java.Models.Block.PistonBase>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PistonSide>();
        }
    }
}
