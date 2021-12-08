using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Glass : JavaBlockTexture
    {
        public Glass() : base("Glass")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("glass");
                //.WithDefaultModel<Java.Models.Block.Glass>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Glass>();
        }
    }
}
