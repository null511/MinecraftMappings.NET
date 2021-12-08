using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TubeCoralFan : JavaBlockTexture
    {
        public TubeCoralFan() : base("Tube Coral Fan")
        {
            AddVersion("tube_coral_fan");
                //.WithDefaultModel<Java.Models.Block.TubeCoralFan>()
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TubeCoralFan>();
        }
    }
}
