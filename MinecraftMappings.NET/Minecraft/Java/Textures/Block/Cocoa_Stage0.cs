using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Cocoa_Stage0 : JavaBlockTexture
    {
        public Cocoa_Stage0() : base("Cocoa, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("cocoa_stage0")
                .WithDefaultModel<Java.Models.Block.Cocoa_Stage0>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Cocoa_Stage0>();
        }
    }
}
