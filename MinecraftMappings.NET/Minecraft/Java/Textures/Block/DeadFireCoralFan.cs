using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadFireCoralFan : JavaBlockTexture
    {
        public DeadFireCoralFan() : base("Dead Fire Coral Fan")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_fire_coral_fan")
                .WithDefaultModel<Java.Models.Block.DeadFireCoralFan>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadFireCoralFan>();
        }
    }
}
