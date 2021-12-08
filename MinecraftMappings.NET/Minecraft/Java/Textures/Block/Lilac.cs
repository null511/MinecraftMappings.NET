using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Lilac : JavaBlockTexture
    {
        public Lilac() : base("Lilac")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("lilac");
                //.WithDefaultModel<Java.Models.Block.LilacBottom>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.LilacBottom>();
        }
    }
}
