using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class TripwireHook : JavaBlockTexture
    {
        public TripwireHook() : base("Tripwire Hook")
        {
            AddVersion("tripwire_hook")
                .WithDefaultModel<Java.Models.Block.TripwireHook>()
                .MapsToBedrockBlock<MinecraftMappings.Minecraft.Bedrock.Textures.Block.TripWireSource>();
        }
    }
}
