using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HornCoral : JavaBlockTexture
    {
        public HornCoral() : base("Horn Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("horn_coral");
                //.WithDefaultModel<Java.Models.Block.HornCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HornCoral>();
        }
    }
}
