using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Fish
{
    public class Pufferfish : JavaEntityTexture
    {
        public Pufferfish() : base("Pufferfish")
        {
            AddVersion("pufferfish")
                .WithPath("entity/fish")
                .WithDefaultModel<Java.Models.Entity.PufferFish_Big>();
                //.MapsToBedrockEntity<BedrockEntities.Pufferfish>();
        }
    }
}
