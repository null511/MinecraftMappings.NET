using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadTubeCoralFan : JavaBlockTexture
    {
        public DeadTubeCoralFan() : base("Dead Tube Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_tube_coral_fan")
                .WithDefaultModel<Java.Models.Block.DeadTubeCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadTubeCoralFan>();
        }
    }
}
