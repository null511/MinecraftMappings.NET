using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadHornCoralFan : JavaBlockTexture
    {
        public DeadHornCoralFan() : base("Dead Horn Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_horn_coral_fan")
                .WithDefaultModel<Java.Models.Block.DeadHornCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadHornCoralFan>();
        }
    }
}
