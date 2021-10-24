using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PistonBottom : JavaBlockTexture
    {
        public PistonBottom() : base("Piston Bottom")
        {
            AddVersion("piston_bottom")
                .WithDefaultModel<Java.Models.Block.Piston>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PistonBottom>();
        }
    }
}
