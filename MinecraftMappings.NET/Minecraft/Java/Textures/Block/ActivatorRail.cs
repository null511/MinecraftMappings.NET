using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ActivatorRail : JavaBlockTexture
    {
        public ActivatorRail() : base("Activator Rail")
        {
            AddVersion("activator_rail")
                .WithDefaultModel<Java.Models.Block.ActivatorRail>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.RailActivator>();
        }
    }
}
