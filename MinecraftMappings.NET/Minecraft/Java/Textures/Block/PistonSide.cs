using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PistonSide : JavaBlockTexture
    {
        public PistonSide() : base("Piston Side")
        {
            AddVersion("piston_side")
                .WithDefaultModel<Java.Models.Block.Piston>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PistonSide>();
        }
    }
}
