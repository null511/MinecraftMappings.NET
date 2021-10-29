using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Villager.Profession
{
    public class Nitwit : JavaEntityTexture
    {
        public Nitwit() : base("Nitwit")
        {
            AddVersion("nitwit")
                .WithPath("entity/villager/profession")
                .WithBaseLayer<Villager>()
                .WithDefaultModel<Java.Models.Entity.Villager>();
                //.MapsToBedrockEntity<BedrockEntities.Nitwit>();
        }
    }
}
