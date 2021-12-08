using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cocoa_Stage1 : JavaBlockTexture
    {
        public Cocoa_Stage1() : base("Cocoa, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cocoa_stage1");
                //.WithDefaultModel<Java.Models.Block.Cocoa_Stage1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Cocoa_Stage1>();
        }
    }
}
