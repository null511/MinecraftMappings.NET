using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class QuartzPillarTop : JavaBlockTexture
    {
        public QuartzPillarTop() : base("Quartz Pillar Top")
        {
            AddVersion("quartz_pillar_top")
                .WithDefaultModel<Java.Models.Block.QuartzPillar>();
                //.MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.QuartzPillarTop>();
        }
    }
}
