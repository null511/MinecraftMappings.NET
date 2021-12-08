using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class HornCoralFan : JavaBlockTexture
    {
        public HornCoralFan() : base("Horn Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("horn_coral_fan");
                //.WithDefaultModel<Java.Models.Block.HornCoralFan>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.HornCoralFan>();
        }
    }
}
