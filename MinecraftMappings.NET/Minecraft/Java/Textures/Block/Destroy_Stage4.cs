using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class Destroy_Stage4 : JavaBlockTexture
    {
        public Destroy_Stage4() : base("Destroy, Stage 4")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("destroy_stage_4");
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.Destroy_Stage4>();
        }
    }
}
