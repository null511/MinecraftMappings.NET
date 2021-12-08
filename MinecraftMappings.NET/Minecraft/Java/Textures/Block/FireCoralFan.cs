using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class FireCoralFan : JavaBlockTexture
    {
        public FireCoralFan() : base("Fire Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("fire_coral_fan");
                //.WithDefaultModel<Java.Models.Block.FireCoralFan>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.FireCoralFan>();
        }
    }
}
