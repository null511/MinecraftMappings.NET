using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Enderman
{
    public class EndermanEyes : JavaEntityTexture
    {
        public EndermanEyes() : base("Enderman Eyes")
        {
            AddVersion("enderman_eyes")
                .WithPath("entity/enderman")
                .WithBaseLayer<Enderman>()
                .WithDefaultModel<Java.Models.Entity.Enderman>();
                //.MapsToBedrockEntity<BedrockEntities.Enderman>();
        }
    }
}
