using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Potatoes_Stage0 : JavaBlockTexture
    {
        public Potatoes_Stage0() : base("Potatoes, Stage 0")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("potatoes_stage0");
                //.WithDefaultModel<Java.Models.Block.Potatoes_Stage0>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Potatoes_Stage0>();
        }
    }
}
