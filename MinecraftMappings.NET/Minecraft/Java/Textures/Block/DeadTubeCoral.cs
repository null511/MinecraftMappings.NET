using MinecraftMappings.Internal;
using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class DeadTubeCoral : JavaBlockTexture
    {
        public DeadTubeCoral() : base("Dead Tube Coral")
        {
            BlendMode = BlendModes.Cutout;

            AddVersion("dead_tube_coral");
                //.WithDefaultModel<Java.Models.Block.DeadTubeCoral>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.DeadTubeCoral>();
        }
    }
}
