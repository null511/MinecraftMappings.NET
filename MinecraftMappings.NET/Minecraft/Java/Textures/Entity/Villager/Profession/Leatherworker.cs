using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Profession
{
    public class Leatherworker : JavaEntityTexture
    {
        public Leatherworker() : base("Leatherworker")
        {
            AddVersion("leatherworker")
                .WithPath("entity/villager/profession")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Leatherworker>();
        }
    }
}
