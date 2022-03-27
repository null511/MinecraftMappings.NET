using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cocoa_Stage2 : JavaBlockTexture
    {
        public Cocoa_Stage2() : base("Cocoa, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cocoa_stage2")
                .WithDefaultModel<Java.Models.Block.Cocoa_Stage2>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Cocoa_Stage2>();
        }
    }
}
