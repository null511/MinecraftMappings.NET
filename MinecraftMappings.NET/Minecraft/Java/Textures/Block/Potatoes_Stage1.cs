using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Potatoes_Stage1 : JavaBlockTexture
    {
        public Potatoes_Stage1() : base("Potatoes, Stage 1")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("potatoes_stage1");
                //.WithDefaultModel<Java.Models.Block.Potatoes_Stage1>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Potatoes_Stage1>();
        }
    }
}
