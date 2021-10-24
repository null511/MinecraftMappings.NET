using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzPillar : JavaBlockTexture
    {
        public QuartzPillar() : base("Quartz Pillar")
        {
            AddVersion("quartz_pillar")
                .WithDefaultModel<Java.Models.Block.QuartzPillar>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzPillar>();
        }
    }
}
