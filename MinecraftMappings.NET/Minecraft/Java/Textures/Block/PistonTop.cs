using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class PistonTop : JavaBlockTexture
    {
        public PistonTop() : base("Piston Top")
        {
            AddVersion("piston_top")
                .WithDefaultModel<Java.Models.Block.Piston>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.PistonTop>();
        }
    }
}
