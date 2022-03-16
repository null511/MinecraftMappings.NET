using MinecraftMappings.Internal.Textures.Entity;

namespace MinecraftMappings.Minecraft.Java.Textures.Entity.Axolotl
{
    public class Axolotl_Wild : JavaEntityTexture
    {
        public Axolotl_Wild() : base("Axolotl, Wild")
        {
            AddVersion("axolotl_wild")
                .WithPath("entity")
                .WithDefaultModel<Java.Models.Entity.Axolotl>();
                //.MapsToBedrockEntity<BedrockEntities.Axolotl_Wild>();
        }
    }
}
