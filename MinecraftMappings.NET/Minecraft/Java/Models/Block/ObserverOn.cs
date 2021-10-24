using MinecraftMappings.Internal.Models.Block;

namespace MinecraftMappings.Minecraft.Java.Models.Block
{
    public class ObserverOn : JavaBlockModel
    {
        public ObserverOn() : base("Observer, On")
        {
            AddVersion("observer_on", "1.11")
                .WithPath("models/block")
                .WithParent("block/observer")
                .AddTexture("bottom", "block/observer_back_on");
        }
    }
}
