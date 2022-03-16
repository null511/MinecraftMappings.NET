using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Illager
{
    public class EvokerFangs : JavaEntityTexture
    {
        public EvokerFangs() : base("Evoker Fangs")
        {
            AddVersion("evoker_fangs")
                .WithPath("entity/illager")
                .WithDefaultModel<Java.Models.Entity.EvokerFangs>();
                //.MapsToBedrockEntity<BedrockEntities.EvokerFangs>();
        }
    }
}
