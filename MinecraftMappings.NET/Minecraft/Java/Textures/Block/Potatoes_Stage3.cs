using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Potatoes_Stage3 : JavaBlockTexture
    {
        public Potatoes_Stage3() : base("Potatoes, Stage 3")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("potatoes_stage3");
                //.WithDefaultModel<Java.Models.Block.Potatoes_Stage3>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Potatoes_Stage3>();
        }
    }
}
