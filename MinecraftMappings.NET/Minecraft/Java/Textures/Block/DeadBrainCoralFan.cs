using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBrainCoralFan : JavaBlockTexture
    {
        public DeadBrainCoralFan() : base("Dead Brain Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_brain_coral_fan")
                .WithDefaultModel<Java.Models.Block.DeadBrainCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoralFan>();
        }
    }
}
