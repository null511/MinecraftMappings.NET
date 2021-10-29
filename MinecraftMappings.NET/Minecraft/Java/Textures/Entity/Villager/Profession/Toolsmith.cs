using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Profession
{
    public class Toolsmith : JavaEntityTexture
    {
        public Toolsmith() : base("Toolsmith")
        {
            AddVersion("toolsmith")
                .WithPath("entity/villager/profession")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Toolsmith>();
        }
    }
}
