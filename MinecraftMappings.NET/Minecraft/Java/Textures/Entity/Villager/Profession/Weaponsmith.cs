using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Profession
{
    public class Weaponsmith : JavaEntityTexture
    {
        public Weaponsmith() : base("Weaponsmith")
        {
            AddVersion("weaponsmith")
                .WithPath("entity/villager/profession")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Weaponsmith>();
        }
    }
}
