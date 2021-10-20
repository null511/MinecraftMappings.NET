using MinecraftMappings.Internal.Textures.Block;

namespace MinecraftMappings.Minecraft.Java.Textures.Block
{
    public class ObserverSide : JavaBlockTexture
    {
        public ObserverSide() : base("Observer Side")
        {
            AddVersion("observer_side")
                .WithMinVersion("1.11")
                .WithDefaultModel<Java.Models.Block.Observer>();
                //.MapsToBedrockBlock<BedrockBlocks.ObserverSide>();
        }
    }
}
