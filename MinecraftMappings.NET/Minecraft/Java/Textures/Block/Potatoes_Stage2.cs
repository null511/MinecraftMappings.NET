using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Potatoes_Stage2 : JavaBlockTexture
    {
        public Potatoes_Stage2() : base("Potatoes, Stage 2")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("potatoes_stage2");
                //.WithDefaultModel<Java.Models.Block.Potatoes_Stage2>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Potatoes_Stage2>();
        }
    }
}
