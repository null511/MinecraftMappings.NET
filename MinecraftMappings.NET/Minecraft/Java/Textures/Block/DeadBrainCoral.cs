using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadBrainCoral : JavaBlockTexture
    {
        public DeadBrainCoral() : base("Dead Brain Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_brain_coral")
                .WithDefaultModel<Java.Models.Block.DeadBrainCoral>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadBrainCoral>();
        }
    }
}
